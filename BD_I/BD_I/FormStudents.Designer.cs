namespace PreDiplomaPractice
{
    partial class FrmStudents
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.txtFIO = new System.Windows.Forms.TextBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.cmbSpecialty = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.SuspendLayout();

            this.label1.Location = new System.Drawing.Point(20, 20); this.label1.Text = "Зачётка:";
            this.txtBook.Location = new System.Drawing.Point(120, 17); this.txtBook.Width = 150;

            this.label2.Location = new System.Drawing.Point(20, 50); this.label2.Text = "ФИО:";
            this.txtFIO.Location = new System.Drawing.Point(120, 47); this.txtFIO.Width = 350;

            this.label3.Location = new System.Drawing.Point(20, 80); this.label3.Text = "Год поступления:";
            this.nudYear.Location = new System.Drawing.Point(120, 77); this.nudYear.Minimum = 2015; this.nudYear.Maximum = 2030; this.nudYear.Value = 2021;

            this.label4.Location = new System.Drawing.Point(20, 110); this.label4.Text = "Специальность:";
            this.cmbSpecialty.Location = new System.Drawing.Point(120, 107); this.cmbSpecialty.DropDownStyle = ComboBoxStyle.DropDownList; this.cmbSpecialty.Width = 350;

            this.btnAdd.Location = new System.Drawing.Point(120, 150); this.btnAdd.Text = "Добавить"; this.btnAdd.Click += btnAdd_Click;
            this.btnDelete.Location = new System.Drawing.Point(230, 150); this.btnDelete.Text = "Удалить"; this.btnDelete.Click += btnDelete_Click;

            this.dataGridView1.Location = new System.Drawing.Point(20, 200);
            this.dataGridView1.Size = new System.Drawing.Size(744, 300);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ReadOnly = true;

            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd); this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4); this.Controls.Add(this.cmbSpecialty);
            this.Controls.Add(this.label3); this.Controls.Add(this.nudYear);
            this.Controls.Add(this.label2); this.Controls.Add(this.txtFIO);
            this.Controls.Add(this.label1); this.Controls.Add(this.txtBook);
            this.Text = "Справочник: Студенты";
            this.Load += new System.EventHandler(this.FrmStudents_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.TextBox txtFIO;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.ComboBox cmbSpecialty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}