namespace hotel_final
{
    partial class ENTRANCE
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Compset", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.Location = new Point(299, 176);
            label3.Name = "label3";
            label3.Size = new Size(69, 34);
            label3.TabIndex = 11;
            label3.Text = "رمز عبور";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Compset", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.Location = new Point(299, 106);
            label2.Name = "label2";
            label2.Size = new Size(79, 34);
            label2.TabIndex = 10;
            label2.Text = "نام کاربری";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Compset", 24F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(82, 16);
            label1.Name = "label1";
            label1.Size = new Size(316, 58);
            label1.TabIndex = 9;
            label1.Text = "اطلاعات ورودی را وارد کنید";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(71, 164);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(172, 36);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 36);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("B Compset", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button1.Location = new Point(121, 254);
            button1.Name = "button1";
            button1.Size = new Size(237, 85);
            button1.TabIndex = 6;
            button1.Text = "ورود به پنل";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // ENTRANCE
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 387);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("MRT_Calligraph", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ENTRANCE";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود/عضویت";
            Load += ENTRANCE_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
    }
}