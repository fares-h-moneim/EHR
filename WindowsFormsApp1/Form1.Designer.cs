namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Blood_type = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBox2 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.firstnameerror = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blood_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnameerror)).BeginInit();
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
            this.ID.TextChanged += new System.EventHandler(this.kryptonTextBox2_TextChanged);
            this.ID.Enter += new System.EventHandler(this.ID_Enter);
            this.ID.Leave += new System.EventHandler(this.ID_Leave);
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
            this.Phone.Leave += new System.EventHandler(this.Phone_Leave);
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
            this.Emergency_Contact.TextChanged += new System.EventHandler(this.kryptonTextBox4_TextChanged);
            this.Emergency_Contact.Enter += new System.EventHandler(this.Emergency_Contact_Enter);
            this.Emergency_Contact.Leave += new System.EventHandler(this.Emergency_Contact_Leave);
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
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(697, 605);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(157, 42);
            this.kryptonButton1.StateCommon.Back.Image = global::WindowsFormsApp1.Properties.Resources.SUBMIT;
            this.kryptonButton1.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateDisabled.Border.Rounding = 25;
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StateNormal.Back.Image = global::WindowsFormsApp1.Properties.Resources.SUBMIT;
            this.kryptonButton1.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Border.Rounding = 25;
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StatePressed.Back.Image = global::WindowsFormsApp1.Properties.Resources.SUBMIT;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 25;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.Rounding = 25;
            this.kryptonButton1.TabIndex = 14;
            this.kryptonButton1.Values.Image = global::WindowsFormsApp1.Properties.Resources.SUBMIT;
            this.kryptonButton1.Values.Text = "";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 24;
            this.kryptonComboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.kryptonComboBox1.Location = new System.Drawing.Point(629, 284);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(72, 21);
            this.kryptonComboBox1.TabIndex = 15;
            this.kryptonComboBox1.Text = "Gender";
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
            this.firstnameerror.ContainerControl = this;
            this.firstnameerror.Icon = ((System.Drawing.Icon)(resources.GetObject("firstnameerror.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.kryptonComboBox2);
            this.Controls.Add(this.Blood_type);
            this.Controls.Add(this.kryptonComboBox1);
            this.Controls.Add(this.kryptonButton1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blood_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstnameerror)).EndInit();
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Blood_type;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private System.Windows.Forms.ErrorProvider firstnameerror;
    }
}

