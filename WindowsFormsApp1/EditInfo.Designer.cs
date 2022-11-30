namespace WindowsFormsApp1
{
    partial class EditInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInfo));
            this.Submit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.First_Name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Last_Name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Gender = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Birth_day = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.Blood_type = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Phone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Emergency_Contact = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Chronic = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Pass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Pass2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.firstnameerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.lastnameerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.submiterror = new System.Windows.Forms.ErrorProvider(this.components);
            this.iderror = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.emergencyerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.chronicerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.passerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.pass2error = new System.Windows.Forms.ErrorProvider(this.components);
            this.gendererror = new System.Windows.Forms.ErrorProvider(this.components);
            this.blooderror = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Gender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blood_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnameerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastnameerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submiterror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iderror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronicerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass2error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendererror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blooderror)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Submit, "Submit");
            this.Submit.Name = "Submit";
            this.Submit.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.Login_Button;
            this.Submit.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.Submit.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.Submit.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StateDisabled.Border.Rounding = 25;
            this.Submit.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.Save_ButtonSUBMIT;
            this.Submit.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StateNormal.Border.Rounding = 25;
            this.Submit.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.Save_ButtonSUBMIT;
            this.Submit.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StatePressed.Border.Rounding = 25;
            this.Submit.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.Save_ButtonSUBMIT;
            this.Submit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StateTracking.Border.Rounding = 25;
            this.Submit.Values.Text = resources.GetString("Submit.Values.Text");
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.kryptonButton1, "kryptonButton1");
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.Login_Button;
            this.kryptonButton1.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateDisabled.Border.Rounding = 25;
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.Cancel_Button;
            this.kryptonButton1.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.kryptonButton1.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Border.Rounding = 25;
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.Cancel_Button;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 25;
            this.kryptonButton1.StateTracking.Back.Image = global::WindowsFormsApp1.Properties.Resources.Cancel_Button;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.Rounding = 25;
            this.kryptonButton1.Values.Text = resources.GetString("kryptonButton1.Values.Text");
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // First_Name
            // 
            resources.ApplyResources(this.First_Name, "First_Name");
            this.First_Name.Name = "First_Name";
            this.First_Name.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.First_Name.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.First_Name.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.First_Name.StateNormal.Border.Width = 2;
            this.First_Name.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.First_Name.TextChanged += new System.EventHandler(this.First_Name_TextChanged);
            this.First_Name.Validating += new System.ComponentModel.CancelEventHandler(this.First_Name_Validating);
            // 
            // Last_Name
            // 
            resources.ApplyResources(this.Last_Name, "Last_Name");
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Last_Name.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.Last_Name.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Last_Name.StateNormal.Border.Width = 2;
            this.Last_Name.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.Last_Name.Validated += new System.EventHandler(this.Last_Name_Validated);
            // 
            // ID
            // 
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.ID.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.ID.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ID.StateNormal.Border.Width = 2;
            this.ID.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.ID.Validating += new System.ComponentModel.CancelEventHandler(this.ID_Validating);
            // 
            // Gender
            // 
            this.Gender.DropDownWidth = 24;
            this.Gender.Items.AddRange(new object[] {
            resources.GetString("Gender.Items"),
            resources.GetString("Gender.Items1")});
            resources.ApplyResources(this.Gender, "Gender");
            this.Gender.Name = "Gender";
            this.Gender.Validating += new System.ComponentModel.CancelEventHandler(this.Gender_Validating);
            // 
            // Birth_day
            // 
            resources.ApplyResources(this.Birth_day, "Birth_day");
            this.Birth_day.Name = "Birth_day";
            // 
            // Blood_type
            // 
            this.Blood_type.DropDownWidth = 21;
            this.Blood_type.Items.AddRange(new object[] {
            resources.GetString("Blood_type.Items"),
            resources.GetString("Blood_type.Items1"),
            resources.GetString("Blood_type.Items2"),
            resources.GetString("Blood_type.Items3")});
            resources.ApplyResources(this.Blood_type, "Blood_type");
            this.Blood_type.Name = "Blood_type";
            this.Blood_type.Validated += new System.EventHandler(this.Blood_type_Validated);
            // 
            // Phone
            // 
            resources.ApplyResources(this.Phone, "Phone");
            this.Phone.Name = "Phone";
            this.Phone.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Phone.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.Phone.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Phone.StateNormal.Border.Width = 2;
            this.Phone.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.Phone.Validated += new System.EventHandler(this.Phone_Validated);
            // 
            // Emergency_Contact
            // 
            resources.ApplyResources(this.Emergency_Contact, "Emergency_Contact");
            this.Emergency_Contact.Name = "Emergency_Contact";
            this.Emergency_Contact.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Emergency_Contact.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.Emergency_Contact.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Emergency_Contact.StateNormal.Border.Width = 2;
            this.Emergency_Contact.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.Emergency_Contact.Validated += new System.EventHandler(this.Emergency_Contact_Validated);
            // 
            // Chronic
            // 
            resources.ApplyResources(this.Chronic, "Chronic");
            this.Chronic.Name = "Chronic";
            this.Chronic.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Chronic.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.Chronic.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Chronic.StateNormal.Border.Width = 2;
            this.Chronic.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            // 
            // Email
            // 
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
            this.Email.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Email.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.Email.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Email.StateNormal.Border.Width = 2;
            this.Email.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.Email.Validated += new System.EventHandler(this.Email_Validated);
            // 
            // Pass
            // 
            resources.ApplyResources(this.Pass, "Pass");
            this.Pass.Name = "Pass";
            this.Pass.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Pass.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.Pass.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Pass.StateNormal.Border.Width = 2;
            this.Pass.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.Pass.Validated += new System.EventHandler(this.Pass_Validated);
            // 
            // Pass2
            // 
            resources.ApplyResources(this.Pass2, "Pass2");
            this.Pass2.Name = "Pass2";
            this.Pass2.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Pass2.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.Pass2.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Pass2.StateNormal.Border.Width = 2;
            this.Pass2.StateNormal.Content.Color1 = System.Drawing.Color.Black;
            this.Pass2.Validated += new System.EventHandler(this.Pass2_Validated);
            // 
            // firstnameerror
            // 
            this.firstnameerror.BlinkRate = 0;
            this.firstnameerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.firstnameerror.ContainerControl = this;
            resources.ApplyResources(this.firstnameerror, "firstnameerror");
            // 
            // lastnameerror
            // 
            this.lastnameerror.BlinkRate = 0;
            this.lastnameerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.lastnameerror.ContainerControl = this;
            resources.ApplyResources(this.lastnameerror, "lastnameerror");
            // 
            // submiterror
            // 
            this.submiterror.BlinkRate = 0;
            this.submiterror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.submiterror.ContainerControl = this;
            resources.ApplyResources(this.submiterror, "submiterror");
            // 
            // iderror
            // 
            this.iderror.BlinkRate = 0;
            this.iderror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.iderror.ContainerControl = this;
            resources.ApplyResources(this.iderror, "iderror");
            // 
            // phoneerror
            // 
            this.phoneerror.BlinkRate = 0;
            this.phoneerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.phoneerror.ContainerControl = this;
            resources.ApplyResources(this.phoneerror, "phoneerror");
            // 
            // emergencyerror
            // 
            this.emergencyerror.BlinkRate = 0;
            this.emergencyerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.emergencyerror.ContainerControl = this;
            resources.ApplyResources(this.emergencyerror, "emergencyerror");
            // 
            // chronicerror
            // 
            this.chronicerror.BlinkRate = 0;
            this.chronicerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.chronicerror.ContainerControl = this;
            resources.ApplyResources(this.chronicerror, "chronicerror");
            // 
            // emailerror
            // 
            this.emailerror.BlinkRate = 0;
            this.emailerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.emailerror.ContainerControl = this;
            resources.ApplyResources(this.emailerror, "emailerror");
            // 
            // passerror
            // 
            this.passerror.BlinkRate = 0;
            this.passerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.passerror.ContainerControl = this;
            resources.ApplyResources(this.passerror, "passerror");
            // 
            // pass2error
            // 
            this.pass2error.BlinkRate = 0;
            this.pass2error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.pass2error.ContainerControl = this;
            resources.ApplyResources(this.pass2error, "pass2error");
            // 
            // gendererror
            // 
            this.gendererror.BlinkRate = 0;
            this.gendererror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.gendererror.ContainerControl = this;
            resources.ApplyResources(this.gendererror, "gendererror");
            // 
            // blooderror
            // 
            this.blooderror.BlinkRate = 0;
            this.blooderror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.blooderror.ContainerControl = this;
            // 
            // EditInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Edit_Form_Bg;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.Pass2);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Chronic);
            this.Controls.Add(this.Emergency_Contact);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Blood_type);
            this.Controls.Add(this.Birth_day);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.Submit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.EditInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blood_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnameerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastnameerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submiterror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iderror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronicerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass2error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendererror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blooderror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton Submit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox First_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Last_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ID;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Gender;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker Birth_day;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Blood_type;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Phone;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Emergency_Contact;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Chronic;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Email;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Pass;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Pass2;
        private System.Windows.Forms.ErrorProvider firstnameerror;
        private System.Windows.Forms.ErrorProvider lastnameerror;
        private System.Windows.Forms.ErrorProvider submiterror;
        private System.Windows.Forms.ErrorProvider iderror;
        private System.Windows.Forms.ErrorProvider phoneerror;
        private System.Windows.Forms.ErrorProvider emergencyerror;
        private System.Windows.Forms.ErrorProvider chronicerror;
        private System.Windows.Forms.ErrorProvider emailerror;
        private System.Windows.Forms.ErrorProvider passerror;
        private System.Windows.Forms.ErrorProvider pass2error;
        private System.Windows.Forms.ErrorProvider gendererror;
        private System.Windows.Forms.ErrorProvider blooderror;
    }
}