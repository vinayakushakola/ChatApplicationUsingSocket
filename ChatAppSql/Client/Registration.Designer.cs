namespace Client
{
    partial class Registration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPassword = new JMetroTextBox.JMetroTextBox();
            this.textUserName = new JMetroTextBox.JMetroTextBox();
            this.textLastName = new JMetroTextBox.JMetroTextBox();
            this.textEmail = new JMetroTextBox.JMetroTextBox();
            this.textFirstName = new JMetroTextBox.JMetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSignUp = new JThinButton.JThinButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 92);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(330, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP";
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.Transparent;
            this.textPassword.BorderColor = System.Drawing.Color.Silver;
            this.textPassword.BorderRadius = 15;
            this.textPassword.FillColor = System.Drawing.Color.White;
            this.textPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Font_Size = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColors = System.Drawing.Color.Gray;
            this.textPassword.IsPassword = true;
            this.textPassword.LineThickness = 2;
            this.textPassword.Location = new System.Drawing.Point(71, 410);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPassword.MaxLength = 32767;
            this.textPassword.MouseOnHover = System.Drawing.Color.Empty;
            this.textPassword.Name = "textPassword";
            this.textPassword.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.OnFocusColor = System.Drawing.Color.Empty;
            this.textPassword.OnFocusFontColor = System.Drawing.Color.Empty;
            this.textPassword.ReadOnly = false;
            this.textPassword.Size = new System.Drawing.Size(208, 39);
            this.textPassword.TabIndex = 35;
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textPassword.TextName = "";
            // 
            // textUserName
            // 
            this.textUserName.BackColor = System.Drawing.Color.Transparent;
            this.textUserName.BorderColor = System.Drawing.Color.Silver;
            this.textUserName.BorderRadius = 15;
            this.textUserName.FillColor = System.Drawing.SystemColors.Window;
            this.textUserName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.Font_Size = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.ForeColors = System.Drawing.Color.Gray;
            this.textUserName.IsPassword = false;
            this.textUserName.LineThickness = 2;
            this.textUserName.Location = new System.Drawing.Point(71, 341);
            this.textUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUserName.MaxLength = 32767;
            this.textUserName.MouseOnHover = System.Drawing.Color.Empty;
            this.textUserName.Name = "textUserName";
            this.textUserName.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.textUserName.OnFocusColor = System.Drawing.Color.Empty;
            this.textUserName.OnFocusFontColor = System.Drawing.Color.Empty;
            this.textUserName.ReadOnly = false;
            this.textUserName.Size = new System.Drawing.Size(208, 39);
            this.textUserName.TabIndex = 34;
            this.textUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textUserName.TextName = "";
            // 
            // textLastName
            // 
            this.textLastName.BackColor = System.Drawing.Color.Transparent;
            this.textLastName.BorderColor = System.Drawing.Color.Silver;
            this.textLastName.BorderRadius = 15;
            this.textLastName.FillColor = System.Drawing.SystemColors.Window;
            this.textLastName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLastName.Font_Size = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLastName.ForeColors = System.Drawing.Color.Gray;
            this.textLastName.IsPassword = false;
            this.textLastName.LineThickness = 2;
            this.textLastName.Location = new System.Drawing.Point(71, 210);
            this.textLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textLastName.MaxLength = 32767;
            this.textLastName.MouseOnHover = System.Drawing.Color.Empty;
            this.textLastName.Name = "textLastName";
            this.textLastName.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.textLastName.OnFocusColor = System.Drawing.Color.Empty;
            this.textLastName.OnFocusFontColor = System.Drawing.Color.Empty;
            this.textLastName.ReadOnly = false;
            this.textLastName.Size = new System.Drawing.Size(208, 39);
            this.textLastName.TabIndex = 33;
            this.textLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textLastName.TextName = "";
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.Transparent;
            this.textEmail.BorderColor = System.Drawing.Color.Silver;
            this.textEmail.BorderRadius = 15;
            this.textEmail.FillColor = System.Drawing.SystemColors.Window;
            this.textEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Font_Size = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColors = System.Drawing.Color.Gray;
            this.textEmail.IsPassword = false;
            this.textEmail.LineThickness = 2;
            this.textEmail.Location = new System.Drawing.Point(71, 271);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEmail.MaxLength = 32767;
            this.textEmail.MouseOnHover = System.Drawing.Color.Empty;
            this.textEmail.Name = "textEmail";
            this.textEmail.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.textEmail.OnFocusColor = System.Drawing.Color.Empty;
            this.textEmail.OnFocusFontColor = System.Drawing.Color.Empty;
            this.textEmail.ReadOnly = false;
            this.textEmail.Size = new System.Drawing.Size(208, 39);
            this.textEmail.TabIndex = 32;
            this.textEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textEmail.TextName = "";
            // 
            // textFirstName
            // 
            this.textFirstName.BackColor = System.Drawing.Color.Transparent;
            this.textFirstName.BorderColor = System.Drawing.Color.Silver;
            this.textFirstName.BorderRadius = 15;
            this.textFirstName.FillColor = System.Drawing.SystemColors.Window;
            this.textFirstName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirstName.Font_Size = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirstName.ForeColors = System.Drawing.Color.Gray;
            this.textFirstName.IsPassword = false;
            this.textFirstName.LineThickness = 2;
            this.textFirstName.Location = new System.Drawing.Point(71, 147);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFirstName.MaxLength = 32767;
            this.textFirstName.MouseOnHover = System.Drawing.Color.Empty;
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.textFirstName.OnFocusColor = System.Drawing.Color.Empty;
            this.textFirstName.OnFocusFontColor = System.Drawing.Color.Empty;
            this.textFirstName.ReadOnly = false;
            this.textFirstName.Size = new System.Drawing.Size(208, 39);
            this.textFirstName.TabIndex = 31;
            this.textFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textFirstName.TextName = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(80, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 14);
            this.label6.TabIndex = 26;
            this.label6.Text = "EMAIL";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.btnSignUp.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSignUp.BorderRadius = 15;
            this.btnSignUp.ButtonText = "Sign Up";
            this.btnSignUp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColors = System.Drawing.SystemColors.HighlightText;
            this.btnSignUp.HoverBackground = System.Drawing.Color.White;
            this.btnSignUp.HoverBorder = System.Drawing.SystemColors.Highlight;
            this.btnSignUp.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnSignUp.LineThickness = 2;
            this.btnSignUp.Location = new System.Drawing.Point(126, 457);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(87, 33);
            this.btnSignUp.TabIndex = 30;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(80, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "LAST NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(80, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 28;
            this.label3.Text = "FIRST NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(81, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 25;
            this.label4.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(81, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "USER NAME";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 518);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private JMetroTextBox.JMetroTextBox textPassword;
        private JMetroTextBox.JMetroTextBox textUserName;
        private JMetroTextBox.JMetroTextBox textLastName;
        private JMetroTextBox.JMetroTextBox textEmail;
        private JMetroTextBox.JMetroTextBox textFirstName;
        private System.Windows.Forms.Label label6;
        private JThinButton.JThinButton btnSignUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}