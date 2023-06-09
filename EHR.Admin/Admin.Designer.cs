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
            this.components = new System.ComponentModel.Container();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.Hello = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Hospital = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Labs = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Pharmacy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Statistics = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Add_Hospital = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox4 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox9 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox10 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox8 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.H_Street = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.H_Pass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.H_User = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Label_Name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.H_Name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox5 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox6 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox7 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Hos = new System.Windows.Forms.Label();
            this.Phar = new System.Windows.Forms.Label();
            this.Lab = new System.Windows.Forms.Label();
            this.Sta = new System.Windows.Forms.Label();
            this.Add_Admin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Logout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Hospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Hospital.Panel)).BeginInit();
            this.Add_Hospital.Panel.SuspendLayout();
            this.Add_Hospital.SuspendLayout();
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
            this.Hello.Size = new System.Drawing.Size(450, 90);
            this.Hello.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Hello.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Hello.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 52F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hello.TabIndex = 1;
            this.Hello.Values.Text = "Hello Admin!";
            this.Hello.Paint += new System.Windows.Forms.PaintEventHandler(this.Hello_Paint);
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
            this.Hospital.Click += new System.EventHandler(this.Hospital_Click);
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
            this.Labs.Click += new System.EventHandler(this.Labs_Click);
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
            this.Pharmacy.Click += new System.EventHandler(this.Pharmacy_Click);
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
            this.Statistics.Click += new System.EventHandler(this.Statistics_Click);
            // 
            // Add_Hospital
            // 
            this.Add_Hospital.CaptionVisible = false;
            this.Add_Hospital.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonLowProfile;
            this.Add_Hospital.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonLowProfile;
            this.Add_Hospital.Location = new System.Drawing.Point(102, 368);
            this.Add_Hospital.Name = "Add_Hospital";
            // 
            // Add_Hospital.Panel
            // 
            this.Add_Hospital.Panel.Controls.Add(this.kryptonLabel1);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonTextBox4);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonButton1);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonLabel13);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonTextBox9);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonLabel14);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonTextBox10);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonLabel5);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonTextBox8);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonTextBox2);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonLabel6);
            this.Add_Hospital.Panel.Controls.Add(this.H_Street);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonLabel4);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonLabel3);
            this.Add_Hospital.Panel.Controls.Add(this.H_Pass);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonLabel2);
            this.Add_Hospital.Panel.Controls.Add(this.H_User);
            this.Add_Hospital.Panel.Controls.Add(this.Label_Name);
            this.Add_Hospital.Panel.Controls.Add(this.H_Name);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonLabel7);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonTextBox1);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonLabel8);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonTextBox3);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonLabel10);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonTextBox5);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonLabel11);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonTextBox6);
            this.Add_Hospital.Panel.Controls.Add(this.kryptonTextBox7);
            this.Add_Hospital.Size = new System.Drawing.Size(820, 350);
            this.Add_Hospital.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Add_Hospital.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Add_Hospital.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Add_Hospital.StateCommon.Border.Width = 0;
            this.Add_Hospital.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.Add_Hospital.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.Add_Hospital.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.Add_Hospital.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Add_Hospital.StateNormal.Border.Width = 0;
            this.Add_Hospital.TabIndex = 10;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(506, 88);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(147, 20);
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "(enter comma separated)";
            this.kryptonLabel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // kryptonTextBox4
            // 
            this.kryptonTextBox4.Location = new System.Drawing.Point(414, 114);
            this.kryptonTextBox4.Name = "kryptonTextBox4";
            this.kryptonTextBox4.Size = new System.Drawing.Size(370, 22);
            this.kryptonTextBox4.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox4.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox4.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox4.TabIndex = 17;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(318, 295);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(177, 45);
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
            this.kryptonButton1.TabIndex = 16;
            this.kryptonButton1.Values.Text = "SUBMIT";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(414, 232);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel13.TabIndex = 15;
            this.kryptonLabel13.Values.Text = "Zip Code";
            // 
            // kryptonTextBox9
            // 
            this.kryptonTextBox9.Location = new System.Drawing.Point(414, 258);
            this.kryptonTextBox9.Name = "kryptonTextBox9";
            this.kryptonTextBox9.Size = new System.Drawing.Size(370, 22);
            this.kryptonTextBox9.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox9.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox9.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox9.TabIndex = 14;
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(28, 232);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(146, 20);
            this.kryptonLabel14.TabIndex = 13;
            this.kryptonLabel14.Values.Text = "State / Province / Region";
            // 
            // kryptonTextBox10
            // 
            this.kryptonTextBox10.Location = new System.Drawing.Point(28, 258);
            this.kryptonTextBox10.Name = "kryptonTextBox10";
            this.kryptonTextBox10.Size = new System.Drawing.Size(370, 22);
            this.kryptonTextBox10.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox10.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox10.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox10.TabIndex = 12;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(414, 153);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(31, 20);
            this.kryptonLabel5.TabIndex = 11;
            this.kryptonLabel5.Values.Text = "City";
            // 
            // kryptonTextBox8
            // 
            this.kryptonTextBox8.Location = new System.Drawing.Point(414, 179);
            this.kryptonTextBox8.Name = "kryptonTextBox8";
            this.kryptonTextBox8.Size = new System.Drawing.Size(370, 22);
            this.kryptonTextBox8.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox8.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox8.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox8.TabIndex = 10;
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(414, 179);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(370, 22);
            this.kryptonTextBox2.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox2.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox2.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox2.TabIndex = 10;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(28, 153);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel6.TabIndex = 9;
            this.kryptonLabel6.Values.Text = "Street Address";
            // 
            // H_Street
            // 
            this.H_Street.Location = new System.Drawing.Point(28, 179);
            this.H_Street.Name = "H_Street";
            this.H_Street.Size = new System.Drawing.Size(370, 22);
            this.H_Street.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.H_Street.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.H_Street.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.H_Street.TabIndex = 8;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(414, 88);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(93, 20);
            this.kryptonLabel4.TabIndex = 7;
            this.kryptonLabel4.Values.Text = "Phone Number";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(28, 88);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "Password";
            // 
            // H_Pass
            // 
            this.H_Pass.Location = new System.Drawing.Point(28, 114);
            this.H_Pass.Name = "H_Pass";
            this.H_Pass.Size = new System.Drawing.Size(370, 22);
            this.H_Pass.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.H_Pass.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.H_Pass.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.H_Pass.TabIndex = 4;
            this.H_Pass.TextChanged += new System.EventHandler(this.H_Pass_TextChanged);
            this.H_Pass.Enter += new System.EventHandler(this.H_Pass_Enter);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(414, 21);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Username";
            this.kryptonLabel2.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel2_Paint);
            // 
            // H_User
            // 
            this.H_User.Location = new System.Drawing.Point(414, 47);
            this.H_User.Name = "H_User";
            this.H_User.Size = new System.Drawing.Size(370, 22);
            this.H_User.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.H_User.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.H_User.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.H_User.TabIndex = 2;
            // 
            // Label_Name
            // 
            this.Label_Name.Location = new System.Drawing.Point(28, 21);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(92, 20);
            this.Label_Name.TabIndex = 1;
            this.Label_Name.Values.Text = "Hospital Name";
            // 
            // H_Name
            // 
            this.H_Name.Location = new System.Drawing.Point(28, 47);
            this.H_Name.Name = "H_Name";
            this.H_Name.Size = new System.Drawing.Size(370, 22);
            this.H_Name.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.H_Name.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.H_Name.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.H_Name.TabIndex = 0;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(414, 153);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(31, 20);
            this.kryptonLabel7.TabIndex = 11;
            this.kryptonLabel7.Values.Text = "City";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(414, 179);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(370, 22);
            this.kryptonTextBox1.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox1.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox1.TabIndex = 10;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(28, 153);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel8.TabIndex = 9;
            this.kryptonLabel8.Values.Text = "Street Address";
            // 
            // kryptonTextBox3
            // 
            this.kryptonTextBox3.Location = new System.Drawing.Point(28, 179);
            this.kryptonTextBox3.Name = "kryptonTextBox3";
            this.kryptonTextBox3.Size = new System.Drawing.Size(370, 22);
            this.kryptonTextBox3.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox3.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox3.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox3.TabIndex = 8;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(28, 88);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel10.TabIndex = 5;
            this.kryptonLabel10.Values.Text = "Password";
            // 
            // kryptonTextBox5
            // 
            this.kryptonTextBox5.Location = new System.Drawing.Point(28, 114);
            this.kryptonTextBox5.Name = "kryptonTextBox5";
            this.kryptonTextBox5.Size = new System.Drawing.Size(370, 22);
            this.kryptonTextBox5.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox5.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox5.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox5.TabIndex = 4;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(414, 21);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel11.TabIndex = 3;
            this.kryptonLabel11.Values.Text = "Username";
            // 
            // kryptonTextBox6
            // 
            this.kryptonTextBox6.Location = new System.Drawing.Point(414, 47);
            this.kryptonTextBox6.Name = "kryptonTextBox6";
            this.kryptonTextBox6.Size = new System.Drawing.Size(370, 22);
            this.kryptonTextBox6.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox6.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox6.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox6.TabIndex = 2;
            // 
            // kryptonTextBox7
            // 
            this.kryptonTextBox7.Location = new System.Drawing.Point(28, 47);
            this.kryptonTextBox7.Name = "kryptonTextBox7";
            this.kryptonTextBox7.Size = new System.Drawing.Size(370, 22);
            this.kryptonTextBox7.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox7.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox7.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.kryptonTextBox7.TabIndex = 0;
            // 
            // Hos
            // 
            this.Hos.AutoSize = true;
            this.Hos.BackColor = System.Drawing.Color.Transparent;
            this.Hos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Hos.Location = new System.Drawing.Point(111, 335);
            this.Hos.Name = "Hos";
            this.Hos.Size = new System.Drawing.Size(112, 20);
            this.Hos.TabIndex = 11;
            this.Hos.Text = "Add Hospital";
            // 
            // Phar
            // 
            this.Phar.AutoSize = true;
            this.Phar.BackColor = System.Drawing.Color.Transparent;
            this.Phar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Phar.Location = new System.Drawing.Point(350, 334);
            this.Phar.Name = "Phar";
            this.Phar.Size = new System.Drawing.Size(124, 20);
            this.Phar.TabIndex = 12;
            this.Phar.Text = "Add Pharmacy";
            // 
            // Lab
            // 
            this.Lab.AutoSize = true;
            this.Lab.BackColor = System.Drawing.Color.Transparent;
            this.Lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Lab.Location = new System.Drawing.Point(585, 332);
            this.Lab.Name = "Lab";
            this.Lab.Size = new System.Drawing.Size(132, 20);
            this.Lab.TabIndex = 13;
            this.Lab.Text = "Add Laboratory";
            // 
            // Sta
            // 
            this.Sta.AutoSize = true;
            this.Sta.BackColor = System.Drawing.Color.Transparent;
            this.Sta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Sta.Location = new System.Drawing.Point(800, 332);
            this.Sta.Name = "Sta";
            this.Sta.Size = new System.Drawing.Size(133, 20);
            this.Sta.TabIndex = 14;
            this.Sta.Text = "Show Statistics";
            // 
            // Add_Admin
            // 
            this.Add_Admin.AccessibleDescription = "Add Admin";
            this.Add_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Admin.Location = new System.Drawing.Point(958, 12);
            this.Add_Admin.Name = "Add_Admin";
            this.Add_Admin.Size = new System.Drawing.Size(38, 38);
            this.Add_Admin.StateCommon.Back.Image = global::EHR_Admin.Properties.Resources.Add_Admin;
            this.Add_Admin.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.Add_Admin.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.Add_Admin.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Add_Admin.StateDisabled.Border.Rounding = 25;
            this.Add_Admin.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Add_Admin.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Add_Admin.StateNormal.Back.Image = global::EHR_Admin.Properties.Resources.Add_Admin;
            this.Add_Admin.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.Add_Admin.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Add_Admin.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Add_Admin.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Add_Admin.StateNormal.Border.Rounding = 25;
            this.Add_Admin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Add_Admin.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Add_Admin.StatePressed.Back.Image = global::EHR_Admin.Properties.Resources.Add_Admin;
            this.Add_Admin.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Add_Admin.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Add_Admin.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Add_Admin.StatePressed.Border.Rounding = 25;
            this.Add_Admin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Add_Admin.StateTracking.Border.Rounding = 25;
            this.Add_Admin.TabIndex = 15;
            this.Add_Admin.Values.Text = "";
            this.Add_Admin.Click += new System.EventHandler(this.Add_Admin_Click);
            this.Add_Admin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Back_MouseMove);
            // 
            // Logout
            // 
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Logout.Location = new System.Drawing.Point(953, 69);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(43, 42);
            this.Logout.StateCommon.Back.Image = global::EHR_Admin.Properties.Resources.Logout;
            this.Logout.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.Logout.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.Logout.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Logout.StateDisabled.Border.Rounding = 25;
            this.Logout.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StateNormal.Back.Image = global::EHR_Admin.Properties.Resources.Logout;
            this.Logout.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.Logout.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Logout.StateNormal.Border.Rounding = 25;
            this.Logout.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StatePressed.Back.Image = global::EHR_Admin.Properties.Resources.Logout;
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
            this.Logout.TabIndex = 43;
            this.Logout.Values.Text = "";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EHR_Admin.Properties.Resources.Desktop___1Patient_Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Add_Admin);
            this.Controls.Add(this.Sta);
            this.Controls.Add(this.Lab);
            this.Controls.Add(this.Phar);
            this.Controls.Add(this.Hos);
            this.Controls.Add(this.Add_Hospital);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.Pharmacy);
            this.Controls.Add(this.Labs);
            this.Controls.Add(this.Hospital);
            this.Controls.Add(this.Hello);
            this.Controls.Add(this.Avatar);
            this.DoubleBuffered = true;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Hospital.Panel)).EndInit();
            this.Add_Hospital.Panel.ResumeLayout(false);
            this.Add_Hospital.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Hospital)).EndInit();
            this.Add_Hospital.ResumeLayout(false);
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
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox Add_Hospital;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox H_Pass;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox H_User;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox H_Street;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox10;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox7;
        private System.Windows.Forms.Label Hos;
        private System.Windows.Forms.Label Phar;
        private System.Windows.Forms.Label Lab;
        private System.Windows.Forms.Label Sta;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Label_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox H_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Add_Admin;
        private System.Windows.Forms.ToolTip toolTip1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Logout;
    }
}