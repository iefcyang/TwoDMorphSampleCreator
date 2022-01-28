using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TwoDMorph
{
    public partial class MainForm : Form
    {
        public MainForm( )
        {
            InitializeComponent( );
        }
        int numberOfPoints = 0;
        DataTable dttPoints, dttDistances;

        int hitCount = 0;
        int id = -1;
        Series s;
        private void chtMap_MouseUp( object sender, MouseEventArgs e )
        {
            PointF p = PointF.Empty;
            p.X= (float) chtMap.ChartAreas[ 0 ].AxisX.PixelPositionToValue( e.X );
            p.Y = (float) chtMap.ChartAreas[ 0 ].AxisY.PixelPositionToValue( e.Y );
            DataPoint dp = new DataPoint( p.X, p.Y );
            dp.Label = hitCount.ToString( );
            dp.Tag = p;
            if( hitCount == 0 )
            {
                // create a series, add two points;
                s = new Series( $"Sample{++id}" );
                s.ChartType = SeriesChartType.Line;
                chtMap.Series.Add( s );
                s.Points.Add( dp );
                DataPoint dpp = dp.Clone();
                dpp.Label = "";
                s.Points.Add( dpp );
            }
            else
            {
                s.Points.Insert( hitCount, dp );
            }
            hitCount++;
            if( hitCount == numberOfPoints )
            {
                // Complete a sample
                DataRow dr = dttPoints.NewRow( );
                for( int i = 0 ; i < numberOfPoints ; i++ )
                    dr[ i ] = s.Points[ i ].Tag;
                dttPoints.Rows.Add( dr );
                // 
                GenerateDistanceRow( id );
                hitCount = 0;
            }

        }
        PointF[ ] pts;

        private void GenerateDistanceRow( int r )
        {
            if( pts == null || pts.Length != numberOfPoints )
                pts = new PointF[ numberOfPoints ];
            for( int i = 0 ; i < numberOfPoints ; i++ )
            {
                pts[i] = (PointF) dttPoints.Rows[ r ][ i ];
            }

            int c = 0;
            float x1, y1, x2, y2;
            DataRow dr =   dttDistances.NewRow( );
            for( int i = 0 ; i < numberOfPoints ; i++ )
            {
                x1 = pts[i].X; y1 = pts[ i ].Y;
                for( int j = i + 1 ; j < numberOfPoints ;j++ )
                {
                    x2 = pts[ j ].X; y2 = pts[ j ].Y;
                    dr[ c++ ] = Math.Sqrt( ( x2 - x1 ) * ( x2 - x1 ) + ( y2 - y1 ) * ( y2 - y1 ) );
                }
            }
            dttDistances.Rows.Add( dr );
        }

        private void btnSaveCSV_Click( object sender, EventArgs e )
        {
            SaveFileDialog dlg = new SaveFileDialog( );
            dlg.DefaultExt = "csv";
            dlg.FileName = "";
            if( dlg.ShowDialog( ) != DialogResult.OK ) return;
            WriteTableToCSVFile( dttDistances, dlg.FileName );
        }

        private void btnConfirm_Click( object sender, EventArgs e )
        {
            int num = int.Parse( txbNum.Text );
            if( numberOfPoints == num ) return;
            numberOfPoints = num;
            if( dttPoints == null ) dttPoints = new DataTable( );
            dttPoints.Rows.Clear( );
            dttPoints.Columns.Clear( );
            for( int i = 0 ; i < numberOfPoints ; i++ )
            {
                DataColumn dc = new DataColumn( $"P{i}", typeof( PointF ) );
                dttPoints.Columns.Add( dc );
            }
            dgvPoints.DataSource = dttPoints;

            if( dttDistances == null ) dttDistances = new DataTable( );
            dttDistances.Rows.Clear( );
            dttDistances.Columns.Clear( );

            for( int i = 0 ; i < numberOfPoints ; i++ )
            {
                for( int j = i+1 ; j < numberOfPoints ; j++ )
                {
                    DataColumn dc = new DataColumn( $"D{i}-{j}", typeof( double ) );
                    dttDistances.Columns.Add( dc );
                }
            }
            dgvDistances.DataSource = dttDistances;
            chtMap.Series.Clear( );
        }

        void WriteTableToCSVFile( DataTable dtt, string path )
        {
             StreamWriter sw = new StreamWriter( path);
            StringBuilder sb = new StringBuilder( );
            for( int c = 0 ; c < dtt.Columns.Count ; c++ )
                if( c == dtt.Columns.Count - 1 )
                    sb.AppendLine( dtt.Columns[ c ].ColumnName );
                else
                    sb.Append( $"{dtt.Columns[ c ].ColumnName}," );
            for( int r = 0 ; r < dtt.Rows.Count ; r++ )
            {
                for( int c = 0 ; c < dtt.Columns.Count ; c++ )
                    if( c == dtt.Columns.Count - 1 )
                        sb.AppendLine( dtt.Rows[r][ c ].ToString() );
                    else
                        sb.Append( $"{dtt.Rows[ r ][ c ]}," );
            }
            sw.Write( sb.ToString( ) );
            sw.Close( );
        }
    }
}
