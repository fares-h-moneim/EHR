namespace EHR_Admin
{
    partial class SignIn
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
            this.Email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Submit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(628, 341);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(300, 22);
            this.Email.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Email.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            this.Email.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Email.StateNormal.Content.Color1 = System.Drawing.Color.Silver;
            this.Email.TabIndex = 0;
            this.Email.Text = "Email (example@Email.com)";
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            this.Email.Enter += new System.EventHandler(this.Email_Enter);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            this.Email.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(628, 379);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(300, 22);
            this.Password.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Password.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            this.Password.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.Password.StateNormal.Content.Color1 = System.Drawing.Color.Silver;
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            this.Password.Validating += new System.ComponentModel.CancelEventHandler(this.Password_Validating);
            // 
            // Submit
            // 
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.Location = new System.Drawing.Point(689, 412);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(157, 42);
            this.Submit.StateCommon.Back.Image = global::EHR_Admin.Properties.Resources.Login_Button;
            this.Submit.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White;
            this.Submit.StateCommon.Content.LongText.Color2 = System.Drawing.Color.White;
            this.Submit.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StateDisabled.Border.Rounding = 25;
            this.Submit.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StateNormal.Back.Image = global::EHR_Admin.Properties.Resources.Login_Button;
            this.Submit.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StateNormal.Border.Rounding = 25;
            this.Submit.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StatePressed.Back.Image = global::EHR_Admin.Properties.Resources.Login_Button;
            this.Submit.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.Submit.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StatePressed.Border.Rounding = 25;
            this.Submit.StateTracking.Back.Image = global::EHR_Admin.Properties.Resources.Login_Button;
            this.Submit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StateTracking.Border.Rounding = 25;
            this.Submit.TabIndex = 16;
            this.Submit.Values.Text = "";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(687, 500);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(174, 20);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel1.StateNormal.ShortText.Color2 = System.Drawing.Color.Red;
            this.kryptonLabel1.TabIndex = 17;
            this.kryptonLabel1.Values.Text = "Invalid Username or Password";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(661, 457);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(228, 27);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateNormal.Border.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Border.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.TabIndex = 21;
            this.kryptonButton1.Values.Text = "Can\'t Remember Password? Click Here!";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EHR_Admin.Properties.Resources.Admin_SignIn;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignIn";
            this.Text = "Admin Login";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Email;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Password;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Submit;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}

