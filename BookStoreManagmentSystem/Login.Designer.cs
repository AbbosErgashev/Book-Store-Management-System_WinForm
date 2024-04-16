namespace BookStoreManagmentSystem
{
    partial class Login
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel8 = new Panel();
            pictureBox9 = new PictureBox();
            label14 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 435);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(panel8);
            panel2.Location = new Point(341, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(447, 435);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 90);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Nice Staff";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 213);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Nice Staff";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 150);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Nice Staff";
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox9);
            panel8.Controls.Add(label14);
            panel8.Location = new Point(83, 15);
            panel8.Name = "panel8";
            panel8.Size = new Size(230, 45);
            panel8.TabIndex = 5;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.address;
            pictureBox9.Location = new Point(3, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(45, 45);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 1;
            pictureBox9.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(54, 3);
            label14.Name = "label14";
            label14.Size = new Size(100, 25);
            label14.TabIndex = 0;
            label14.Text = "Book Shop";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 227);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 150);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 3;
            label5.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 31);
            textBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(205, 281);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 352);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 9;
            label6.Text = "Admin";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Panel panel8;
        private PictureBox pictureBox9;
        private Label label14;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}