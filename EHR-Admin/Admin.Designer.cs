namespace EHR_Admin
{
    partial class Admin
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
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.Hello = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Hospital = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Labs = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Pharmacy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Statistics = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Avatar
            // 
            this.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Avatar.Image = global::EHR_Admin.Properties.Resources.default_avatar;
            this.Avatar.Location = new System.Drawing.Point(68, 32);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(145, 145);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // Hello
            // 
            this.Hello.Location = new System.Drawing.Point(231, 54);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(483, 95);
            this.Hello.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Hello.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Hello.StateCommon.ShortText.Font = new System.Drawing.Font("Inter ExtraBold", 52F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hello.TabIndex = 1;
            this.Hello.Values.Text = "Hello Admin!";
            // 
            // Hospital
            // 
            this.Hospital.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hospital.Location = new System.Drawing.Point(102, 216);
            this.Hospital.Name = "Hospital";
            this.Hospital.Size = new System.Drawing.Size(129, 129);
            this.Hospital.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StateCommon.Back.Image = global::EHR_Admin.Properties.Resources._33777;
            this.Hospital.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Hospital.StateCommon.Border.Width = 0;
            this.Hospital.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StateNormal.Back.Image = global::EHR_Admin.Properties.Resources._33777;
            this.Hospital.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Hospital.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Hospital.StateNormal.Border.Width = 0;
            this.Hospital.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StatePressed.Back.Image = global::EHR_Admin.Properties.Resources._33777;
            this.Hospital.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Hospital.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Hospital.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Hospital.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Hospital.StatePressed.Border.Rounding = 25;
            this.Hospital.StatePressed.Border.Width = 5;
            this.Hospital.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StateTracking.Back.Image = global::EHR_Admin.Properties.Resources._33777;
            this.Hospital.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Hospital.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Hospital.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Hospital.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Hospital.StateTracking.Border.Rounding = 25;
            this.Hospital.StateTracking.Border.Width = 5;
            this.Hospital.TabIndex = 7;
            this.Hospital.TabStop = false;
            this.Hospital.Values.Text = "";
            // 
            // Labs
            // 
            this.Labs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Labs.Location = new System.Drawing.Point(589, 214);
            this.Labs.Name = "Labs";
            this.Labs.Size = new System.Drawing.Size(115, 115);
            this.Labs.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Labs.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Labs.StateCommon.Back.Image = global::EHR_Admin.Properties.Resources.Lab;
            this.Labs.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Labs.StateCommon.Border.Width = 0;
            this.Labs.StateNormal.Back.Image = global::EHR_Admin.Properties.Resources.Lab;
            this.Labs.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Labs.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Labs.StateNormal.Border.Width = 0;
            this.Labs.StatePressed.Back.Image = global::EHR_Admin.Properties.Resources.Lab;
            this.Labs.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Labs.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Labs.StatePressed.Border.Width = 0;
            this.Labs.StateTracking.Back.Image = global::EHR_Admin.Properties.Resources.Lab;
            this.Labs.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Labs.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Labs.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Labs.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Labs.StateTracking.Border.Rounding = 25;
            this.Labs.StateTracking.Border.Width = 5;
            this.Labs.TabIndex = 8;
            this.Labs.TabStop = false;
            this.Labs.Values.Text = "";
            // 
            // Pharmacy
            // 
            this.Pharmacy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pharmacy.Location = new System.Drawing.Point(354, 216);
            this.Pharmacy.Name = "Pharmacy";
            this.Pharmacy.Size = new System.Drawing.Size(115, 115);
            this.Pharmacy.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Pharmacy.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Pharmacy.StateCommon.Back.Image = global::EHR_Admin.Properties.Resources.pharma;
            this.Pharmacy.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Pharmacy.StateCommon.Border.Width = 0;
            this.Pharmacy.StateNormal.Back.Image = global::EHR_Admin.Properties.Resources.pharma;
            this.Pharmacy.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Pharmacy.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Pharmacy.StateNormal.Border.Width = 0;
            this.Pharmacy.StatePressed.Back.Image = global::EHR_Admin.Properties.Resources.pharma;
            this.Pharmacy.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Pharmacy.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Pharmacy.StatePressed.Border.Width = 0;
            this.Pharmacy.StateTracking.Back.Image = global::EHR_Admin.Properties.Resources.pharma;
            this.Pharmacy.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Pharmacy.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Pharmacy.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Pharmacy.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Pharmacy.StateTracking.Border.Rounding = 25;
            this.Pharmacy.StateTracking.Border.Width = 5;
            this.Pharmacy.TabIndex = 9;
            this.Pharmacy.TabStop = false;
            this.Pharmacy.Values.Text = "";
            // 
            // Statistics
            // 
            this.Statistics.Location = new System.Drawing.Point(804, 216);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(115, 115);
            this.Statistics.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Statistics.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Statistics.StateCommon.Back.Image = global::EHR_Admin.Properties.Resources.pharma;
            this.Statistics.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Statistics.StateCommon.Border.Width = 0;
            this.Statistics.StateNormal.Back.Image = global::EHR_Admin.Properties.Resources.Statistics;
            this.Statistics.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Statistics.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Statistics.StateNormal.Border.Width = 0;
            this.Statistics.StatePressed.Back.Image = global::EHR_Admin.Properties.Resources.Statistics;
            this.Statistics.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Statistics.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Statistics.StatePressed.Border.Width = 0;
            this.Statistics.StateTracking.Back.Image = global::EHR_Admin.Properties.Resources.Statistics;
            this.Statistics.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Statistics.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Statistics.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Statistics.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Statistics.StateTracking.Border.Rounding = 25;
            this.Statistics.StateTracking.Border.Width = 5;
            this.Statistics.TabIndex = 9;
            this.Statistics.TabStop = false;
            this.Statistics.Values.Text = "";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EHR_Admin.Properties.Resources.Desktop___1Patient_Bg;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.Pharmacy);
            this.Controls.Add(this.Labs);
            this.Controls.Add(this.Hospital);
            this.Controls.Add(this.Hello);
            this.Controls.Add(this.Avatar);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Avatar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Hello;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Hospital;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Labs;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Pharmacy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Statistics;
    }
}