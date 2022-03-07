
namespace ThreeDTransformationOptimization
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.points3D1 = new Steema.TeeChart.Styles.Points3D();
            this.points3D2 = new Steema.TeeChart.Styles.Points3D();
            this.points3D3 = new Steema.TeeChart.Styles.Points3D();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txbPars = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labDistanceSquareSum = new System.Windows.Forms.Label();
            this.btnOptimize = new System.Windows.Forms.Button();
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.spcSecond = new System.Windows.Forms.SplitContainer();
            this.rtbScreen = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chartController1 = new Steema.TeeChart.ChartController();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcSecond)).BeginInit();
            this.spcSecond.Panel1.SuspendLayout();
            this.spcSecond.SuspendLayout();
            this.SuspendLayout();
            // 
            // tChart1
            // 
            this.tChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tChart1.Aspect.Chart3DPercent = 100;
            this.tChart1.Aspect.Elevation = 339;
            this.tChart1.Aspect.ElevationFloat = 339D;
            this.tChart1.Aspect.Orthogonal = false;
            this.tChart1.Aspect.Perspective = 82;
            this.tChart1.Aspect.Rotation = 312;
            this.tChart1.Aspect.RotationFloat = 312D;
            this.tChart1.Aspect.Zoom = 79;
            this.tChart1.Aspect.ZoomFloat = 79D;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Automatic = false;
            this.tChart1.Axes.Bottom.AutomaticMaximum = false;
            this.tChart1.Axes.Bottom.AutomaticMinimum = false;
            this.tChart1.Axes.Bottom.Maximum = 100D;
            this.tChart1.Axes.Bottom.Minimum = 0D;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Automatic = false;
            this.tChart1.Axes.Depth.AutomaticMaximum = false;
            this.tChart1.Axes.Depth.AutomaticMinimum = false;
            this.tChart1.Axes.Depth.LabelsAsSeriesTitles = true;
            this.tChart1.Axes.Depth.Maximum = 100D;
            this.tChart1.Axes.Depth.Minimum = 0D;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.LabelsAsSeriesTitles = true;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Automatic = false;
            this.tChart1.Axes.Left.AutomaticMaximum = false;
            this.tChart1.Axes.Left.AutomaticMinimum = false;
            this.tChart1.Axes.Left.Maximum = 100D;
            this.tChart1.Axes.Left.Minimum = 0D;
            // 
            // 
            // 
            this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
            this.tChart1.Location = new System.Drawing.Point(3, 37);
            this.tChart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tChart1.Name = "tChart1";
            this.tChart1.Series.Add(this.points3D1);
            this.tChart1.Series.Add(this.points3D2);
            this.tChart1.Series.Add(this.points3D3);
            this.tChart1.Size = new System.Drawing.Size(628, 465);
            this.tChart1.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Visible = false;
            // 
            // points3D1
            // 
            this.points3D1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.points3D1.ColorEach = false;
            // 
            // 
            // 
            this.points3D1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.points3D1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.points3D1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.points3D1.Pointer.HorizSize = 6;
            // 
            // 
            // 
            this.points3D1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.points3D1.Pointer.VertSize = 6;
            this.points3D1.Title = "Nominal Model";
            // 
            // 
            // 
            this.points3D1.XValues.DataMember = "X";
            // 
            // 
            // 
            this.points3D1.YValues.DataMember = "Y";
            // 
            // 
            // 
            this.points3D1.ZValues.DataMember = "Z";
            // 
            // points3D2
            // 
            this.points3D2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.points3D2.ColorEach = false;
            // 
            // 
            // 
            this.points3D2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.points3D2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.points3D2.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            this.points3D2.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.points3D2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Triangle;
            this.points3D2.Title = "Sample";
            // 
            // 
            // 
            this.points3D2.XValues.DataMember = "X";
            // 
            // 
            // 
            this.points3D2.YValues.DataMember = "Y";
            // 
            // 
            // 
            this.points3D2.ZValues.DataMember = "Z";
            // 
            // points3D3
            // 
            this.points3D3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.points3D3.ColorEach = false;
            // 
            // 
            // 
            this.points3D3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.points3D3.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.points3D3.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.points3D3.Pointer.HorizSize = 5;
            // 
            // 
            // 
            this.points3D3.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.points3D3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.points3D3.Pointer.VertSize = 5;
            this.points3D3.Title = "Optimum";
            // 
            // 
            // 
            this.points3D3.XValues.DataMember = "X";
            // 
            // 
            // 
            this.points3D3.YValues.DataMember = "Y";
            // 
            // 
            // 
            this.points3D3.ZValues.DataMember = "Z";
            // 
            // nudNumber
            // 
            this.nudNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudNumber.Location = new System.Drawing.Point(20, 545);
            this.nudNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(106, 23);
            this.nudNumber.TabIndex = 1;
            this.nudNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Of Points";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerate.Location = new System.Drawing.Point(331, 544);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(168, 42);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate Points";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txbPars
            // 
            this.txbPars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbPars.Location = new System.Drawing.Point(145, 544);
            this.txbPars.Multiline = true;
            this.txbPars.Name = "txbPars";
            this.txbPars.Size = new System.Drawing.Size(168, 115);
            this.txbPars.TabIndex = 4;
            this.txbPars.Text = "x = 10\r\ny = 5\r\nz = -4\r\nxang = 70\r\nyang = -10\r\nzang = 60";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 228);
            this.label2.TabIndex = 5;
            this.label2.Text = "(1)RotX\r\n(2)RotY\r\n(3)RotZ\r\n(4)Translate\r\n\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transform Parameters";
            // 
            // labDistanceSquareSum
            // 
            this.labDistanceSquareSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labDistanceSquareSum.AutoSize = true;
            this.labDistanceSquareSum.Location = new System.Drawing.Point(328, 596);
            this.labDistanceSquareSum.Name = "labDistanceSquareSum";
            this.labDistanceSquareSum.Size = new System.Drawing.Size(127, 16);
            this.labDistanceSquareSum.TabIndex = 7;
            this.labDistanceSquareSum.Text = "Distance Square Sum";
            // 
            // btnOptimize
            // 
            this.btnOptimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOptimize.Location = new System.Drawing.Point(331, 615);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new System.Drawing.Size(168, 42);
            this.btnOptimize.TabIndex = 8;
            this.btnOptimize.Text = "Create GA Solver";
            this.btnOptimize.UseVisualStyleBackColor = true;
            this.btnOptimize.Click += new System.EventHandler(this.btnOptimize_Click);
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.chartController1);
            this.spcMain.Panel1.Controls.Add(this.label4);
            this.spcMain.Panel1.Controls.Add(this.btnOptimize);
            this.spcMain.Panel1.Controls.Add(this.tChart1);
            this.spcMain.Panel1.Controls.Add(this.labDistanceSquareSum);
            this.spcMain.Panel1.Controls.Add(this.label1);
            this.spcMain.Panel1.Controls.Add(this.label3);
            this.spcMain.Panel1.Controls.Add(this.btnGenerate);
            this.spcMain.Panel1.Controls.Add(this.nudNumber);
            this.spcMain.Panel1.Controls.Add(this.txbPars);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.spcSecond);
            this.spcMain.Size = new System.Drawing.Size(1056, 669);
            this.spcMain.SplitterDistance = 634;
            this.spcMain.TabIndex = 9;
            // 
            // spcSecond
            // 
            this.spcSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcSecond.Location = new System.Drawing.Point(0, 0);
            this.spcSecond.Name = "spcSecond";
            this.spcSecond.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcSecond.Panel1
            // 
            this.spcSecond.Panel1.Controls.Add(this.rtbScreen);
            this.spcSecond.Panel1.Controls.Add(this.label2);
            this.spcSecond.Size = new System.Drawing.Size(418, 669);
            this.spcSecond.SplitterDistance = 228;
            this.spcSecond.TabIndex = 0;
            // 
            // rtbScreen
            // 
            this.rtbScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbScreen.Location = new System.Drawing.Point(81, 0);
            this.rtbScreen.Name = "rtbScreen";
            this.rtbScreen.Size = new System.Drawing.Size(337, 228);
            this.rtbScreen.TabIndex = 0;
            this.rtbScreen.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(17, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 87);
            this.label4.TabIndex = 9;
            this.label4.Text = "(1)R_Translate\r\n(2)R_RotZ, \r\n(3)R_RotY, \r\n(4)R_RotX";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chartController1
            // 
            this.chartController1.ButtonSize = Steema.TeeChart.ControllerButtonSize.x16;
            this.chartController1.Chart = this.tChart1;
            this.chartController1.LabelValues = true;
            this.chartController1.Location = new System.Drawing.Point(0, 0);
            this.chartController1.Name = "chartController1";
            this.chartController1.Size = new System.Drawing.Size(634, 25);
            this.chartController1.TabIndex = 10;
            this.chartController1.Text = "chartController1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 669);
            this.Controls.Add(this.spcMain);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point Coordinate Transformation Optimizer";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel1.PerformLayout();
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.spcSecond.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcSecond)).EndInit();
            this.spcSecond.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Points3D points3D1;
        private Steema.TeeChart.Styles.Points3D points3D2;
        private Steema.TeeChart.Styles.Points3D points3D3;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txbPars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labDistanceSquareSum;
        private System.Windows.Forms.Button btnOptimize;
        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.SplitContainer spcSecond;
        private System.Windows.Forms.RichTextBox rtbScreen;
        private System.Windows.Forms.Label label4;
        private Steema.TeeChart.ChartController chartController1;
    }
}

