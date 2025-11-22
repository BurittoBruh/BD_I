namespace PreDiplomaPractice
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предприятияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.практикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчёт1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчёт2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчёт3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.справочникиToolStripMenuItem, this.отчётыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;

            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.студентыToolStripMenuItem, this.предприятияToolStripMenuItem, this.практикаToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";

            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.студентыToolStripMenuItem.Text = "Студенты";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);

            this.предприятияToolStripMenuItem.Name = "предприятияToolStripMenuItem";
            this.предприятияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.предприятияToolStripMenuItem.Text = "Предприятия";
            this.предприятияToolStripMenuItem.Click += new System.EventHandler(this.предприятияToolStripMenuItem_Click);

            this.практикаToolStripMenuItem.Name = "практикаToolStripMenuItem";
            this.практикаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.практикаToolStripMenuItem.Text = "Практика студентов";
            this.практикаToolStripMenuItem.Click += new System.EventHandler(this.практикаToolStripMenuItem_Click);

            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.отчёт1ToolStripMenuItem, this.отчёт2ToolStripMenuItem, this.отчёт3ToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";

            this.отчёт1ToolStripMenuItem.Text = "1. Кол-во студентов на предприятии";
            this.отчёт1ToolStripMenuItem.Click += new System.EventHandler(this.отчёт1ToolStripMenuItem_Click);
            this.отчёт2ToolStripMenuItem.Text = "2. Предприятия по специальности";
            this.отчёт2ToolStripMenuItem.Click += new System.EventHandler(this.отчёт2ToolStripMenuItem_Click);
            this.отчёт3ToolStripMenuItem.Text = "3. Студенты без оценки";
            this.отчёт3ToolStripMenuItem.Click += new System.EventHandler(this.отчёт3ToolStripMenuItem_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Преддипломная практика";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предприятияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem практикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчёт1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчёт2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчёт3ToolStripMenuItem;
    }
}