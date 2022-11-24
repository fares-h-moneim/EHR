namespace WindowsFormsApp1
{
    partial class Patient
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
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.Hello = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Gender = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Birthday = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Blood = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Email = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Phone = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Hospital = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Labs = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Pharmacy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Family = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Organs = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.EditUserDetails = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Avatar
            // 
            this.Avatar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.default_avatar;
            this.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Avatar.InitialImage = global::WindowsFormsApp1.Properties.Resources.default_avatar;
            this.Avatar.Location = new System.Drawing.Point(68, 32);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(145, 145);
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            // 
            // Hello
            // 
            this.Hello.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.Hello.Location = new System.Drawing.Point(219, 32);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(431, 67);
            this.Hello.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Hello.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Hello.StateCommon.ShortText.Font = new System.Drawing.Font("Inter ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hello.TabIndex = 1;
            this.Hello.Values.Text = "Hello UserName!";
            this.Hello.Paint += new System.Windows.Forms.PaintEventHandler(this.Hello_Paint);
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(224, 87);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(150, 31);
            this.Gender.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Gender.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Gender.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.TabIndex = 2;
            this.Gender.Values.Text = "Gender: Male";
            this.Gender.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(224, 112);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(234, 31);
            this.Birthday.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Birthday.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Birthday.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.TabIndex = 3;
            this.Birthday.Values.Text = "Birthday: 29/04/2002";
            // 
            // Blood
            // 
            this.Blood.Location = new System.Drawing.Point(224, 139);
            this.Blood.Name = "Blood";
            this.Blood.Size = new System.Drawing.Size(156, 31);
            this.Blood.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Blood.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Blood.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blood.TabIndex = 4;
            this.Blood.Values.Text = "Blood Type: A";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(484, 112);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(362, 31);
            this.Email.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Email.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Email.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.TabIndex = 6;
            this.Email.Values.Text = "Email: fares.h.moneim@gmail.com";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(484, 87);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(245, 31);
            this.Phone.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Phone.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Phone.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.TabIndex = 5;
            this.Phone.Values.Text = "Phone #: 01117997474";
            this.Phone.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel4_Paint);
            // 
            // Hospital
            // 
            this.Hospital.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hospital.Location = new System.Drawing.Point(164, 206);
            this.Hospital.Name = "Hospital";
            this.Hospital.Size = new System.Drawing.Size(129, 129);
            this.Hospital.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.Hospital.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Hospital.StateCommon.Border.Width = 0;
            this.Hospital.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.Hospital.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Hospital.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Hospital.StateNormal.Border.Width = 0;
            this.Hospital.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.Hospital.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Hospital.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Hospital.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Hospital.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Hospital.StatePressed.Border.Rounding = 25;
            this.Hospital.StatePressed.Border.Width = 5;
            this.Hospital.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
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
            this.Labs.Location = new System.Drawing.Point(340, 217);
            this.Labs.Name = "Labs";
            this.Labs.Size = new System.Drawing.Size(115, 115);
            this.Labs.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Labs.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Labs.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.Lab;
            this.Labs.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Labs.StateCommon.Border.Width = 0;
            this.Labs.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.Lab;
            this.Labs.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Labs.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Labs.StateNormal.Border.Width = 0;
            this.Labs.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.Lab;
            this.Labs.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Labs.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Labs.StatePressed.Border.Width = 0;
            this.Labs.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.Lab;
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
            this.Pharmacy.Location = new System.Drawing.Point(475, 220);
            this.Pharmacy.Name = "Pharmacy";
            this.Pharmacy.Size = new System.Drawing.Size(115, 115);
            this.Pharmacy.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Pharmacy.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Pharmacy.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharma;
            this.Pharmacy.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Pharmacy.StateCommon.Border.Width = 0;
            this.Pharmacy.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharma;
            this.Pharmacy.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Pharmacy.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Pharmacy.StateNormal.Border.Width = 0;
            this.Pharmacy.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharma;
            this.Pharmacy.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Pharmacy.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Pharmacy.StatePressed.Border.Width = 0;
            this.Pharmacy.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharma;
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
            // Family
            // 
            this.Family.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Family.Location = new System.Drawing.Point(613, 220);
            this.Family.Name = "Family";
            this.Family.Size = new System.Drawing.Size(115, 115);
            this.Family.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Family.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Family.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources._2770519;
            this.Family.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Family.StateCommon.Border.Width = 0;
            this.Family.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.Family;
            this.Family.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Family.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Family.StateNormal.Border.Width = 0;
            this.Family.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.Family;
            this.Family.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Family.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Family.StatePressed.Border.Width = 0;
            this.Family.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.Family;
            this.Family.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Family.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Family.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Family.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Family.StateTracking.Border.Rounding = 25;
            this.Family.StateTracking.Border.Width = 5;
            this.Family.TabIndex = 10;
            this.Family.TabStop = false;
            this.Family.Values.Text = "";
            this.Family.Click += new System.EventHandler(this.Family_Click);
            // 
            // Organs
            // 
            this.Organs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Organs.Location = new System.Drawing.Point(749, 237);
            this.Organs.Name = "Organs";
            this.Organs.Size = new System.Drawing.Size(115, 98);
            this.Organs.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Organs.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Organs.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.organs;
            this.Organs.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Organs.StateCommon.Border.Width = 0;
            this.Organs.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.organs;
            this.Organs.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Organs.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Organs.StateNormal.Border.Width = 0;
            this.Organs.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.organs;
            this.Organs.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Organs.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Organs.StatePressed.Border.Width = 0;
            this.Organs.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.organs;
            this.Organs.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Organs.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Organs.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Organs.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Organs.StateTracking.Border.Rounding = 25;
            this.Organs.StateTracking.Border.Width = 5;
            this.Organs.TabIndex = 11;
            this.Organs.TabStop = false;
            this.Organs.Values.Text = "";
            this.Organs.Click += new System.EventHandler(this.Organs_Click);
            // 
            // EditUserDetails
            // 
            this.EditUserDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditUserDetails.Location = new System.Drawing.Point(628, 36);
            this.EditUserDetails.Name = "EditUserDetails";
            this.EditUserDetails.Size = new System.Drawing.Size(50, 50);
            this.EditUserDetails.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.EditUserDetails.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.EditUserDetails.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.edit;
            this.EditUserDetails.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EditUserDetails.StateCommon.Border.Width = 0;
            this.EditUserDetails.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.edit;
            this.EditUserDetails.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.EditUserDetails.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EditUserDetails.StateNormal.Border.Width = 0;
            this.EditUserDetails.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.edit;
            this.EditUserDetails.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.EditUserDetails.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EditUserDetails.StatePressed.Border.Width = 0;
            this.EditUserDetails.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.edit;
            this.EditUserDetails.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.EditUserDetails.TabIndex = 13;
            this.EditUserDetails.Values.Text = "";
            this.EditUserDetails.Click += new System.EventHandler(this.EditUserDetails_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Desktop___1Patient_Bg;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.EditUserDetails);
            this.Controls.Add(this.Organs);
            this.Controls.Add(this.Family);
            this.Controls.Add(this.Pharmacy);
            this.Controls.Add(this.Labs);
            this.Controls.Add(this.Hospital);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Blood);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Hello);
            this.Controls.Add(this.Avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Avatar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Hello;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Gender;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Birthday;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Blood;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Email;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Phone;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Hospital;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Labs;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Pharmacy;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Family;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Organs;
        private ComponentFactory.Krypton.Toolkit.KryptonButton EditUserDetails;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}