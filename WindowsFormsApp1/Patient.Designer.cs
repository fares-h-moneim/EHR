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
            this.Gender = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Birthday = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Blood = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Email = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Phone = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.img1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.img2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.img3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.img4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.img5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.EditUserDetails = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Hospital = new System.Windows.Forms.Label();
            this.Labs = new System.Windows.Forms.Label();
            this.Pharmacy = new System.Windows.Forms.Label();
            this.Family = new System.Windows.Forms.Label();
            this.Organs = new System.Windows.Forms.Label();
            this.Surgery = new System.Windows.Forms.Label();
            this.img6 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Logout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.Avatar.Click += new System.EventHandler(this.Avatar_Click);
            // 
            // Hello
            // 
            this.Hello.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.Hello.Location = new System.Drawing.Point(219, 32);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(413, 63);
            this.Hello.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Hello.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Hello.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hello.TabIndex = 1;
            this.Hello.Values.Text = "Hello UserName!";
            this.Hello.Paint += new System.Windows.Forms.PaintEventHandler(this.Hello_Paint);
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(224, 87);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(144, 29);
            this.Gender.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Gender.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Gender.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.TabIndex = 2;
            this.Gender.Values.Text = "Gender: Male";
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(224, 112);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(213, 29);
            this.Birthday.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Birthday.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Birthday.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.TabIndex = 3;
            this.Birthday.Values.Text = "Birthday: 29/04/2002";
            // 
            // Blood
            // 
            this.Blood.Location = new System.Drawing.Point(224, 139);
            this.Blood.Name = "Blood";
            this.Blood.Size = new System.Drawing.Size(149, 29);
            this.Blood.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Blood.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Blood.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blood.TabIndex = 4;
            this.Blood.Values.Text = "Blood Type: A";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(484, 112);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(350, 29);
            this.Email.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Email.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Email.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.TabIndex = 6;
            this.Email.Values.Text = "Email: fares.h.moneim@gmail.com";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(484, 87);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(238, 29);
            this.Phone.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Phone.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Phone.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.TabIndex = 5;
            this.Phone.Values.Text = "Phone #: 01117997474";
            // 
            // img1
            // 
            this.img1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img1.Location = new System.Drawing.Point(177, 294);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(129, 129);
            this.img1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.img1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.img1.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.img1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img1.StateCommon.Border.Width = 0;
            this.img1.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.img1.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.img1.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.img1.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.img1.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.img1.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img1.StateNormal.Border.Width = 0;
            this.img1.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.img1.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.img1.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.img1.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img1.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.img1.StatePressed.Border.Rounding = 25;
            this.img1.StatePressed.Border.Width = 5;
            this.img1.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.img1.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.img1.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.img1.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img1.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.img1.StateTracking.Border.Rounding = 25;
            this.img1.StateTracking.Border.Width = 5;
            this.img1.TabIndex = 7;
            this.img1.TabStop = false;
            this.img1.Values.Text = "";
            this.img1.Click += new System.EventHandler(this.Hospital_Click);
            // 
            // img2
            // 
            this.img2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img2.Location = new System.Drawing.Point(448, 294);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(115, 115);
            this.img2.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.img2.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.img2.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.Lab;
            this.img2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img2.StateCommon.Border.Width = 0;
            this.img2.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.Lab;
            this.img2.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img2.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img2.StateNormal.Border.Width = 0;
            this.img2.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.Lab;
            this.img2.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img2.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img2.StatePressed.Border.Width = 0;
            this.img2.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.Lab;
            this.img2.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img2.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img2.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img2.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.img2.StateTracking.Border.Rounding = 25;
            this.img2.StateTracking.Border.Width = 5;
            this.img2.TabIndex = 8;
            this.img2.TabStop = false;
            this.img2.Values.Text = "";
            this.img2.Click += new System.EventHandler(this.Labs_Click);
            // 
            // img3
            // 
            this.img3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img3.Location = new System.Drawing.Point(719, 294);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(115, 115);
            this.img3.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.img3.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.img3.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharma;
            this.img3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img3.StateCommon.Border.Width = 0;
            this.img3.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharma;
            this.img3.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img3.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img3.StateNormal.Border.Width = 0;
            this.img3.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharma;
            this.img3.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img3.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img3.StatePressed.Border.Width = 0;
            this.img3.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharma;
            this.img3.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img3.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img3.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img3.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.img3.StateTracking.Border.Rounding = 25;
            this.img3.StateTracking.Border.Width = 5;
            this.img3.TabIndex = 9;
            this.img3.TabStop = false;
            this.img3.Values.Text = "";
            this.img3.Click += new System.EventHandler(this.Pharmacy_Click);
            // 
            // img4
            // 
            this.img4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img4.Location = new System.Drawing.Point(188, 546);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(115, 115);
            this.img4.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.img4.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.img4.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources._2770519;
            this.img4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img4.StateCommon.Border.Width = 0;
            this.img4.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.Family;
            this.img4.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img4.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img4.StateNormal.Border.Width = 0;
            this.img4.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.Family;
            this.img4.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img4.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img4.StatePressed.Border.Width = 0;
            this.img4.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.Family;
            this.img4.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img4.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img4.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img4.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.img4.StateTracking.Border.Rounding = 25;
            this.img4.StateTracking.Border.Width = 5;
            this.img4.TabIndex = 10;
            this.img4.TabStop = false;
            this.img4.Values.Text = "";
            this.img4.Click += new System.EventHandler(this.Family_Click);
            // 
            // img5
            // 
            this.img5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img5.Location = new System.Drawing.Point(448, 546);
            this.img5.Name = "img5";
            this.img5.Size = new System.Drawing.Size(115, 98);
            this.img5.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.img5.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.img5.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.organs;
            this.img5.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img5.StateCommon.Border.Width = 0;
            this.img5.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.organs;
            this.img5.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img5.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img5.StateNormal.Border.Width = 0;
            this.img5.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.organs;
            this.img5.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img5.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img5.StatePressed.Border.Width = 0;
            this.img5.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.organs;
            this.img5.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img5.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img5.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img5.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.img5.StateTracking.Border.Rounding = 25;
            this.img5.StateTracking.Border.Width = 5;
            this.img5.TabIndex = 11;
            this.img5.TabStop = false;
            this.img5.Values.Text = "";
            this.img5.Click += new System.EventHandler(this.Organs_Click);
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
            this.EditUserDetails.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.EditUserDetails.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
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
            this.EditUserDetails.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.EditUserDetails.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.EditUserDetails.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.edit;
            this.EditUserDetails.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.EditUserDetails.TabIndex = 13;
            this.EditUserDetails.Values.Text = "";
            this.EditUserDetails.Click += new System.EventHandler(this.EditUserDetails_Click);
            // 
            // Hospital
            // 
            this.Hospital.AutoSize = true;
            this.Hospital.BackColor = System.Drawing.Color.Transparent;
            this.Hospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hospital.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Hospital.Location = new System.Drawing.Point(158, 413);
            this.Hospital.Name = "Hospital";
            this.Hospital.Size = new System.Drawing.Size(174, 20);
            this.Hospital.TabIndex = 14;
            this.Hospital.Text = "View Medical History";
            // 
            // Labs
            // 
            this.Labs.AutoSize = true;
            this.Labs.BackColor = System.Drawing.Color.Transparent;
            this.Labs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Labs.Location = new System.Drawing.Point(432, 412);
            this.Labs.Name = "Labs";
            this.Labs.Size = new System.Drawing.Size(148, 20);
            this.Labs.TabIndex = 15;
            this.Labs.Text = "View Lab Results";
            // 
            // Pharmacy
            // 
            this.Pharmacy.AutoSize = true;
            this.Pharmacy.BackColor = System.Drawing.Color.Transparent;
            this.Pharmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pharmacy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Pharmacy.Location = new System.Drawing.Point(704, 412);
            this.Pharmacy.Name = "Pharmacy";
            this.Pharmacy.Size = new System.Drawing.Size(156, 20);
            this.Pharmacy.TabIndex = 16;
            this.Pharmacy.Text = "View Prescriptions";
            // 
            // Family
            // 
            this.Family.AutoSize = true;
            this.Family.BackColor = System.Drawing.Color.Transparent;
            this.Family.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Family.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Family.Location = new System.Drawing.Point(158, 664);
            this.Family.Name = "Family";
            this.Family.Size = new System.Drawing.Size(175, 20);
            this.Family.TabIndex = 17;
            this.Family.Text = "Add Family Members";
            // 
            // Organs
            // 
            this.Organs.AutoSize = true;
            this.Organs.BackColor = System.Drawing.Color.Transparent;
            this.Organs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Organs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Organs.Location = new System.Drawing.Point(404, 664);
            this.Organs.Name = "Organs";
            this.Organs.Size = new System.Drawing.Size(212, 20);
            this.Organs.TabIndex = 18;
            this.Organs.Text = "Apply for Organ Donation";
            // 
            // Surgery
            // 
            this.Surgery.AutoSize = true;
            this.Surgery.BackColor = System.Drawing.Color.Transparent;
            this.Surgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surgery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Surgery.Location = new System.Drawing.Point(717, 664);
            this.Surgery.Name = "Surgery";
            this.Surgery.Size = new System.Drawing.Size(129, 20);
            this.Surgery.TabIndex = 20;
            this.Surgery.Text = "View Surgeries";
            // 
            // img6
            // 
            this.img6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img6.Location = new System.Drawing.Point(718, 546);
            this.img6.Name = "img6";
            this.img6.Size = new System.Drawing.Size(115, 115);
            this.img6.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.img6.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.img6.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.Surgery;
            this.img6.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img6.StateCommon.Border.Width = 0;
            this.img6.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.Surgery;
            this.img6.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img6.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img6.StateNormal.Border.Width = 0;
            this.img6.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.Surgery;
            this.img6.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img6.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.img6.StatePressed.Border.Width = 0;
            this.img6.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.Surgery;
            this.img6.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.img6.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img6.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.img6.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.img6.StateTracking.Border.Rounding = 25;
            this.img6.StateTracking.Border.Width = 5;
            this.img6.TabIndex = 19;
            this.img6.TabStop = false;
            this.img6.Values.Text = "";
            this.img6.Click += new System.EventHandler(this.img6_Click);
            // 
            // Logout
            // 
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Logout.Location = new System.Drawing.Point(953, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(43, 42);
            this.Logout.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.Logout;
            this.Logout.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.Logout.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.Logout.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Logout.StateDisabled.Border.Rounding = 25;
            this.Logout.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.Logout;
            this.Logout.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.Logout.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Logout.StateNormal.Border.Rounding = 25;
            this.Logout.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.Logout;
            this.Logout.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Logout.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Logout.StatePressed.Border.Rounding = 25;
            this.Logout.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.Logout;
            this.Logout.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Logout.StateTracking.Border.Rounding = 25;
            this.Logout.TabIndex = 21;
            this.Logout.Values.Text = "";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            this.Logout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Logout_MouseMove);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Desktop___1Patient_Bg;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Surgery);
            this.Controls.Add(this.img6);
            this.Controls.Add(this.Organs);
            this.Controls.Add(this.Family);
            this.Controls.Add(this.Pharmacy);
            this.Controls.Add(this.Labs);
            this.Controls.Add(this.Hospital);
            this.Controls.Add(this.EditUserDetails);
            this.Controls.Add(this.img5);
            this.Controls.Add(this.img4);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Blood);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Hello);
            this.Controls.Add(this.Avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton img1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton img2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton img3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton img4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton img5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton EditUserDetails;
        private System.Windows.Forms.Label Hospital;
        private System.Windows.Forms.Label Labs;
        private System.Windows.Forms.Label Pharmacy;
        private System.Windows.Forms.Label Family;
        private System.Windows.Forms.Label Organs;
        private System.Windows.Forms.Label Surgery;
        private ComponentFactory.Krypton.Toolkit.KryptonButton img6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Logout;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}