namespace Client
{
    partial class FormClient
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new JThinButton.JThinButton();
            this.textUserName = new JMetroTextBox.JMetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPassword = new JMetroTextBox.JMetroTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(108, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "SIGN IN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 81);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(315, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(72, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "USER NAME";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.btnLogin.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColors = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.HoverBackground = System.Drawing.Color.White;
            this.btnLogin.HoverBorder = System.Drawing.SystemColors.Highlight;
            this.btnLogin.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.LineThickness = 2;
            this.btnLogin.Location = new System.Drawing.Point(124, 252);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 33);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.textUserName.Location = new System.Drawing.Point(61, 137);
            this.textUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUserName.MaxLength = 32767;
            this.textUserName.MouseOnHover = System.Drawing.Color.Empty;
            this.textUserName.Name = "textUserName";
            this.textUserName.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.textUserName.OnFocusColor = System.Drawing.Color.Empty;
            this.textUserName.OnFocusFontColor = System.Drawing.Color.Empty;
            this.textUserName.ReadOnly = false;
            this.textUserName.Size = new System.Drawing.Size(208, 38);
            this.textUserName.TabIndex = 9;
            this.textUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textUserName.TextName = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(72, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "PASSWORD";
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
            this.textPassword.Location = new System.Drawing.Point(61, 206);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPassword.MaxLength = 32767;
            this.textPassword.MouseOnHover = System.Drawing.Color.Empty;
            this.textPassword.Name = "textPassword";
            this.textPassword.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.OnFocusColor = System.Drawing.Color.Empty;
            this.textPassword.OnFocusFontColor = System.Drawing.Color.Empty;
            this.textPassword.ReadOnly = false;
            this.textPassword.Size = new System.Drawing.Size(208, 38);
            this.textPassword.TabIndex = 9;
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textPassword.TextName = "";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.linkLabel1.Location = new System.Drawing.Point(140, 299);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register?";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 352);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private JThinButton.JThinButton btnLogin;
        private JMetroTextBox.JMetroTextBox textUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private JMetroTextBox.JMetroTextBox textPassword;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

