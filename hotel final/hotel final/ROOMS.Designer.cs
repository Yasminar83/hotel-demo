namespace hotel_final
{
    partial class ROOMS
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label7 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            rOOMSBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rOOMSBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 13);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(394, 440);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Compset", 24F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(473, 9);
            label1.Name = "label1";
            label1.Size = new Size(414, 58);
            label1.TabIndex = 1;
            label1.Text = "مشخصات اتاق موردنظر را انتخاب کنید";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(867, 80);
            label2.Name = "label2";
            label2.Size = new Size(77, 34);
            label2.TabIndex = 2;
            label2.Text = "شماره اتاق";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(626, 83);
            label3.Name = "label3";
            label3.Size = new Size(43, 34);
            label3.TabIndex = 3;
            label3.Text = "طبقه";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(880, 130);
            label4.Name = "label4";
            label4.Size = new Size(64, 34);
            label4.TabIndex = 4;
            label4.Text = "نوع اتاق";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(855, 240);
            label5.Name = "label5";
            label5.Size = new Size(89, 34);
            label5.TabIndex = 5;
            label5.Text = "وضعیت اتاق";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(580, 130);
            label6.Name = "label6";
            label6.Size = new Size(89, 34);
            label6.TabIndex = 6;
            label6.Text = "سرویس اتاق";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("B Compset", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBox1.Location = new Point(747, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 33);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("B Compset", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBox2.Location = new Point(478, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 33);
            textBox2.TabIndex = 8;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(747, 238);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(89, 38);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "رزرو شده";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(626, 238);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(91, 38);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "تخلیه شده";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(735, 323);
            button1.Name = "button1";
            button1.Size = new Size(135, 61);
            button1.TabIndex = 13;
            button1.Text = "ویرایش اتاق";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(545, 324);
            button2.Name = "button2";
            button2.Size = new Size(135, 61);
            button2.TabIndex = 14;
            button2.Text = "بروزرسانی اتاق ها";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(809, 390);
            button3.Name = "button3";
            button3.Size = new Size(135, 61);
            button3.TabIndex = 15;
            button3.Text = "حذف اتاق";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(473, 393);
            button4.Name = "button4";
            button4.Size = new Size(135, 61);
            button4.TabIndex = 16;
            button4.Text = "ثبت اتاق جدید";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(642, 391);
            button5.Name = "button5";
            button5.Size = new Size(135, 61);
            button5.TabIndex = 17;
            button5.Text = "خالی کردن ";
            button5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(810, 186);
            label7.Name = "label7";
            label7.Size = new Size(134, 34);
            label7.TabIndex = 18;
            label7.Text = "هزینه هر شب اقامت";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(543, 183);
            label8.Name = "label8";
            label8.Size = new Size(126, 34);
            label8.TabIndex = 19;
            label8.Text = "هزینه سرویس اتاق";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("B Compset", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "یک تخته", "دو تخته", "سوییت" });
            comboBox1.Location = new Point(724, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 35);
            comboBox1.TabIndex = 20;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("B Compset", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "صبحانه", "ناهار", "شام", "استخر", "باشگاه ورزشی" });
            comboBox2.Location = new Point(424, 132);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(150, 35);
            comboBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("B Compset", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBox3.Location = new Point(681, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(123, 33);
            textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("B Compset", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            textBox4.Location = new Point(414, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(123, 33);
            textBox4.TabIndex = 23;
            // 
            // rOOMSBindingSource
            // 
            rOOMSBindingSource.DataSource = typeof(ROOMS);
            // 
            // ROOMS
            // 
            AutoScaleDimensions = new SizeF(13F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 466);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("B Compset", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            Margin = new Padding(5, 7, 5, 7);
            Name = "ROOMS";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اطلاعات اتاق ها";
            Load += ROOMS_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rOOMSBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private BindingSource rOOMSBindingSource;
    }
}