namespace EHR_Hospital
{
    partial class Death_Report
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
            this.Back = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Label_Name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.PatientID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Location = new System.Drawing.Point(16, 15);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(51, 47);
            this.Back.StateCommon.Back.Image = global::EHR_Hospital.Properties.Resources.Back;
            this.Back.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.Back.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.Back.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Back.StateDisabled.Border.Rounding = 25;
            this.Back.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StateNormal.Back.Image = global::EHR_Hospital.Properties.Resources.Back;
            this.Back.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.Back.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Back.StateNormal.Border.Rounding = 25;
            this.Back.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StatePressed.Back.Image = global::EHR_Hospital.Properties.Resources.Back;
            this.Back.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Back.StatePressed.Border.Rounding = 25;
            this.Back.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Back.StateTracking.Border.Rounding = 25;
            this.Back.TabIndex = 37;
            this.Back.Values.Text = "";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(412, 133);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(174, 24);
            this.kryptonLabel2.TabIndex = 41;
            this.kryptonLabel2.Values.Text = "Date and Time of Death";
            // 
            // Label_Name
            // 
            this.Label_Name.Location = new System.Drawing.Point(80, 133);
            this.Label_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(78, 24);
            this.Label_Name.TabIndex = 39;
            this.Label_Name.Values.Text = "Patient ID";
            // 
            // PatientID
            // 
            this.PatientID.Location = new System.Drawing.Point(87, 165);
            this.PatientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatientID.Name = "PatientID";
            this.PatientID.Size = new System.Drawing.Size(248, 26);
            this.PatientID.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.PatientID.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.PatientID.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.PatientID.TabIndex = 38;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(80, 240);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(110, 24);
            this.kryptonLabel1.TabIndex = 43;
            this.kryptonLabel1.Values.Text = "Place of Death";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(88, 272);
            this.kryptonTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(248, 26);
            this.kryptonTextBox1.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox1.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox1.TabIndex = 42;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(412, 240);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(115, 24);
            this.kryptonLabel3.TabIndex = 45;
            this.kryptonLabel3.Values.Text = "Cause of Death";
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(419, 272);
            this.kryptonTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(443, 26);
            this.kryptonTextBox2.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox2.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox2.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox2.TabIndex = 44;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(364, 379);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(236, 55);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 25;
            this.kryptonButton1.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateDisabled.Border.Rounding = 25;
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Border.Rounding = 25;
            this.kryptonButton1.StateNormal.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 25;
            this.kryptonButton1.StatePressed.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.Rounding = 25;
            this.kryptonButton1.TabIndex = 46;
            this.kryptonButton1.Values.Text = "SUBMIT";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(412, 166);
            this.kryptonDateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(188, 25);
            this.kryptonDateTimePicker1.TabIndex = 47;
            // 
            // Death_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EHR_Hospital.Properties.Resources.Death_Report;
            this.ClientSize = new System.Drawing.Size(959, 498);
            this.Controls.Add(this.kryptonDateTimePicker1);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonTextBox2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.PatientID);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Death_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton Back;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Label_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox PatientID;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
    }
}