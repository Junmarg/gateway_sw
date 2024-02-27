namespace FireMon_Test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.MachineData_listView = new System.Windows.Forms.ListView();
            this.TemData_listView = new System.Windows.Forms.ListView();
            this.GasData_listView = new System.Windows.Forms.ListView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(416, 26);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(113, 51);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            //this.btn_Connect.Per
            //Click();
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(25, 26);
            this.txt_ip.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(379, 21);
            this.txt_ip.TabIndex = 1;
            this.txt_ip.Text = "192.168.0.201";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(25, 58);
            this.txt_port.Margin = new System.Windows.Forms.Padding(2);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(379, 21);
            this.txt_port.TabIndex = 2;
            this.txt_port.Text = "502";
            // 
            // MachineData_listView
            // 
            this.MachineData_listView.HideSelection = false;
            this.MachineData_listView.Location = new System.Drawing.Point(22, 99);
            this.MachineData_listView.Name = "MachineData_listView";
            this.MachineData_listView.Size = new System.Drawing.Size(350, 470);
            this.MachineData_listView.TabIndex = 3;
            this.MachineData_listView.UseCompatibleStateImageBehavior = false;
            this.MachineData_listView.View = System.Windows.Forms.View.Details;
            // 
            // TemData_listView
            // 
            this.TemData_listView.HideSelection = false;
            this.TemData_listView.Location = new System.Drawing.Point(772, 98);
            this.TemData_listView.Name = "TemData_listView";
            this.TemData_listView.Size = new System.Drawing.Size(350, 470);
            this.TemData_listView.TabIndex = 4;
            this.TemData_listView.UseCompatibleStateImageBehavior = false;
            this.TemData_listView.View = System.Windows.Forms.View.Details;
            // 
            // GasData_listView
            // 
            this.GasData_listView.HideSelection = false;
            this.GasData_listView.Location = new System.Drawing.Point(396, 99);
            this.GasData_listView.Name = "GasData_listView";
            this.GasData_listView.Size = new System.Drawing.Size(350, 470);
            this.GasData_listView.TabIndex = 5;
            this.GasData_listView.UseCompatibleStateImageBehavior = false;
            this.GasData_listView.View = System.Windows.Forms.View.Details;
            // 
            // chart1
            // 
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisX.ScaleView.Zoomable = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(22, 608);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.LabelAngle = 1;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(528, 300);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "가스 농도";
            this.chart1.Titles.Add(title1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(877, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 60);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // chart2
            // 
            chartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea2.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(586, 608);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(528, 300);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "온도";
            this.chart2.Titles.Add(title2);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 923);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.GasData_listView);
            this.Controls.Add(this.TemData_listView);
            this.Controls.Add(this.MachineData_listView);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.btn_Connect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.ListView MachineData_listView;
        private System.Windows.Forms.ListView TemData_listView;
        private System.Windows.Forms.ListView GasData_listView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FormWindowState window_state;
    }
}

