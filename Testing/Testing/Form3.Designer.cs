namespace Testing
{
    partial class frmRsrv
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 0;
            label1.Text = "Reservation Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 1;
            label2.Text = "Contact Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 1;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.Location = new Point(12, 137);
            label4.Name = "label4";
            label4.Size = new Size(127, 17);
            label4.TabIndex = 1;
            label4.Text = "Number of Guests:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.Location = new Point(12, 229);
            label5.Name = "label5";
            label5.Size = new Size(122, 17);
            label5.TabIndex = 1;
            label5.Text = "Special Requests:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F);
            label6.Location = new Point(12, 183);
            label6.Name = "label6";
            label6.Size = new Size(105, 17);
            label6.TabIndex = 1;
            label6.Text = "Date and Time:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 10F);
            textBox1.Location = new Point(12, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 10F);
            textBox2.Location = new Point(12, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 10F);
            textBox3.Location = new Point(12, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(241, 23);
            textBox3.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 10F);
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 10F);
            dateTimePicker1.Location = new Point(12, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 249);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(241, 102);
            textBox4.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10F);
            button1.Location = new Point(90, 357);
            button1.Name = "button1";
            button1.Size = new Size(87, 31);
            button1.TabIndex = 7;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmRsrv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 400);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRsrv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private Button button1;
    }
}