namespace WindowsFormsApp1
{
    partial class Apply_Organ
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
            this.kryptonCheckedListBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.Kidney = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.Liver = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.Lung = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.Pancreas = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.Intestine = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.Submit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonCheckBox6 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox2 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(38, 38);
            this.Back.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.Back;
            this.Back.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.Back.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.Back.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Back.StateDisabled.Border.Rounding = 25;
            this.Back.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.Back;
            this.Back.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.Back.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Back.StateNormal.Border.Rounding = 25;
            this.Back.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.Back;
            this.Back.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Back.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Back.StatePressed.Border.Rounding = 25;
            this.Back.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.Back;
            this.Back.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Back.StateTracking.Border.Rounding = 25;
            this.Back.TabIndex = 1;
            this.Back.Values.Text = "";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // kryptonCheckedListBox1
            // 
            this.kryptonCheckedListBox1.Location = new System.Drawing.Point(166, 141);
            this.kryptonCheckedListBox1.Name = "kryptonCheckedListBox1";
            this.kryptonCheckedListBox1.Size = new System.Drawing.Size(377, 135);
            this.kryptonCheckedListBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckedListBox1.StateCommon.Border.Width = 0;
            this.kryptonCheckedListBox1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckedListBox1.StateDisabled.Border.Width = 0;
            this.kryptonCheckedListBox1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckedListBox1.StateNormal.Border.Width = 0;
            this.kryptonCheckedListBox1.TabIndex = 2;
            this.kryptonCheckedListBox1.SelectedIndexChanged += new System.EventHandler(this.kryptonCheckedListBox1_SelectedIndexChanged);
            // 
            // Kidney
            // 
            this.Kidney.Location = new System.Drawing.Point(140, 150);
            this.Kidney.Name = "Kidney";
            this.Kidney.Size = new System.Drawing.Size(66, 20);
            this.Kidney.TabIndex = 3;
            this.Kidney.Values.Text = "LKidney";
            this.Kidney.CheckedChanged += new System.EventHandler(this.Kidney_CheckedChanged);
            // 
            // Liver
            // 
            this.Liver.Location = new System.Drawing.Point(140, 189);
            this.Liver.Name = "Liver";
            this.Liver.Size = new System.Drawing.Size(89, 20);
            this.Liver.TabIndex = 4;
            this.Liver.Values.Text = "Part of Liver";
            this.Liver.CheckedChanged += new System.EventHandler(this.Liver_CheckedChanged);
            // 
            // Lung
            // 
            this.Lung.Location = new System.Drawing.Point(371, 150);
            this.Lung.Name = "Lung";
            this.Lung.Size = new System.Drawing.Size(56, 20);
            this.Lung.TabIndex = 5;
            this.Lung.Values.Text = "LLung";
            this.Lung.CheckedChanged += new System.EventHandler(this.Lung_CheckedChanged);
            // 
            // Pancreas
            // 
            this.Pancreas.Location = new System.Drawing.Point(237, 189);
            this.Pancreas.Name = "Pancreas";
            this.Pancreas.Size = new System.Drawing.Size(111, 20);
            this.Pancreas.TabIndex = 6;
            this.Pancreas.Values.Text = "Part of Pancreas";
            this.Pancreas.CheckedChanged += new System.EventHandler(this.Pancreas_CheckedChanged);
            // 
            // Intestine
            // 
            this.Intestine.Location = new System.Drawing.Point(371, 189);
            this.Intestine.Name = "Intestine";
            this.Intestine.Size = new System.Drawing.Size(110, 20);
            this.Intestine.TabIndex = 7;
            this.Intestine.Values.Text = "Part of Intestine";
            this.Intestine.CheckedChanged += new System.EventHandler(this.Intestine_CheckedChanged);
            // 
            // Submit
            // 
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.Location = new System.Drawing.Point(270, 256);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(157, 41);
            this.Submit.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.SUBMIT;
            this.Submit.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.Submit.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.Submit.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StateDisabled.Border.Rounding = 25;
            this.Submit.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.SUBMIT;
            this.Submit.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StateNormal.Border.Rounding = 25;
            this.Submit.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.SUBMIT;
            this.Submit.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StatePressed.Border.Rounding = 25;
            this.Submit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StateTracking.Border.Rounding = 25;
            this.Submit.TabIndex = 15;
            this.Submit.Values.Image = global::WindowsFormsApp1.Properties.Resources.SUBMIT;
            this.Submit.Values.Text = "";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // kryptonCheckBox6
            // 
            this.kryptonCheckBox6.Location = new System.Drawing.Point(129, 227);
            this.kryptonCheckBox6.Name = "kryptonCheckBox6";
            this.kryptonCheckBox6.Size = new System.Drawing.Size(381, 23);
            this.kryptonCheckBox6.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonCheckBox6.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.kryptonCheckBox6.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox6.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonCheckBox6.StateNormal.ShortText.Color2 = System.Drawing.Color.Red;
            this.kryptonCheckBox6.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckBox6.TabIndex = 16;
            this.kryptonCheckBox6.UseWaitCursor = true;
            this.kryptonCheckBox6.Values.Text = "I would like to donate all vital organs when I die";
            this.kryptonCheckBox6.CheckedChanged += new System.EventHandler(this.kryptonCheckBox6_CheckedChanged);
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(237, 150);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(68, 20);
            this.kryptonCheckBox1.TabIndex = 17;
            this.kryptonCheckBox1.Values.Text = "RKidney";
            this.kryptonCheckBox1.CheckedChanged += new System.EventHandler(this.kryptonCheckBox1_CheckedChanged);
            // 
            // kryptonCheckBox2
            // 
            this.kryptonCheckBox2.Location = new System.Drawing.Point(303, 150);
            this.kryptonCheckBox2.Name = "kryptonCheckBox2";
            this.kryptonCheckBox2.Size = new System.Drawing.Size(58, 20);
            this.kryptonCheckBox2.TabIndex = 18;
            this.kryptonCheckBox2.Values.Text = "RLung";
            this.kryptonCheckBox2.CheckedChanged += new System.EventHandler(this.kryptonCheckBox2_CheckedChanged);
            // 
            // Apply_Organ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Organ_Dono;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 405);
            this.Controls.Add(this.kryptonCheckBox2);
            this.Controls.Add(this.kryptonCheckBox1);
            this.Controls.Add(this.kryptonCheckBox6);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Intestine);
            this.Controls.Add(this.Pancreas);
            this.Controls.Add(this.Lung);
            this.Controls.Add(this.Liver);
            this.Controls.Add(this.Kidney);
            this.Controls.Add(this.kryptonCheckedListBox1);
            this.Controls.Add(this.Back);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Apply_Organ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oragn_Dono";
            this.Load += new System.EventHandler(this.Oragn_Dono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton Back;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox kryptonCheckedListBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox Kidney;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox Liver;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox Lung;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox Pancreas;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox Intestine;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Submit;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox6;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox2;
    }
}