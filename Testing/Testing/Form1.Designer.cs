namespace Testing
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "SIGN IN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.Location = new Point(12, 94);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 1;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(73, 17);
            label4.TabIndex = 1;
            label4.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 10F);
            txtUsername.Location = new Point(12, 68);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(274, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10F);
            txtEmail.Location = new Point(12, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(274, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.White;
            txtPass.Font = new Font("Microsoft Sans Serif", 10F);
            txtPass.Location = new Point(12, 160);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(274, 23);
            txtPass.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10F);
            button1.Location = new Point(106, 192);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 5;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 10F);
            button2.Location = new Point(106, 192);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 5;
            button2.Text = "Log in";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.Location = new Point(40, 233);
            label5.Name = "label5";
            label5.Size = new Size(158, 17);
            label5.TabIndex = 6;
            label5.Text = "Don't have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 10F);
            linkLabel1.Location = new Point(195, 233);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(56, 17);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 268);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Button button1;
        private Button button2;
        private Label label5;
        private LinkLabel linkLabel1;
    }
}
