using OmniSoftwareStudio.OrganismGA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeDTransformationOptimization
{

    public partial class MainForm : Form
    {
        public MainForm( )
        {
            InitializeComponent( );
            lowerBounds = new double[ 6 ] { -50, -50, -50, -Math.PI / 2, -Math.PI / 2, -Math.PI / 2 };
            upperBounds = new double[ 6 ] { 50, 50, 50, Math.PI / 2, Math.PI / 2, Math.PI / 2 };
        }

        double x, y, z, xang, yang, zang;
        double[ ] lowerBounds, upperBounds;

        private void btnGenerate_Click( object sender, EventArgs e )
        {
            int pos = txbPars.Text.IndexOf( "=", 0  );
            int len = txbPars.Text.IndexOf( '\r', pos + 1 ) - pos - 1;
            string s = txbPars.Text.Substring( pos + 1, len );
            x = double.Parse( s );

            pos = txbPars.Text.IndexOf( "=", pos );
            len = txbPars.Text.IndexOf( '\r', pos + 1 ) - pos - 1;
            s = txbPars.Text.Substring( pos + 1, len );
            y = double.Parse( s );

            pos = txbPars.Text.IndexOf( "=", pos + len);
            len = txbPars.Text.IndexOf( '\r', pos + 1 ) - pos - 1;
            s = txbPars.Text.Substring( pos + 1, len );
            z = double.Parse( s );

            pos = txbPars.Text.IndexOf( "=", pos + len );
            len = txbPars.Text.IndexOf( '\r', pos + 1 ) - pos - 1;
            s = txbPars.Text.Substring( pos + 1, len );
            xang = double.Parse( s ) * Math.PI / 180.0;

            pos = txbPars.Text.IndexOf( "=", pos + len );
            len = txbPars.Text.IndexOf( '\r', pos + 1 ) - pos - 1;
            s = txbPars.Text.Substring( pos + 1, len );
            yang = double.Parse( s ) * Math.PI / 180.0;

            pos = txbPars.Text.IndexOf( "=", pos + len );
            len = txbPars.Text.IndexOf( '\r', pos + 1 ) - pos - 1;
            s = txbPars.Text.Substring( pos + 1, len );
            zang = double.Parse( s ) * Math.PI  / 180.0;

            SetupMatrices( );


            int num = (int)nudNumber.Value;
            Nominals = new double[ num][];
            Sample = new double[ num ][];
            for( int i = 0 ; i < num ; i++  )
            {
                Nominals[ i ] = new double[ 4 ];
                Sample[ i ] = new double[ 4 ];
                Nominals[ i][0 ] = Sample[ i][0 ] = 30+ rnd.NextDouble( ) * 40.0;
                Nominals[ i][1 ] = Sample[ i][1 ] = 30 + rnd.NextDouble( ) * 40.0;
                Nominals[ i][2 ] = Sample[ i][2 ] = 30 + rnd.NextDouble( ) * 40.0;
                Nominals[ i][ 3 ] = Sample[ i][ 3 ] = 1.0;
            }
            // Reverse Transform samples
            ReverseTransformSample( );

            for( int i = 0 ; i < num ; i++ )
            {
                points3D1.Add( Nominals[ i ][ 0 ], Nominals[ i ][ 2 ], Nominals[ i ][ 1 ] );
                points3D2.Add( Sample[ i ][ 0 ], Sample[ i ][ 2 ], Sample[ i ][ 1 ] );

            }
        }


        double[ ][] Nominals, Sample, optimum;
        GASolver mySolver;
        GAExecutionPanel pnlGA;

        private void btnOptimize_Click( object sender, EventArgs e )
        {
            mySolver = GASolver.CreateRealNumberGASolver( OptimizationType.Min, 6, lowerBounds, upperBounds, objectiveFunction );
            mySolver.CreateManagementPanel( spcSecond.Panel2 );
 

            mySolver.OneNormalRunCompleted += MySolver_OneNormalRunCompleted;
        }

        private void MySolver_OneNormalRunCompleted( object sender, EventArgs e )
        {
            this.Invoke
                (
                new Action
                    ( ( ) =>
                        {
                        rtbScreen.Clear( );
                        rtbScreen.AppendText( $"objective = {mySolver.SoFarTheBestObjective:0.000}\n" );
                            double[ ] best = mySolver.SoFarTheBestSolutionAsADoubleArray;
                        rtbScreen.AppendText( $"transformation parameters:\nx = {best[ 0 ]:0.00}\ny = {best[ 1 ]:0.00}\nz = {best[ 2 ]:0.00}\nxang = { 180.0 * best[ 3 ] / Math.PI:0.00}\nyang = {best[ 4 ] * 180.0 / Math.PI:0.00}\nzang = {best[ 5 ] * 180.0 / Math.PI:0.00}\n" );
                            displayTransformResults( );
                        }
                    )
                );
        }

        private void displayTransformResults( )
        {
            double[ ] bestPars = mySolver.SoFarTheBestSolutionAsADoubleArray;
            x = bestPars[ 0 ]; y = bestPars[ 1 ]; z = bestPars[ 2 ];
            xang = bestPars[ 3 ]; yang = bestPars[ 4 ]; zang = bestPars[ 5 ];
            SetupMatrices( );
            points3D3.Clear( );
            for( int i = 0 ; i < Sample.Length ; i++ )
            {
                for( int j = 0 ; j < 4 ; j++ ) vector[ j ] = Sample[ i ][ j ];
                matrixTimeVector( rotateX, vector );
                matrixTimeVector( rotateY, vector );
                matrixTimeVector( rotateZ, vector );
                matrixTimeVector( translate, vector );
                points3D3.Add( vector[ 0 ], vector[ 2 ], vector[ 1 ] );
            }
  
        }

        void ShowResult()
        {

        }
        double[ ] vector = new double[ 4 ];

        private void label4_Click( object sender, EventArgs e )
        {

        }

        private double objectiveFunction( double[ ] solution )
        {
            x = solution[ 0 ]; y = solution[ 1 ]; z = solution[ 2 ];
            xang = solution[ 3 ]; yang = solution[ 4 ]; zang = solution[ 5 ];
            SetupMatrices( );
            double sumOfErrorSquare = 0;
            for( int i = 0 ; i < Sample.Length ; i++  )
            {
                for( int j = 0 ; j < 4 ; j++ ) vector[j] = Sample[ i ][j];
                matrixTimeVector( rotateX, vector );
                matrixTimeVector( rotateY, vector );
                matrixTimeVector( rotateZ, vector );
                matrixTimeVector( translate, vector );
                sumOfErrorSquare +=
                    ( vector[ 0 ] - Nominals[ i ][ 0 ] ) * ( vector[ 0 ] - Nominals[ i ][ 0 ] ) +
                    ( vector[ 1 ] - Nominals[ i ][1 ] ) * ( vector[ 1 ] - Nominals[ i ][ 1 ] ) +
                    ( vector[ 2] - Nominals[ i ][ 2 ] ) * ( vector[ 2 ] - Nominals[ i ][ 2 ] ) ;
            }

            return sumOfErrorSquare;
        }

        double[ , ] translate, reverseTranslate, rotateX, reverseRotateX, rotateY, reverseRotateY, rotateZ, reverseRotateZ;

        void SetupMatrices()
        {
            if( translate == null )
            {
                translate = new double[ 4, 4 ];
                reverseTranslate = new double[ 4, 4 ];
                rotateX = new double[ 4, 4 ];
                reverseRotateX = new double[ 4, 4 ];
                rotateY = new double[ 4, 4 ];
                reverseRotateY = new double[ 4, 4 ];
                rotateZ = new double[ 4, 4 ];
                reverseRotateZ = new double[ 4, 4 ];
            }
            for( int r = 0 ; r< 4 ; r++ )
                for( int c = 0 ; c < 4 ; c++ )
                {
                    if( r == c )
                        translate[ r, c ] = reverseTranslate[ r, c ] = rotateX[ r, c ] = rotateY[ r, c ] =
    rotateZ[ r, c ] = reverseRotateX[ r, c ] = reverseRotateY[ r, c ] = reverseRotateZ[ r, c ] = 1;

                    else
                        translate[ r, c ] = reverseTranslate[ r, c ] = rotateX[ r, c ] = rotateY[ r, c ] =
                            rotateZ[ r, c ] = reverseRotateX[ r, c ] = reverseRotateY[ r, c ] = reverseRotateZ[ r, c ] = 0;

                }
            translate[ 0, 3 ] = x; reverseTranslate[ 0, 3 ] = -x;
            translate[ 1, 3 ] = y; reverseTranslate[ 1, 3 ] = -y;
            translate[ 2, 3 ] = z; reverseTranslate[ 2, 3 ] = -z;
            double cos = Math.Cos( xang ), sin = Math.Sin( xang );
            rotateX[ 1, 1 ] = rotateX[ 2, 2 ] = reverseRotateX[ 1, 1 ] = reverseRotateX[ 2, 2 ] = cos;
            rotateX[ 1, 2 ] = reverseRotateX[ 2, 1 ] = -sin;
            rotateX[ 2, 1 ] = reverseRotateX[ 1, 2 ] = sin;
            cos = Math.Cos( yang );
            sin = Math.Sin( yang );
            rotateY[ 0, 0 ] = rotateY[ 2, 2 ] = reverseRotateY[ 0, 0 ] = reverseRotateY[ 2, 2 ] = cos;
            rotateY[ 0, 2 ] = reverseRotateY[ 2, 0 ] = sin;
            rotateY[ 2, 0 ] = reverseRotateY[ 0, 2 ] = -sin;
            cos = Math.Cos( zang );
            sin = Math.Sin( zang );
            rotateZ[ 1, 1 ] = rotateZ[ 0, 0 ] = reverseRotateZ[ 1, 1 ] = reverseRotateZ[ 0, 0 ] = cos;
            rotateZ[ 0, 1 ] = reverseRotateZ[ 1, 0 ] = -sin;
            rotateZ[ 2, 1 ] = reverseRotateZ[ 0, 1 ] = sin;
        }
        Random rnd = new Random( );

        double[ ] temp = new double[ 4 ];

        void  matrixTimeVector( double[,] m, double[]v )
        {
            for( int r = 0 ; r < 4 ; r++ )
            {
                temp[r] = 0;
                for( int c = 0 ; c < 4 ; c++ )
                {
                    temp[ r ] += m[ r, c ] * v[ c ];
                }
            }
            for( int r = 0 ; r < 4 ; r++ ) v[ r ] = temp[ r ];
            
        }

        void ReverseTransformSample()
        {
            int num = Sample.GetLength( 0 );
            //translate, rotate z, rotate y rotate x;
            for( int r = 0 ; r < num ; r++ )
            {
                matrixTimeVector( reverseTranslate, Sample[ r ] );
                matrixTimeVector( reverseRotateZ, Sample[ r ] );
                matrixTimeVector( reverseRotateY, Sample[ r ] );
                matrixTimeVector( reverseRotateX, Sample[ r ] );
            }
        }

        public class Point3D
        {
            public double x, y, z;
            public double w = 1;
        }
    }
}
