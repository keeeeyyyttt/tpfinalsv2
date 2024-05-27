namespace Testing
{
    partial class frmSignup
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            txtFname = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPass = new TextBox();
            txtPass_retype = new TextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "SIGN UP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 1;
            label2.Text = "Full name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 1;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.Location = new Point(12, 145);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 1;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.Location = new Point(12, 191);
            label5.Name = "label5";
            label5.Size = new Size(73, 17);
            label5.TabIndex = 1;
            label5.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F);
            label6.Location = new Point(12, 237);
            label6.Name = "label6";
            label6.Size = new Size(121, 17);
            label6.TabIndex = 1;
            label6.Text = "Retype password:";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10F);
            button1.Location = new Point(106, 295);
            button1.Name = "button1";
            button1.Size = new Size(77, 26);
            button1.TabIndex = 2;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F);
            label7.Location = new Point(21, 324);
            label7.Name = "label7";
            label7.Size = new Size(173, 17);
            label7.TabIndex = 3;
            label7.Text = "Already have an account?";
            // 
            // txtFname
            // 
            txtFname.Font = new Font("Microsoft Sans Serif", 10F);
            txtFname.Location = new Point(12, 73);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(280, 23);
            txtFname.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10F);
            txtEmail.Location = new Point(12, 119);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 10F);
            txtUsername.Location = new Point(12, 165);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 23);
            txtUsername.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Microsoft Sans Serif", 10F);
            txtPass.Location = new Point(12, 211);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(280, 23);
            txtPass.TabIndex = 7;
            // 
            // txtPass_retype
            // 
            txtPass_retype.Font = new Font("Microsoft Sans Serif", 10F);
            txtPass_retype.Location = new Point(12, 257);
            txtPass_retype.Name = "txtPass_retype";
            txtPass_retype.Size = new Size(280, 23);
            txtPass_retype.TabIndex = 8;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 10F);
            linkLabel1.Location = new Point(191, 324);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(80, 17);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log in here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmSignup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 357);
            Controls.Add(linkLabel1);
            Controls.Add(txtPass_retype);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtFname);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private TextBox txtFname;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPass;
        private TextBox txtPass_retype;
        private LinkLabel linkLabel1;
    }
}