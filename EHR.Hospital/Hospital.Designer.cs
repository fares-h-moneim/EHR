namespace EHR_Hospital
{
    partial class Hospital
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
            this.img1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Diagnosis = new System.Windows.Forms.Label();
            this.Surgery = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.kryptonButton5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Logout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // img1
            // 
            this.img1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img1.Location = new System.Drawing.Point(177, 294);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(129, 129);
            this.img1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.img1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.img1.StateCommon.Back.Image = global::EHR_Hospital.Properties.Resources.Diagnosis;
            this.img1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img1.StateCommon.Border.Width = 0;
            this.img1.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.img1.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.img1.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.img1.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.img1.StateNormal.Back.Image = global::EHR_Hospital.Properties.Resources.Diagnosis;
            this.img1.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img1.StateNormal.Border.Width = 0;
            this.img1.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.img1.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.img1.StatePressed.Back.Image = global::EHR_Hospital.Properties.Resources.Diagnosis;
            this.img1.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img1.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.img1.StatePressed.Border.Rounding = 25;
            this.img1.StatePressed.Border.Width = 5;
            this.img1.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.img1.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.img1.StateTracking.Back.Image = global::EHR_Hospital.Properties.Resources.Diagnosis;
            this.img1.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img1.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.img1.StateTracking.Border.Rounding = 25;
            this.img1.StateTracking.Border.Width = 5;
            this.img1.TabIndex = 8;
            this.img1.TabStop = false;
            this.img1.Values.Text = "";
            this.img1.Click += new System.EventHandler(this.img1_Click);
            // 
            // Diagnosis
            // 
            this.Diagnosis.AutoSize = true;
            this.Diagnosis.BackColor = System.Drawing.Color.Transparent;
            this.Diagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Diagnosis.Location = new System.Drawing.Point(168, 424);
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.Size = new System.Drawing.Size(137, 20);
            this.Diagnosis.TabIndex = 15;
            this.Diagnosis.Text = "Issue Diagnosis";
            // 
            // Surgery
            // 
            this.Surgery.AutoSize = true;
            this.Surgery.BackColor = System.Drawing.Color.Transparent;
            this.Surgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surgery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Surgery.Location = new System.Drawing.Point(718, 424);
            this.Surgery.Name = "Surgery";
            this.Surgery.Size = new System.Drawing.Size(144, 20);
            this.Surgery.TabIndex = 17;
            this.Surgery.Text = "Surgery Request";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(719, 294);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(129, 129);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Back.Image = global::EHR_Hospital.Properties.Resources.Surgery;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Width = 0;
            this.kryptonButton1.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Back.Image = global::EHR_Hospital.Properties.Resources.Surgery;
            this.kryptonButton1.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Border.Width = 0;
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StatePressed.Back.Image = global::EHR_Hospital.Properties.Resources.Surgery;
            this.kryptonButton1.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonButton1.StatePressed.Border.Rounding = 25;
            this.kryptonButton1.StatePressed.Border.Width = 5;
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateTracking.Back.Image = global::EHR_Hospital.Properties.Resources.Surgery;
            this.kryptonButton1.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonButton1.StateTracking.Border.Rounding = 25;
            this.kryptonButton1.StateTracking.Border.Width = 5;
            this.kryptonButton1.TabIndex = 16;
            this.kryptonButton1.TabStop = false;
            this.kryptonButton1.Values.Text = "";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(164, 678);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Issue Death Report";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton2.Location = new System.Drawing.Point(176, 546);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(129, 129);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateCommon.Back.Image = global::EHR_Hospital.Properties.Resources.Dead;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Width = 0;
            this.kryptonButton2.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateNormal.Back.Image = global::EHR_Hospital.Properties.Resources.Dead;
            this.kryptonButton2.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton2.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateNormal.Border.Width = 0;
            this.kryptonButton2.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StatePressed.Back.Image = global::EHR_Hospital.Properties.Resources.Dead;
            this.kryptonButton2.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton2.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton2.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton2.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonButton2.StatePressed.Border.Rounding = 25;
            this.kryptonButton2.StatePressed.Border.Width = 5;
            this.kryptonButton2.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateTracking.Back.Image = global::EHR_Hospital.Properties.Resources.Dead;
            this.kryptonButton2.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton2.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton2.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton2.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonButton2.StateTracking.Border.Rounding = 25;
            this.kryptonButton2.StateTracking.Border.Width = 5;
            this.kryptonButton2.TabIndex = 18;
            this.kryptonButton2.TabStop = false;
            this.kryptonButton2.Values.Text = "";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.label2.Location = new System.Drawing.Point(722, 678);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Organ Request";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton3.Location = new System.Drawing.Point(724, 546);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(129, 129);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Back.Image = global::EHR_Hospital.Properties.Resources.organs;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Width = 0;
            this.kryptonButton3.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateNormal.Back.Image = global::EHR_Hospital.Properties.Resources.organs;
            this.kryptonButton3.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton3.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateNormal.Border.Width = 0;
            this.kryptonButton3.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StatePressed.Back.Image = global::EHR_Hospital.Properties.Resources.organs;
            this.kryptonButton3.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton3.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton3.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton3.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonButton3.StatePressed.Border.Rounding = 25;
            this.kryptonButton3.StatePressed.Border.Width = 5;
            this.kryptonButton3.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateTracking.Back.Image = global::EHR_Hospital.Properties.Resources.organs;
            this.kryptonButton3.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton3.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton3.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton3.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonButton3.StateTracking.Border.Rounding = 25;
            this.kryptonButton3.StateTracking.Border.Width = 5;
            this.kryptonButton3.TabIndex = 20;
            this.kryptonButton3.TabStop = false;
            this.kryptonButton3.Values.Text = "";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.label3.Location = new System.Drawing.Point(438, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "View Patient History";
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton4.Location = new System.Drawing.Point(457, 294);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(129, 129);
            this.kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateCommon.Back.Image = global::EHR_Hospital.Properties.Resources.History;
            this.kryptonButton4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StateCommon.Border.Width = 0;
            this.kryptonButton4.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateNormal.Back.Image = global::EHR_Hospital.Properties.Resources.History;
            this.kryptonButton4.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton4.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StateNormal.Border.Width = 0;
            this.kryptonButton4.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StatePressed.Back.Image = global::EHR_Hospital.Properties.Resources.History;
            this.kryptonButton4.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton4.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton4.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton4.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonButton4.StatePressed.Border.Rounding = 25;
            this.kryptonButton4.StatePressed.Border.Width = 5;
            this.kryptonButton4.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateTracking.Back.Image = global::EHR_Hospital.Properties.Resources.History;
            this.kryptonButton4.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton4.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton4.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton4.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonButton4.StateTracking.Border.Rounding = 25;
            this.kryptonButton4.StateTracking.Border.Width = 5;
            this.kryptonButton4.TabIndex = 22;
            this.kryptonButton4.TabStop = false;
            this.kryptonButton4.Values.Text = "";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.label4.Location = new System.Drawing.Point(445, 678);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Lab Tests Request";
            // 
            // kryptonButton5
            // 
            this.kryptonButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton5.Location = new System.Drawing.Point(457, 546);
            this.kryptonButton5.Name = "kryptonButton5";
            this.kryptonButton5.Size = new System.Drawing.Size(129, 129);
            this.kryptonButton5.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateCommon.Back.Image = global::EHR_Hospital.Properties.Resources.Lab1;
            this.kryptonButton5.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton5.StateCommon.Border.Width = 0;
            this.kryptonButton5.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateNormal.Back.Image = global::EHR_Hospital.Properties.Resources.Lab1;
            this.kryptonButton5.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton5.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton5.StateNormal.Border.Width = 0;
            this.kryptonButton5.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StatePressed.Back.Image = global::EHR_Hospital.Properties.Resources.Lab1;
            this.kryptonButton5.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton5.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton5.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton5.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonButton5.StatePressed.Border.Rounding = 25;
            this.kryptonButton5.StatePressed.Border.Width = 5;
            this.kryptonButton5.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateTracking.Back.Image = global::EHR_Hospital.Properties.Resources.Lab1;
            this.kryptonButton5.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton5.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton5.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.kryptonButton5.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonButton5.StateTracking.Border.Rounding = 25;
            this.kryptonButton5.StateTracking.Border.Width = 5;
            this.kryptonButton5.TabIndex = 24;
            this.kryptonButton5.TabStop = false;
            this.kryptonButton5.Values.Text = "";
            this.kryptonButton5.Click += new System.EventHandler(this.kryptonButton5_Click);
            // 
            // Logout
            // 
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Logout.Location = new System.Drawing.Point(968, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(43, 42);
            this.Logout.StateCommon.Back.Image = global::EHR_Hospital.Properties.Resources.Logout;
            this.Logout.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.Logout.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.Logout.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Logout.StateDisabled.Border.Rounding = 25;
            this.Logout.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StateNormal.Back.Image = global::EHR_Hospital.Properties.Resources.Logout;
            this.Logout.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.Logout.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Logout.StateNormal.Border.Rounding = 25;
            this.Logout.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StatePressed.Back.Image = global::EHR_Hospital.Properties.Resources.Logout;
            this.Logout.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Logout.StatePressed.Border.Rounding = 25;
            this.Logout.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Logout.StateTracking.Border.Rounding = 25;
            this.Logout.TabIndex = 38;
            this.Logout.Values.Text = "";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EHR_Hospital.Properties.Resources.Hospital_View;
            this.ClientSize = new System.Drawing.Size(1023, 729);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kryptonButton5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kryptonButton4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.Surgery);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.Diagnosis);
            this.Controls.Add(this.img1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Hospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.Hospital_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton img1;
        private System.Windows.Forms.Label Diagnosis;
        private System.Windows.Forms.Label Surgery;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Logout;
    }
}