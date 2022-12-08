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
            this.Avatar.Location = new System.Drawing.Point(91, 39);
            this.Avatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(193, 178);
            this.Avatar.TabIndex = 0;
            this.Avatar.TabStop = false;
            this.Avatar.Click += new System.EventHandler(this.Avatar_Click);
            // 
            // Hello
            // 
            this.Hello.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.Hello.Location = new System.Drawing.Point(292, 39);
            this.Hello.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(514, 78);
            this.Hello.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Hello.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Hello.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hello.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Hello.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.Hello.TabIndex = 1;
            this.Hello.Values.Text = "Hello UserName!";
            this.Hello.Paint += new System.Windows.Forms.PaintEventHandler(this.Hello_Paint);
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(299, 107);
            this.Gender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(179, 35);
            this.Gender.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Gender.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Gender.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Gender.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.Gender.TabIndex = 2;
            this.Gender.Values.Text = "Gender: Male";
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(299, 138);
            this.Birthday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(265, 35);
            this.Birthday.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Birthday.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Birthday.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Birthday.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.Birthday.TabIndex = 3;
            this.Birthday.Values.Text = "Birthday: 29/04/2002";
            // 
            // Blood
            // 
            this.Blood.Location = new System.Drawing.Point(299, 171);
            this.Blood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Blood.Name = "Blood";
            this.Blood.Size = new System.Drawing.Size(185, 35);
            this.Blood.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Blood.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Blood.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blood.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Blood.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.Blood.TabIndex = 4;
            this.Blood.Values.Text = "Blood Type: A";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(645, 138);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(435, 35);
            this.Email.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Email.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Email.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Email.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.Email.TabIndex = 6;
            this.Email.Values.Text = "Email: fares.h.moneim@gmail.com";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(645, 107);
            this.Phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(296, 35);
            this.Phone.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.Phone.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.Phone.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Phone.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.Phone.TabIndex = 5;
            this.Phone.Values.Text = "Phone #: 01117997474";
            // 
            // Hospital
            // 
            this.Hospital.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hospital.Location = new System.Drawing.Point(219, 254);
            this.Hospital.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Hospital.Name = "Hospital";
            this.Hospital.Size = new System.Drawing.Size(172, 159);
            this.Hospital.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.Hospital.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Hospital.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Hospital.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Hospital.StateCommon.Border.Width = 0;
            this.Hospital.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Hospital.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.Hospital.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Hospital.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Hospital.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Hospital.StateNormal.Border.Width = 0;
            this.Hospital.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.Hospital.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Hospital.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Hospital.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Hospital.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Hospital.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Hospital.StatePressed.Border.Rounding = 25;
            this.Hospital.StatePressed.Border.Width = 5;
            this.Hospital.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.Hospital.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Hospital.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Hospital.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Hospital.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Hospital.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.Labs.Location = new System.Drawing.Point(453, 267);
            this.Labs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Labs.Name = "Labs";
            this.Labs.Size = new System.Drawing.Size(153, 142);
            this.Labs.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Labs.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Labs.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.Lab;
            this.Labs.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Labs.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Labs.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Labs.StateCommon.Border.Width = 0;
            this.Labs.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.Lab;
            this.Labs.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Labs.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Labs.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Labs.StateNormal.Border.Width = 0;
            this.Labs.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.Lab;
            this.Labs.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Labs.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Labs.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Labs.StatePressed.Border.Width = 0;
            this.Labs.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.Lab;
            this.Labs.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Labs.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Labs.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Labs.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Labs.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.Pharmacy.Location = new System.Drawing.Point(633, 271);
            this.Pharmacy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pharmacy.Name = "Pharmacy";
            this.Pharmacy.Size = new System.Drawing.Size(153, 142);
            this.Pharmacy.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Pharmacy.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Pharmacy.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharma;
            this.Pharmacy.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Pharmacy.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Pharmacy.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Pharmacy.StateCommon.Border.Width = 0;
            this.Pharmacy.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharma;
            this.Pharmacy.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Pharmacy.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Pharmacy.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Pharmacy.StateNormal.Border.Width = 0;
            this.Pharmacy.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharma;
            this.Pharmacy.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Pharmacy.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Pharmacy.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Pharmacy.StatePressed.Border.Width = 0;
            this.Pharmacy.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharma;
            this.Pharmacy.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Pharmacy.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Pharmacy.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Pharmacy.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Pharmacy.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.Family.Location = new System.Drawing.Point(817, 271);
            this.Family.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Family.Name = "Family";
            this.Family.Size = new System.Drawing.Size(153, 142);
            this.Family.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Family.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Family.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources._2770519;
            this.Family.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Family.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Family.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Family.StateCommon.Border.Width = 0;
            this.Family.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.Family;
            this.Family.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Family.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Family.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Family.StateNormal.Border.Width = 0;
            this.Family.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.Family;
            this.Family.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Family.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Family.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Family.StatePressed.Border.Width = 0;
            this.Family.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.Family;
            this.Family.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Family.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Family.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Family.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Family.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.Organs.Location = new System.Drawing.Point(999, 292);
            this.Organs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Organs.Name = "Organs";
            this.Organs.Size = new System.Drawing.Size(153, 121);
            this.Organs.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.Organs.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.Organs.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.organs;
            this.Organs.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Organs.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Organs.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Organs.StateCommon.Border.Width = 0;
            this.Organs.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.organs;
            this.Organs.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Organs.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Organs.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Organs.StateNormal.Border.Width = 0;
            this.Organs.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.organs;
            this.Organs.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Organs.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Organs.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.Organs.StatePressed.Border.Width = 0;
            this.Organs.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.organs;
            this.Organs.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Organs.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Organs.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.Organs.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Organs.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.EditUserDetails.Location = new System.Drawing.Point(837, 44);
            this.EditUserDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditUserDetails.Name = "EditUserDetails";
            this.EditUserDetails.Size = new System.Drawing.Size(67, 62);
            this.EditUserDetails.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.EditUserDetails.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.EditUserDetails.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.edit;
            this.EditUserDetails.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.EditUserDetails.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EditUserDetails.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.EditUserDetails.StateCommon.Border.Width = 0;
            this.EditUserDetails.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.EditUserDetails.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.EditUserDetails.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.edit;
            this.EditUserDetails.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.EditUserDetails.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EditUserDetails.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.EditUserDetails.StateNormal.Border.Width = 0;
            this.EditUserDetails.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.edit;
            this.EditUserDetails.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.EditUserDetails.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EditUserDetails.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.EditUserDetails.StatePressed.Border.Width = 0;
            this.EditUserDetails.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.EditUserDetails.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Desktop___1Patient_Bg;
            this.ClientSize = new System.Drawing.Size(1344, 897);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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