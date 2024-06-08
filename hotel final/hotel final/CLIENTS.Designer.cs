namespace hotel_final
{
    partial class CLIENTS
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(309, 357);
            button1.Name = "button1";
            button1.Size = new Size(258, 52);
            button1.TabIndex = 11;
            button1.Text = "ثبت اطلاعات";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(95, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(659, 256);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات فردی";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("B Compset", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 178);
            textBox3.Location = new Point(372, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(144, 31);
            textBox3.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("B Compset", 14.25F, FontStyle.Bold);
            label4.Location = new Point(522, 151);
            label4.Name = "label4";
            label4.Size = new Size(86, 34);
            label4.TabIndex = 20;
            label4.Text = "شماره تماس";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("B Compset", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 178);
            textBox2.Location = new Point(66, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 31);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("B Compset", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 178);
            textBox1.Location = new Point(372, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 31);
            textBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Compset", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.Location = new Point(241, 60);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 34);
            label3.TabIndex = 3;
            label3.Text = "نام خانوادگی";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Compset", 14.25F, FontStyle.Bold);
            label1.Location = new Point(568, 64);
            label1.Name = "label1";
            label1.Size = new Size(30, 34);
            label1.TabIndex = 2;
            label1.Text = "نام";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Compset", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.Location = new Point(350, 21);
            label2.Name = "label2";
            label2.Size = new Size(165, 51);
            label2.TabIndex = 7;
            label2.Text = "اطلاعات مشتری";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("B Compset", 14.25F, FontStyle.Bold);
            label5.Location = new Point(247, 151);
            label5.Name = "label5";
            label5.Size = new Size(86, 34);
            label5.TabIndex = 23;
            label5.Text = "شماره تماس";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("B Compset", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 178);
            textBox4.Location = new Point(66, 151);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 31);
            textBox4.TabIndex = 24;
            // 
            // CLIENTS
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 462);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Font = new Font("MRT_Calligraph", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CLIENTS";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اطلاعات مشتری";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
    }
}