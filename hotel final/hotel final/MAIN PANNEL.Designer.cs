namespace hotel_final
{
    partial class MAIN_PANNEL
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
            menuStrip1 = new MenuStrip();
            کارمندانToolStripMenuItem = new ToolStripMenuItem();
            کاربرانToolStripMenuItem = new ToolStripMenuItem();
            اتاقهاToolStripMenuItem = new ToolStripMenuItem();
            رزروهاToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { کارمندانToolStripMenuItem, کاربرانToolStripMenuItem, اتاقهاToolStripMenuItem, رزروهاToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(922, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // کارمندانToolStripMenuItem
            // 
            کارمندانToolStripMenuItem.Name = "کارمندانToolStripMenuItem";
            کارمندانToolStripMenuItem.Size = new Size(60, 20);
            کارمندانToolStripMenuItem.Text = "کارمندان";
            کارمندانToolStripMenuItem.Click += کارمندانToolStripMenuItem_Click;
            // 
            // کاربرانToolStripMenuItem
            // 
            کاربرانToolStripMenuItem.Name = "کاربرانToolStripMenuItem";
            کاربرانToolStripMenuItem.Size = new Size(52, 20);
            کاربرانToolStripMenuItem.Text = "کاربران";
            کاربرانToolStripMenuItem.Click += کاربرانToolStripMenuItem_Click;
            // 
            // اتاقهاToolStripMenuItem
            // 
            اتاقهاToolStripMenuItem.Name = "اتاقهاToolStripMenuItem";
            اتاقهاToolStripMenuItem.Size = new Size(93, 20);
            اتاقهاToolStripMenuItem.Text = "مدیریت اتاق ها";
            اتاقهاToolStripMenuItem.Click += اتاقهاToolStripMenuItem_Click;
            // 
            // رزروهاToolStripMenuItem
            // 
            رزروهاToolStripMenuItem.Name = "رزروهاToolStripMenuItem";
            رزروهاToolStripMenuItem.Size = new Size(92, 20);
            رزروهاToolStripMenuItem.Text = "مدیریت رزرو ها";
            رزروهاToolStripMenuItem.Click += رزروهاToolStripMenuItem_Click;
            // 
            // MAIN_PANNEL
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 440);
            Controls.Add(menuStrip1);
            Font = new Font("MRT_Calligraph", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 6, 5, 6);
            Name = "MAIN_PANNEL";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "پنل اصلی";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem کارمندانToolStripMenuItem;
        private ToolStripMenuItem کاربرانToolStripMenuItem;
        private ToolStripMenuItem اتاقهاToolStripMenuItem;
        private ToolStripMenuItem رزروهاToolStripMenuItem;
    }
}