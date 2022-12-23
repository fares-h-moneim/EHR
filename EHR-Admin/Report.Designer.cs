namespace EHR_Admin
{
    partial class Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Test1 = new EHR_Admin.Test();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataSet1 = new EHR_Admin.DataSet1();
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosisTableAdapter = new EHR_Admin.DataSet1TableAdapters.DiagnosisTableAdapter();
            this.btnLoad = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.DataSource = this.diagnosisBindingSource;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(177, 297);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Count";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(659, 352);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            title1.Name = "Diagnosis";
            title1.Text = "Diagnosis";
            this.chart.Titles.Add(title1);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnosisBindingSource
            // 
            this.diagnosisBindingSource.DataMember = "Diagnosis";
            this.diagnosisBindingSource.DataSource = this.dataSet1;
            // 
            // diagnosisTableAdapter
            // 
            this.diagnosisTableAdapter.ClearBeforeFill = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(411, 670);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(171, 25);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Values.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 217;
            this.kryptonComboBox1.Location = new System.Drawing.Point(392, 113);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(217, 21);
            this.kryptonComboBox1.TabIndex = 2;
            this.kryptonComboBox1.Text = "kryptonComboBox1";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.kryptonComboBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.chart);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Test Test1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
        private DataSet1TableAdapters.DiagnosisTableAdapter diagnosisTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLoad;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
    }
}