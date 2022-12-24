namespace WindowsFormsApp1
{
    partial class Change_Pass
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
            this.Name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pass1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pass2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(71, 115);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(370, 22);
            this.Name.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Name.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Name.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Name.TabIndex = 1;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(71, 174);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(370, 22);
            this.pass1.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.pass1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.pass1.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.pass1.TabIndex = 2;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kryptonButton1.Location = new System.Drawing.Point(318, 262);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(43, 42);
            this.kryptonButton1.StateCommon.Back.Image = global::EHR_Lab.Properties.Resources.Cancel_Button;
            this.kryptonButton1.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateDisabled.Border.Rounding = 25;
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StateNormal.Back.Image = global::EHR_Lab.Properties.Resources.Cancel_Button;
            this.kryptonButton1.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.kryptonButton1.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Border.Rounding = 25;
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StatePressed.Back.Image = global::EHR_Lab.Properties.Resources.Cancel_Button;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 25;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.Rounding = 25;
            this.kryptonButton1.TabIndex = 19;
            this.kryptonButton1.Values.Text = "";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // Save
            // 
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Save.Location = new System.Drawing.Point(139, 261);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(157, 42);
            this.Save.StateCommon.Back.Image = global::EHR_Lab.Properties.Resources.Save_ButtonSUBMIT;
            this.Save.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.Save.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.Save.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Save.StateDisabled.Border.Rounding = 25;
            this.Save.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Save.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Save.StateNormal.Back.Image = global::EHR_Lab.Properties.Resources.Save_ButtonSUBMIT;
            this.Save.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Save.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Save.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Save.StateNormal.Border.Rounding = 25;
            this.Save.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Save.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Save.StatePressed.Back.Image = global::EHR_Lab.Properties.Resources.Save_ButtonSUBMIT;
            this.Save.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Save.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Save.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Save.StatePressed.Border.Rounding = 25;
            this.Save.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Save.StateTracking.Border.Rounding = 25;
            this.Save.TabIndex = 18;
            this.Save.Values.Text = "";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(71, 227);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(370, 22);
            this.pass2.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.pass2.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.pass2.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.pass2.TabIndex = 20;
            // 
            // Change_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EHR_Lab.Properties.Resources.Change_Pass;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 335);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.Name);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Change_Pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change_Pass";
            this.Load += new System.EventHandler(this.Change_Pass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox pass1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Save;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox pass2;
    }
}