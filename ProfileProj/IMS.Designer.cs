using MindFusion.Charting;

namespace ProfileProj
{
    partial class IMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView5 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView6 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            this.dateFromlbl = new System.Windows.Forms.Label();
            this.dateTolbl = new System.Windows.Forms.Label();
            this.port1Lbl = new System.Windows.Forms.Label();
            this.port2Lbl = new System.Windows.Forms.Label();
            this.dateFromPick = new System.Windows.Forms.DateTimePicker();
            this.dateToPick = new System.Windows.Forms.DateTimePicker();
            this.port1Comb = new System.Windows.Forms.ComboBox();
            this.port1GBox = new System.Windows.Forms.GroupBox();
            this.port1CurData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.port1StatBallbl = new System.Windows.Forms.Label();
            this.port1ReturnData = new System.Windows.Forms.Label();
            this.port1PLData = new System.Windows.Forms.Label();
            this.port1EndBalData = new System.Windows.Forms.Label();
            this.port1InOutFlowsData = new System.Windows.Forms.Label();
            this.port1StartBalData = new System.Windows.Forms.Label();
            this.port1InOutFlowlbl = new System.Windows.Forms.Label();
            this.port1EndBallbl = new System.Windows.Forms.Label();
            this.port1PLlbl = new System.Windows.Forms.Label();
            this.port1Returnlbl = new System.Windows.Forms.Label();
            this.port2GBox = new System.Windows.Forms.GroupBox();
            this.port2CurData = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.port2ReturnData = new System.Windows.Forms.Label();
            this.port2PLData = new System.Windows.Forms.Label();
            this.port2EndBalData = new System.Windows.Forms.Label();
            this.port2InOutFlowsData = new System.Windows.Forms.Label();
            this.port2StartBalData = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.port2Comb = new System.Windows.Forms.ComboBox();
            this.executeBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.portChart = new DevExpress.XtraCharts.ChartControl();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBtn1 = new System.Windows.Forms.RadioButton();
            this.radioBtn2 = new System.Windows.Forms.RadioButton();
            this.curComb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.port1GBox.SuspendLayout();
            this.port2GBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFromlbl
            // 
            this.dateFromlbl.AutoSize = true;
            this.dateFromlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateFromlbl.Location = new System.Drawing.Point(12, 10);
            this.dateFromlbl.Name = "dateFromlbl";
            this.dateFromlbl.Size = new System.Drawing.Size(89, 20);
            this.dateFromlbl.TabIndex = 0;
            this.dateFromlbl.Text = "Date From:";
            // 
            // dateTolbl
            // 
            this.dateTolbl.AutoSize = true;
            this.dateTolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTolbl.Location = new System.Drawing.Point(426, 10);
            this.dateTolbl.Name = "dateTolbl";
            this.dateTolbl.Size = new System.Drawing.Size(70, 20);
            this.dateTolbl.TabIndex = 1;
            this.dateTolbl.Text = "Date To:";
            // 
            // port1Lbl
            // 
            this.port1Lbl.AutoSize = true;
            this.port1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port1Lbl.Location = new System.Drawing.Point(12, 116);
            this.port1Lbl.Name = "port1Lbl";
            this.port1Lbl.Size = new System.Drawing.Size(84, 20);
            this.port1Lbl.TabIndex = 2;
            this.port1Lbl.Text = "Portfolio 1:";
            // 
            // port2Lbl
            // 
            this.port2Lbl.AutoSize = true;
            this.port2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port2Lbl.Location = new System.Drawing.Point(426, 116);
            this.port2Lbl.Name = "port2Lbl";
            this.port2Lbl.Size = new System.Drawing.Size(84, 20);
            this.port2Lbl.TabIndex = 3;
            this.port2Lbl.Text = "Portfolio 2:";
            // 
            // dateFromPick
            // 
            this.dateFromPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateFromPick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromPick.Location = new System.Drawing.Point(107, 5);
            this.dateFromPick.Name = "dateFromPick";
            this.dateFromPick.Size = new System.Drawing.Size(271, 26);
            this.dateFromPick.TabIndex = 4;
            this.dateFromPick.ValueChanged += new System.EventHandler(this.dateFromPick_ValueChanged);
            // 
            // dateToPick
            // 
            this.dateToPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateToPick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToPick.Location = new System.Drawing.Point(502, 4);
            this.dateToPick.Name = "dateToPick";
            this.dateToPick.Size = new System.Drawing.Size(276, 26);
            this.dateToPick.TabIndex = 5;
            // 
            // port1Comb
            // 
            this.port1Comb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port1Comb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port1Comb.FormattingEnabled = true;
            this.port1Comb.Location = new System.Drawing.Point(116, 113);
            this.port1Comb.Name = "port1Comb";
            this.port1Comb.Size = new System.Drawing.Size(226, 28);
            this.port1Comb.TabIndex = 6;
            // 
            // port1GBox
            // 
            this.port1GBox.Controls.Add(this.port1CurData);
            this.port1GBox.Controls.Add(this.label3);
            this.port1GBox.Controls.Add(this.port1StatBallbl);
            this.port1GBox.Controls.Add(this.port1ReturnData);
            this.port1GBox.Controls.Add(this.port1PLData);
            this.port1GBox.Controls.Add(this.port1EndBalData);
            this.port1GBox.Controls.Add(this.port1InOutFlowsData);
            this.port1GBox.Controls.Add(this.port1StartBalData);
            this.port1GBox.Controls.Add(this.port1InOutFlowlbl);
            this.port1GBox.Controls.Add(this.port1EndBallbl);
            this.port1GBox.Controls.Add(this.port1PLlbl);
            this.port1GBox.Controls.Add(this.port1Returnlbl);
            this.port1GBox.Location = new System.Drawing.Point(9, 164);
            this.port1GBox.Name = "port1GBox";
            this.port1GBox.Size = new System.Drawing.Size(405, 212);
            this.port1GBox.TabIndex = 11;
            this.port1GBox.TabStop = false;
            // 
            // port1CurData
            // 
            this.port1CurData.AutoSize = true;
            this.port1CurData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port1CurData.Location = new System.Drawing.Point(136, 24);
            this.port1CurData.Name = "port1CurData";
            this.port1CurData.Size = new System.Drawing.Size(0, 20);
            this.port1CurData.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(10, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Currency :";
            // 
            // port1StatBallbl
            // 
            this.port1StatBallbl.AutoSize = true;
            this.port1StatBallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port1StatBallbl.Location = new System.Drawing.Point(10, 53);
            this.port1StatBallbl.Name = "port1StatBallbl";
            this.port1StatBallbl.Size = new System.Drawing.Size(114, 20);
            this.port1StatBallbl.TabIndex = 10;
            this.port1StatBallbl.Text = "Start Balance :";
            // 
            // port1ReturnData
            // 
            this.port1ReturnData.AutoSize = true;
            this.port1ReturnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port1ReturnData.Location = new System.Drawing.Point(136, 178);
            this.port1ReturnData.Name = "port1ReturnData";
            this.port1ReturnData.Size = new System.Drawing.Size(0, 20);
            this.port1ReturnData.TabIndex = 12;
            // 
            // port1PLData
            // 
            this.port1PLData.AutoSize = true;
            this.port1PLData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port1PLData.Location = new System.Drawing.Point(136, 148);
            this.port1PLData.Name = "port1PLData";
            this.port1PLData.Size = new System.Drawing.Size(0, 20);
            this.port1PLData.TabIndex = 13;
            // 
            // port1EndBalData
            // 
            this.port1EndBalData.AutoSize = true;
            this.port1EndBalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port1EndBalData.Location = new System.Drawing.Point(136, 120);
            this.port1EndBalData.Name = "port1EndBalData";
            this.port1EndBalData.Size = new System.Drawing.Size(0, 20);
            this.port1EndBalData.TabIndex = 14;
            // 
            // port1InOutFlowsData
            // 
            this.port1InOutFlowsData.AutoSize = true;
            this.port1InOutFlowsData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port1InOutFlowsData.Location = new System.Drawing.Point(136, 83);
            this.port1InOutFlowsData.Name = "port1InOutFlowsData";
            this.port1InOutFlowsData.Size = new System.Drawing.Size(0, 20);
            this.port1InOutFlowsData.TabIndex = 15;
            // 
            // port1StartBalData
            // 
            this.port1StartBalData.AutoSize = true;
            this.port1StartBalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port1StartBalData.Location = new System.Drawing.Point(136, 53);
            this.port1StartBalData.Name = "port1StartBalData";
            this.port1StartBalData.Size = new System.Drawing.Size(0, 20);
            this.port1StartBalData.TabIndex = 16;
            // 
            // port1InOutFlowlbl
            // 
            this.port1InOutFlowlbl.AutoSize = true;
            this.port1InOutFlowlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port1InOutFlowlbl.Location = new System.Drawing.Point(10, 83);
            this.port1InOutFlowlbl.Name = "port1InOutFlowlbl";
            this.port1InOutFlowlbl.Size = new System.Drawing.Size(106, 20);
            this.port1InOutFlowlbl.TabIndex = 9;
            this.port1InOutFlowlbl.Text = "In/Out Flows :";
            // 
            // port1EndBallbl
            // 
            this.port1EndBallbl.AutoSize = true;
            this.port1EndBallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port1EndBallbl.Location = new System.Drawing.Point(10, 120);
            this.port1EndBallbl.Name = "port1EndBallbl";
            this.port1EndBallbl.Size = new System.Drawing.Size(108, 20);
            this.port1EndBallbl.TabIndex = 8;
            this.port1EndBallbl.Text = "End Balance :";
            // 
            // port1PLlbl
            // 
            this.port1PLlbl.AutoSize = true;
            this.port1PLlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port1PLlbl.Location = new System.Drawing.Point(10, 148);
            this.port1PLlbl.Name = "port1PLlbl";
            this.port1PLlbl.Size = new System.Drawing.Size(40, 20);
            this.port1PLlbl.TabIndex = 7;
            this.port1PLlbl.Text = "P/L :";
            // 
            // port1Returnlbl
            // 
            this.port1Returnlbl.AutoSize = true;
            this.port1Returnlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port1Returnlbl.Location = new System.Drawing.Point(10, 178);
            this.port1Returnlbl.Name = "port1Returnlbl";
            this.port1Returnlbl.Size = new System.Drawing.Size(98, 20);
            this.port1Returnlbl.TabIndex = 6;
            this.port1Returnlbl.Text = "Return (%) : ";
            // 
            // port2GBox
            // 
            this.port2GBox.Controls.Add(this.port2CurData);
            this.port2GBox.Controls.Add(this.label4);
            this.port2GBox.Controls.Add(this.label1);
            this.port2GBox.Controls.Add(this.port2ReturnData);
            this.port2GBox.Controls.Add(this.port2PLData);
            this.port2GBox.Controls.Add(this.port2EndBalData);
            this.port2GBox.Controls.Add(this.port2InOutFlowsData);
            this.port2GBox.Controls.Add(this.port2StartBalData);
            this.port2GBox.Controls.Add(this.label7);
            this.port2GBox.Controls.Add(this.label8);
            this.port2GBox.Controls.Add(this.label9);
            this.port2GBox.Controls.Add(this.label10);
            this.port2GBox.Location = new System.Drawing.Point(430, 164);
            this.port2GBox.Name = "port2GBox";
            this.port2GBox.Size = new System.Drawing.Size(420, 212);
            this.port2GBox.TabIndex = 12;
            this.port2GBox.TabStop = false;
            // 
            // port2CurData
            // 
            this.port2CurData.AutoSize = true;
            this.port2CurData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port2CurData.Location = new System.Drawing.Point(130, 24);
            this.port2CurData.Name = "port2CurData";
            this.port2CurData.Size = new System.Drawing.Size(0, 20);
            this.port2CurData.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Currency :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Start Balance :";
            // 
            // port2ReturnData
            // 
            this.port2ReturnData.AutoSize = true;
            this.port2ReturnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port2ReturnData.Location = new System.Drawing.Point(130, 178);
            this.port2ReturnData.Name = "port2ReturnData";
            this.port2ReturnData.Size = new System.Drawing.Size(0, 20);
            this.port2ReturnData.TabIndex = 12;
            // 
            // port2PLData
            // 
            this.port2PLData.AutoSize = true;
            this.port2PLData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port2PLData.Location = new System.Drawing.Point(130, 148);
            this.port2PLData.Name = "port2PLData";
            this.port2PLData.Size = new System.Drawing.Size(0, 20);
            this.port2PLData.TabIndex = 13;
            // 
            // port2EndBalData
            // 
            this.port2EndBalData.AutoSize = true;
            this.port2EndBalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port2EndBalData.Location = new System.Drawing.Point(130, 120);
            this.port2EndBalData.Name = "port2EndBalData";
            this.port2EndBalData.Size = new System.Drawing.Size(0, 20);
            this.port2EndBalData.TabIndex = 14;
            // 
            // port2InOutFlowsData
            // 
            this.port2InOutFlowsData.AutoSize = true;
            this.port2InOutFlowsData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port2InOutFlowsData.Location = new System.Drawing.Point(130, 83);
            this.port2InOutFlowsData.Name = "port2InOutFlowsData";
            this.port2InOutFlowsData.Size = new System.Drawing.Size(0, 20);
            this.port2InOutFlowsData.TabIndex = 15;
            // 
            // port2StartBalData
            // 
            this.port2StartBalData.AutoSize = true;
            this.port2StartBalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port2StartBalData.Location = new System.Drawing.Point(130, 53);
            this.port2StartBalData.Name = "port2StartBalData";
            this.port2StartBalData.Size = new System.Drawing.Size(0, 20);
            this.port2StartBalData.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "In/Out Flows :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(6, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "End Balance :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(6, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "P/L :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(6, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Return (%) : ";
            // 
            // port2Comb
            // 
            this.port2Comb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port2Comb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.port2Comb.FormattingEnabled = true;
            this.port2Comb.Location = new System.Drawing.Point(526, 113);
            this.port2Comb.Name = "port2Comb";
            this.port2Comb.Size = new System.Drawing.Size(226, 28);
            this.port2Comb.TabIndex = 15;
            // 
            // executeBtn
            // 
            this.executeBtn.Location = new System.Drawing.Point(856, 101);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(99, 35);
            this.executeBtn.TabIndex = 16;
            this.executeBtn.Text = "Execute";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(856, 173);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(99, 35);
            this.ClearBtn.TabIndex = 17;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // portChart
            // 
            this.portChart.AppearanceNameSerializable = "Light";
            this.portChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(195)))));
            this.portChart.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.portChart.DataBindings = null;
            this.portChart.Legend.ItemVisibilityMode = DevExpress.XtraCharts.LegendItemVisibilityMode.AutoGeneratedAndCustom;
            this.portChart.Legend.Name = "Default Legend";
            this.portChart.Legend.Title.Text = "";
            this.portChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.portChart.Location = new System.Drawing.Point(16, 391);
            this.portChart.Name = "portChart";
            pointSeriesLabel3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            series5.Label = pointSeriesLabel3;
            series5.Name = "Portfolio 1";
            lineSeriesView5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            series5.View = lineSeriesView5;
            series5.Visible = false;
            series6.Name = "Portfolio 2";
            lineSeriesView6.Color = System.Drawing.Color.LimeGreen;
            series6.View = lineSeriesView6;
            series6.Visible = false;
            this.portChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5,
        series6};
            this.portChart.Size = new System.Drawing.Size(854, 288);
            this.portChart.TabIndex = 18;
            chartTitle3.Text = "Portfolios";
            this.portChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ref Currency :";
            // 
            // radioBtn1
            // 
            this.radioBtn1.AutoSize = true;
            this.radioBtn1.Checked = true;
            this.radioBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioBtn1.Location = new System.Drawing.Point(131, 62);
            this.radioBtn1.Name = "radioBtn1";
            this.radioBtn1.Size = new System.Drawing.Size(152, 24);
            this.radioBtn1.TabIndex = 20;
            this.radioBtn1.TabStop = true;
            this.radioBtn1.Text = "Portfolio Currency";
            this.radioBtn1.UseVisualStyleBackColor = true;
            // 
            // radioBtn2
            // 
            this.radioBtn2.AutoSize = true;
            this.radioBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioBtn2.Location = new System.Drawing.Point(324, 62);
            this.radioBtn2.Name = "radioBtn2";
            this.radioBtn2.Size = new System.Drawing.Size(67, 24);
            this.radioBtn2.TabIndex = 21;
            this.radioBtn2.Text = "Other";
            this.radioBtn2.UseVisualStyleBackColor = true;
            // 
            // curComb
            // 
            this.curComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.curComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.curComb.FormattingEnabled = true;
            this.curComb.Location = new System.Drawing.Point(430, 64);
            this.curComb.Name = "curComb";
            this.curComb.Size = new System.Drawing.Size(237, 28);
            this.curComb.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(376, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Please wait";
            this.label5.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(971, 750);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.curComb);
            this.Controls.Add(this.radioBtn2);
            this.Controls.Add(this.radioBtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portChart);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.port2Comb);
            this.Controls.Add(this.port2GBox);
            this.Controls.Add(this.port1Comb);
            this.Controls.Add(this.dateToPick);
            this.Controls.Add(this.dateFromPick);
            this.Controls.Add(this.port2Lbl);
            this.Controls.Add(this.port1Lbl);
            this.Controls.Add(this.dateTolbl);
            this.Controls.Add(this.dateFromlbl);
            this.Controls.Add(this.port1GBox);
            this.Name = "IMS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.IMS_Load);
            this.port1GBox.ResumeLayout(false);
            this.port1GBox.PerformLayout();
            this.port2GBox.ResumeLayout(false);
            this.port2GBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateFromlbl;
        private System.Windows.Forms.Label dateTolbl;
        private System.Windows.Forms.Label port1Lbl;
        private System.Windows.Forms.Label port2Lbl;
        private System.Windows.Forms.DateTimePicker dateFromPick;
        private System.Windows.Forms.DateTimePicker dateToPick;
        private System.Windows.Forms.ComboBox port1Comb;
        private System.Windows.Forms.GroupBox port1GBox;
        private System.Windows.Forms.Label port1StatBallbl;
        private System.Windows.Forms.Label port1ReturnData;
        private System.Windows.Forms.Label port1PLData;
        private System.Windows.Forms.Label port1EndBalData;
        private System.Windows.Forms.Label port1InOutFlowsData;
        private System.Windows.Forms.Label port1StartBalData;
        private System.Windows.Forms.Label port1InOutFlowlbl;
        private System.Windows.Forms.Label port1EndBallbl;
        private System.Windows.Forms.Label port1PLlbl;
        private System.Windows.Forms.Label port1Returnlbl;
        private System.Windows.Forms.GroupBox port2GBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label port2ReturnData;
        private System.Windows.Forms.Label port2PLData;
        private System.Windows.Forms.Label port2EndBalData;
        private System.Windows.Forms.Label port2InOutFlowsData;
        private System.Windows.Forms.Label port2StartBalData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox port2Comb;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.Button ClearBtn;
        private DevExpress.XtraCharts.ChartControl portChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtn1;
        private System.Windows.Forms.RadioButton radioBtn2;
        private System.Windows.Forms.ComboBox curComb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label port1CurData;
        private System.Windows.Forms.Label port2CurData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}

