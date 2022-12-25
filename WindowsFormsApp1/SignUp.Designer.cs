using System.Drawing;

namespace WindowsFormsApp1
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.First_Name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Last_Name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Birth_day = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.Phone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Emergency_Contact = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Chronic = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Pass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Pass2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Submit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Gender = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Blood_type = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBox2 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.firstnameerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.lastnameerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.iderror = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.emergencyerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.chronicerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.passerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.pass2error = new System.Windows.Forms.ErrorProvider(this.components);
            this.gendererror = new System.Windows.Forms.ErrorProvider(this.components);
            this.blooderror = new System.Windows.Forms.ErrorProvider(this.components);
            this.submiterror = new System.Windows.Forms.ErrorProvider(this.components);
            this.SignIn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.Gender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blood_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnameerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastnameerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iderror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronicerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass2error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendererror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blooderror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submiterror)).BeginInit();
            this.SuspendLayout();
            // 
            // First_Name
            // 
            this.First_Name.Location = new System.Drawing.Point(629, 157);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(135, 22);
            this.First_Name.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.First_Name.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            this.First_Name.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.First_Name.StateNormal.Border.Width = 2;
            this.First_Name.StateNormal.Content.Color1 = System.Drawing.Color.LightGray;
            this.First_Name.TabIndex = 0;
            this.First_Name.Text = "First Name";
            this.First_Name.Enter += new System.EventHandler(this.First_Name_Enter);
            this.First_Name.Leave += new System.EventHandler(this.First_Name_Leave);
            this.First_Name.Validating += new System.ComponentModel.CancelEventHandler(this.First_Name_Validating);
            // 
            // Last_Name
            // 
            this.Last_Name.Location = new System.Drawing.Point(786, 155);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(139, 22);
            this.Last_Name.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Last_Name.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            this.Last_Name.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Last_Name.StateNormal.Border.Width = 2;
            this.Last_Name.StateNormal.Content.Color1 = System.Drawing.Color.LightGray;
            this.Last_Name.TabIndex = 1;
            this.Last_Name.Text = "Last Name";
            this.Last_Name.Enter += new System.EventHandler(this.Last_Name_Enter);
            this.Last_Name.Leave += new System.EventHandler(this.Last_Name_Leave);
            this.Last_Name.Validated += new System.EventHandler(this.Last_Name_Validated);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(629, 219);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(296, 22);
            this.ID.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.ID.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            this.ID.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ID.StateNormal.Border.Width = 2;
            this.ID.StateNormal.Content.Color1 = System.Drawing.Color.LightGray;
            this.ID.TabIndex = 2;
            this.ID.Text = "ID (16 Numbers)";
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            this.ID.Enter += new System.EventHandler(this.ID_Enter);
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            this.ID.Leave += new System.EventHandler(this.ID_Leave);
            this.ID.Validating += new System.ComponentModel.CancelEventHandler(this.ID_Validating);
            // 
            // Birth_day
            // 
            this.Birth_day.Location = new System.Drawing.Point(737, 284);
            this.Birth_day.Name = "Birth_day";
            this.Birth_day.Size = new System.Drawing.Size(75, 21);
            this.Birth_day.TabIndex = 5;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(629, 344);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(296, 22);
            this.Phone.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Phone.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            this.Phone.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Phone.StateNormal.Border.Width = 2;
            this.Phone.StateNormal.Content.Color1 = System.Drawing.Color.LightGray;
            this.Phone.TabIndex = 7;
            this.Phone.Text = "Phone Number (+20 XXX XXX XXXX)";
            this.Phone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            this.Phone.Enter += new System.EventHandler(this.Phone_Enter);
            this.Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_KeyPress);
            this.Phone.Leave += new System.EventHandler(this.Phone_Leave);
            this.Phone.Validated += new System.EventHandler(this.Phone_Validated);
            // 
            // Emergency_Contact
            // 
            this.Emergency_Contact.Location = new System.Drawing.Point(629, 382);
            this.Emergency_Contact.Name = "Emergency_Contact";
            this.Emergency_Contact.Size = new System.Drawing.Size(296, 22);
            this.Emergency_Contact.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Emergency_Contact.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            this.Emergency_Contact.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Emergency_Contact.StateNormal.Border.Width = 2;
            this.Emergency_Contact.StateNormal.Content.Color1 = System.Drawing.Color.LightGray;
            this.Emergency_Contact.TabIndex = 8;
            this.Emergency_Contact.Text = "Emergency Contact (+20 XXX XXX XXXX)";
            this.Emergency_Contact.TextChanged += new System.EventHandler(this.Emergency_Contact_TextChanged);
            this.Emergency_Contact.Enter += new System.EventHandler(this.Emergency_Contact_Enter);
            this.Emergency_Contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Emergency_Contact_KeyPress);
            this.Emergency_Contact.Leave += new System.EventHandler(this.Emergency_Contact_Leave);
            this.Emergency_Contact.Validated += new System.EventHandler(this.Emergency_Contact_Validated);
            // 
            // Chronic
            // 
            this.Chronic.Location = new System.Drawing.Point(629, 445);
            this.Chronic.Name = "Chronic";
            this.Chronic.Size = new System.Drawing.Size(296, 22);
            this.Chronic.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Chronic.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            this.Chronic.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Chronic.StateNormal.Border.Width = 2;
            this.Chronic.StateNormal.Content.Color1 = System.Drawing.Color.LightGray;
            this.Chronic.TabIndex = 9;
            this.Chronic.Text = "Chronic Diseases (Comma Separated)";
            this.Chronic.Enter += new System.EventHandler(this.Chronic_Enter);
            this.Chronic.Leave += new System.EventHandler(this.Chronic_Leave);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(629, 510);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(296, 22);
            this.Email.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Email.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            this.Email.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Email.StateNormal.Border.Width = 2;
            this.Email.StateNormal.Content.Color1 = System.Drawing.Color.LightGray;
            this.Email.TabIndex = 10;
            this.Email.Text = "Email (example@email.com)";
            this.Email.Enter += new System.EventHandler(this.Email_Enter);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            this.Email.Validated += new System.EventHandler(this.Email_Validated);
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(629, 538);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(296, 22);
            this.Pass.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Pass.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            this.Pass.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Pass.StateNormal.Border.Width = 2;
            this.Pass.StateNormal.Content.Color1 = System.Drawing.Color.LightGray;
            this.Pass.TabIndex = 12;
            this.Pass.Text = "Password";
            this.Pass.Enter += new System.EventHandler(this.Pass_Enter);
            this.Pass.Leave += new System.EventHandler(this.Pass_Leave);
            this.Pass.Validated += new System.EventHandler(this.Pass_Validated);
            // 
            // Pass2
            // 
            this.Pass2.Location = new System.Drawing.Point(629, 566);
            this.Pass2.Name = "Pass2";
            this.Pass2.Size = new System.Drawing.Size(296, 22);
            this.Pass2.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Pass2.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            this.Pass2.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Pass2.StateNormal.Border.Width = 2;
            this.Pass2.StateNormal.Content.Color1 = System.Drawing.Color.LightGray;
            this.Pass2.TabIndex = 13;
            this.Pass2.Text = "Re-enter Password";
            this.Pass2.Enter += new System.EventHandler(this.Pass2_Enter);
            this.Pass2.Leave += new System.EventHandler(this.Pass2_Leave);
            this.Pass2.Validated += new System.EventHandler(this.Pass2_Validated);
            // 
            // Submit
            // 
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.Location = new System.Drawing.Point(697, 600);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(157, 42);
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
            this.Submit.TabIndex = 14;
            this.Submit.Values.Image = global::WindowsFormsApp1.Properties.Resources.SUBMIT;
            this.Submit.Values.Text = "";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            this.Submit.Validating += new System.ComponentModel.CancelEventHandler(this.Submit_Validating);
            // 
            // Gender
            // 
            this.Gender.DropDownWidth = 24;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(629, 284);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(72, 21);
            this.Gender.TabIndex = 15;
            this.Gender.Text = "Gender";
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.Gender_SelectedIndexChanged);
            this.Gender.Validating += new System.ComponentModel.CancelEventHandler(this.Gender_Validating);
            // 
            // Blood_type
            // 
            this.Blood_type.DropDownWidth = 21;
            this.Blood_type.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.Blood_type.Location = new System.Drawing.Point(840, 284);
            this.Blood_type.Name = "Blood_type";
            this.Blood_type.Size = new System.Drawing.Size(85, 21);
            this.Blood_type.TabIndex = 16;
            this.Blood_type.Text = "Blood Type";
            this.Blood_type.Validated += new System.EventHandler(this.Blood_type_Validated);
            // 
            // kryptonComboBox2
            // 
            this.kryptonComboBox2.DropDownWidth = 121;
            this.kryptonComboBox2.Location = new System.Drawing.Point(1556, 738);
            this.kryptonComboBox2.Name = "kryptonComboBox2";
            this.kryptonComboBox2.Size = new System.Drawing.Size(121, 21);
            this.kryptonComboBox2.TabIndex = 17;
            this.kryptonComboBox2.Text = "kryptonComboBox2";
            // 
            // firstnameerror
            // 
            this.firstnameerror.BlinkRate = 0;
            this.firstnameerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.firstnameerror.ContainerControl = this;
            this.firstnameerror.Icon = ((System.Drawing.Icon)(resources.GetObject("firstnameerror.Icon")));
            // 
            // lastnameerror
            // 
            this.lastnameerror.BlinkRate = 0;
            this.lastnameerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.lastnameerror.ContainerControl = this;
            this.lastnameerror.Icon = ((System.Drawing.Icon)(resources.GetObject("lastnameerror.Icon")));
            // 
            // iderror
            // 
            this.iderror.BlinkRate = 0;
            this.iderror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.iderror.ContainerControl = this;
            this.iderror.Icon = ((System.Drawing.Icon)(resources.GetObject("iderror.Icon")));
            // 
            // phoneerror
            // 
            this.phoneerror.BlinkRate = 0;
            this.phoneerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.phoneerror.ContainerControl = this;
            this.phoneerror.Icon = ((System.Drawing.Icon)(resources.GetObject("phoneerror.Icon")));
            // 
            // emergencyerror
            // 
            this.emergencyerror.BlinkRate = 0;
            this.emergencyerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.emergencyerror.ContainerControl = this;
            this.emergencyerror.Icon = ((System.Drawing.Icon)(resources.GetObject("emergencyerror.Icon")));
            // 
            // chronicerror
            // 
            this.chronicerror.BlinkRate = 0;
            this.chronicerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.chronicerror.ContainerControl = this;
            this.chronicerror.Icon = ((System.Drawing.Icon)(resources.GetObject("chronicerror.Icon")));
            // 
            // emailerror
            // 
            this.emailerror.BlinkRate = 0;
            this.emailerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.emailerror.ContainerControl = this;
            this.emailerror.Icon = ((System.Drawing.Icon)(resources.GetObject("emailerror.Icon")));
            // 
            // passerror
            // 
            this.passerror.BlinkRate = 0;
            this.passerror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.passerror.ContainerControl = this;
            this.passerror.Icon = ((System.Drawing.Icon)(resources.GetObject("passerror.Icon")));
            // 
            // pass2error
            // 
            this.pass2error.BlinkRate = 0;
            this.pass2error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.pass2error.ContainerControl = this;
            this.pass2error.Icon = ((System.Drawing.Icon)(resources.GetObject("pass2error.Icon")));
            // 
            // gendererror
            // 
            this.gendererror.BlinkRate = 0;
            this.gendererror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.gendererror.ContainerControl = this;
            this.gendererror.Icon = ((System.Drawing.Icon)(resources.GetObject("gendererror.Icon")));
            // 
            // blooderror
            // 
            this.blooderror.BlinkRate = 0;
            this.blooderror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.blooderror.ContainerControl = this;
            // 
            // submiterror
            // 
            this.submiterror.BlinkRate = 0;
            this.submiterror.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.submiterror.ContainerControl = this;
            this.submiterror.Icon = ((System.Drawing.Icon)(resources.GetObject("submiterror.Icon")));
            // 
            // SignIn
            // 
            this.SignIn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn.Location = new System.Drawing.Point(666, 644);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(228, 29);
            this.SignIn.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.SignIn.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.SignIn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.SignIn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.SignIn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignIn.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.SignIn.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.SignIn.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.SignIn.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.SignIn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignIn.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.SignIn.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.SignIn.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.SignIn.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.SignIn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignIn.TabIndex = 18;
            this.SignIn.Values.Text = "Already Have an Account? Sign In Here.";
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.kryptonComboBox2);
            this.Controls.Add(this.Blood_type);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Pass2);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Chronic);
            this.Controls.Add(this.Emergency_Contact);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Birth_day);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.First_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Electronic Healthcare Records";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blood_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnameerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastnameerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iderror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronicerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass2error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendererror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blooderror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submiterror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox First_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Last_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ID;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker Birth_day;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Phone;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Emergency_Contact;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Chronic;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Email;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Pass;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Pass2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Submit;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Gender;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Blood_type;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private System.Windows.Forms.ErrorProvider firstnameerror;
        private System.Windows.Forms.ErrorProvider lastnameerror;
        private System.Windows.Forms.ErrorProvider iderror;
        private System.Windows.Forms.ErrorProvider phoneerror;
        private System.Windows.Forms.ErrorProvider emergencyerror;
        private System.Windows.Forms.ErrorProvider chronicerror;
        private System.Windows.Forms.ErrorProvider emailerror;
        private System.Windows.Forms.ErrorProvider passerror;
        private System.Windows.Forms.ErrorProvider pass2error;
        private System.Windows.Forms.ErrorProvider gendererror;
        private System.Windows.Forms.ErrorProvider blooderror;
        private System.Windows.Forms.ErrorProvider submiterror;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SignIn;
    }
}

