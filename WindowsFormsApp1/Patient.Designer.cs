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
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.Hello = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Gender = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Hospital = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
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
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(224, 112);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(234, 31);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Birthday: 29/04/2002";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(224, 139);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(157, 31);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Blodd Type: A";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(484, 112);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(362, 31);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "Email: fares.h.moneim@gmail.com";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(484, 87);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(245, 31);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel4.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 5;
            this.kryptonLabel4.Values.Text = "Phone #: 01117997474";
            this.kryptonLabel4.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel4_Paint);
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
            this.Hospital.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.Hospital.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Hospital.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Hospital.StateNormal.Border.Width = 0;
            this.Hospital.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.Hospital.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Hospital.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Hospital.StatePressed.Border.Width = 0;
            this.Hospital.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.Hospital.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.Hospital.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.Hospital.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.Hospital.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Hospital.StateTracking.Border.Width = 0;
            this.Hospital.TabIndex = 7;
            this.Hospital.Values.Text = "";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton2.Location = new System.Drawing.Point(340, 220);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(95, 95);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton2.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Width = 0;
            this.kryptonButton2.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources._78524;
            this.kryptonButton2.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton2.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateNormal.Border.Width = 0;
            this.kryptonButton2.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources._78524;
            this.kryptonButton2.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton2.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StatePressed.Border.Width = 0;
            this.kryptonButton2.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources._78524;
            this.kryptonButton2.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton2.TabIndex = 8;
            this.kryptonButton2.Values.Text = "";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton3.Location = new System.Drawing.Point(482, 225);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(84, 90);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton3.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources._33777;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Width = 0;
            this.kryptonButton3.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharmacy_icon1;
            this.kryptonButton3.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton3.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateNormal.Border.Width = 0;
            this.kryptonButton3.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharmacy_icon;
            this.kryptonButton3.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton3.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StatePressed.Border.Width = 0;
            this.kryptonButton3.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.pharmacy_icon;
            this.kryptonButton3.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton3.TabIndex = 9;
            this.kryptonButton3.Values.Text = "";
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton4.Location = new System.Drawing.Point(613, 227);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(88, 88);
            this.kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton4.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources._2770519;
            this.kryptonButton4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StateCommon.Border.Width = 0;
            this.kryptonButton4.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources._2770519;
            this.kryptonButton4.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton4.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StateNormal.Border.Width = 0;
            this.kryptonButton4.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources._2770519;
            this.kryptonButton4.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton4.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StatePressed.Border.Width = 0;
            this.kryptonButton4.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources._2770519;
            this.kryptonButton4.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton4.TabIndex = 10;
            this.kryptonButton4.Values.Text = "";
            // 
            // kryptonButton5
            // 
            this.kryptonButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton5.Location = new System.Drawing.Point(748, 220);
            this.kryptonButton5.Name = "kryptonButton5";
            this.kryptonButton5.Size = new System.Drawing.Size(111, 95);
            this.kryptonButton5.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton5.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources._2770519;
            this.kryptonButton5.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton5.StateCommon.Border.Width = 0;
            this.kryptonButton5.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.Kidneys_and_liver_icons_svg;
            this.kryptonButton5.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton5.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton5.StateNormal.Border.Width = 0;
            this.kryptonButton5.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.Kidneys_and_liver_icons_svg;
            this.kryptonButton5.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton5.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton5.StatePressed.Border.Width = 0;
            this.kryptonButton5.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.Kidneys_and_liver_icons_svg;
            this.kryptonButton5.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonButton5.TabIndex = 11;
            this.kryptonButton5.Values.Text = "";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(134, 341);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(741, 365);
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateNormal.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Desktop___1Patient_Bg;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.kryptonButton5);
            this.Controls.Add(this.kryptonButton4);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.Hospital);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Hello);
            this.Controls.Add(this.Avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Avatar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Hello;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Gender;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Hospital;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton5;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}