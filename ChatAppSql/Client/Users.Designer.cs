namespace Client
{
    partial class Users
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.btnSend = new JThinButton.JThinButton();
            this.textMessage = new JMetroTextBox.JMetroTextBox();
            this.btnRetrieve = new JThinButton.JThinButton();
            this.richTextMessage = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 53);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(516, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chat App";
            // 
            // listUsers
            // 
            this.listUsers.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUsers.ForeColor = System.Drawing.Color.Black;
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 23;
            this.listUsers.Location = new System.Drawing.Point(0, 55);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(266, 349);
            this.listUsers.TabIndex = 1;
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.listUsers_SelectedIndexChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.btnSend.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSend.BorderRadius = 15;
            this.btnSend.ButtonText = "Send";
            this.btnSend.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColors = System.Drawing.SystemColors.HighlightText;
            this.btnSend.HoverBackground = System.Drawing.Color.White;
            this.btnSend.HoverBorder = System.Drawing.SystemColors.Highlight;
            this.btnSend.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnSend.LineThickness = 2;
            this.btnSend.Location = new System.Drawing.Point(435, 411);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(87, 33);
            this.btnSend.TabIndex = 9;
            this.btnSend.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.Color.Transparent;
            this.textMessage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.textMessage.BorderRadius = 13;
            this.textMessage.FillColor = System.Drawing.SystemColors.Window;
            this.textMessage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textMessage.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textMessage.ForeColors = System.Drawing.Color.Gray;
            this.textMessage.IsPassword = false;
            this.textMessage.LineThickness = 2;
            this.textMessage.Location = new System.Drawing.Point(88, 410);
            this.textMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textMessage.MaxLength = 32767;
            this.textMessage.MouseOnHover = System.Drawing.Color.Empty;
            this.textMessage.Name = "textMessage";
            this.textMessage.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.textMessage.OnFocusColor = System.Drawing.Color.Empty;
            this.textMessage.OnFocusFontColor = System.Drawing.Color.Empty;
            this.textMessage.ReadOnly = false;
            this.textMessage.Size = new System.Drawing.Size(340, 34);
            this.textMessage.TabIndex = 11;
            this.textMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textMessage.TextName = "";
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.BackColor = System.Drawing.Color.Transparent;
            this.btnRetrieve.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.btnRetrieve.BorderColor = System.Drawing.Color.Silver;
            this.btnRetrieve.BorderRadius = 15;
            this.btnRetrieve.ButtonText = "Retrieve";
            this.btnRetrieve.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.ForeColors = System.Drawing.SystemColors.HighlightText;
            this.btnRetrieve.HoverBackground = System.Drawing.Color.White;
            this.btnRetrieve.HoverBorder = System.Drawing.SystemColors.Highlight;
            this.btnRetrieve.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.btnRetrieve.LineThickness = 2;
            this.btnRetrieve.Location = new System.Drawing.Point(0, 410);
            this.btnRetrieve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRetrieve.Size = new System.Drawing.Size(87, 33);
            this.btnRetrieve.TabIndex = 12;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // richTextMessage
            // 
            this.richTextMessage.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextMessage.Location = new System.Drawing.Point(272, 55);
            this.richTextMessage.Name = "richTextMessage";
            this.richTextMessage.Size = new System.Drawing.Size(263, 349);
            this.richTextMessage.TabIndex = 13;
            this.richTextMessage.Text = "";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.richTextMessage);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatWindow";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Label label2;
        private JThinButton.JThinButton btnSend;
        private JMetroTextBox.JMetroTextBox textMessage;
        private JThinButton.JThinButton btnRetrieve;
        private System.Windows.Forms.RichTextBox richTextMessage;
    }
}