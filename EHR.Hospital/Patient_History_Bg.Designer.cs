﻿namespace EHR_Hospital
{
    partial class Patient_History_Bg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Label_Name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.PatientID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Request = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Back = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Request)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(61, 114);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(594, 266);
            this.kryptonDataGridView1.TabIndex = 0;
            this.kryptonDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_CellClick);
            this.kryptonDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_CellContentClick);
            // 
            // Label_Name
            // 
            this.Label_Name.Location = new System.Drawing.Point(74, 43);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(87, 23);
            this.Label_Name.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Label_Name.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Label_Name.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Label_Name.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.Label_Name.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.Label_Name.StateNormal.ShortText.Color2 = System.Drawing.Color.White;
            this.Label_Name.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.StateNormal.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Label_Name.StateNormal.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.Label_Name.TabIndex = 22;
            this.Label_Name.Values.Text = "Patient ID";
            // 
            // PatientID
            // 
            this.PatientID.Location = new System.Drawing.Point(74, 69);
            this.PatientID.Name = "PatientID";
            this.PatientID.Size = new System.Drawing.Size(186, 22);
            this.PatientID.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.PatientID.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.PatientID.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.PatientID.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.PatientID.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.PatientID.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.PatientID.TabIndex = 21;
            this.PatientID.TextChanged += new System.EventHandler(this.PatientID_TextChanged);
            this.PatientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientID_KeyPress);
            // 
            // Request
            // 
            this.Request.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Request.DropDownWidth = 153;
            this.Request.Items.AddRange(new object[] {
            "Chronic Disease",
            "Diagnosis",
            "Prescriptions",
            "Surgeries",
            "Lab Results",
            "Family Members"});
            this.Request.Location = new System.Drawing.Point(293, 69);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(153, 21);
            this.Request.TabIndex = 23;
            this.Request.SelectedIndexChanged += new System.EventHandler(this.Request_SelectedIndexChanged);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(514, 53);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(148, 38);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StateCommon.Border.Rounding = 25;
            this.kryptonButton1.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButton1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateDisabled.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StateDisabled.Border.Rounding = 25;
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StateNormal.Border.Rounding = 25;
            this.kryptonButton1.StateNormal.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StateNormal.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButton1.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateNormal.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StateNormal.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StatePressed.Border.Rounding = 25;
            this.kryptonButton1.StatePressed.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StatePressed.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButton1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StatePressed.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StatePressed.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonButton1.StateTracking.Border.Rounding = 25;
            this.kryptonButton1.TabIndex = 24;
            this.kryptonButton1.Values.Text = "SEARCH";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // Back
            // 
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(38, 38);
            this.Back.StateCommon.Back.Image = global::EHR_Hospital.Properties.Resources.Back;
            this.Back.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Back.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.Back.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.Back.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Back.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.Back.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Back.StateDisabled.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.Back.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Back.StateNormal.Border.Rounding = 25;
            this.Back.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StatePressed.Back.Image = global::EHR_Hospital.Properties.Resources.Back;
            this.Back.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Back.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Back.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Back.StatePressed.Border.Rounding = 25;
            this.Back.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Back.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Back.StateTracking.Border.Rounding = 25;
            this.Back.TabIndex = 25;
            this.Back.Values.Text = "";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Patient_History_Bg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EHR_Hospital.Properties.Resources.Patient_History_Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 406);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.Request);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.PatientID);
            this.Controls.Add(this.kryptonDataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient_History_Bg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient_History_Bg";
            this.Load += new System.EventHandler(this.Patient_History_Bg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Request)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Label_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox PatientID;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Request;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Back;
    }
}