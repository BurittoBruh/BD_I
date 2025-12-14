namespace PreDiplomaPractice
{
    partial class FrmPractice
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
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.nudGrade = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).BeginInit();
            this.SuspendLayout();

            this.label1.Location = new System.Drawing.Point(20, 20); this.label1.Text = "Студент:";
            this.cmbStudent.Location = new System.Drawing.Point(120, 17); this.cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList; this.cmbStudent.Width = 400;

            this.label2.Location = new System.Drawing.Point(20, 55); this.label2.Text = "Предприятие:";
            this.cmbCompany.Location = new System.Drawing.Point(120, 52); this.cmbCompany.DropDownStyle = ComboBoxStyle.DropDownList; this.cmbCompany.Width = 400;

            this.label3.Location = new System.Drawing.Point(20, 90); this.label3.Text = "Дата начала:";
            this.dtpStart.Location = new System.Drawing.Point(120, 87); this.dtpStart.Format = DateTimePickerFormat.Short;

            this.label4.Location = new System.Drawing.Point(20, 125); this.label4.Text = "Дата окончания:";
            this.dtpEnd.Location = new System.Drawing.Point(120, 122); this.dtpEnd.Format = DateTimePickerFormat.Short;

            this.label5.Location = new System.Drawing.Point(20, 160); this.label5.Text = "Оценка";
            this.nudGrade.Location = new System.Drawing.Point(200, 157); this.nudGrade.Minimum = 0; this.nudGrade.Maximum = 5;

            this.btnSave.Location = new System.Drawing.Point(120, 200); this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.Text = "Сохранить практику"; this.btnSave.Click += btnSave_Click;

            this.dataGridView1.Location = new System.Drawing.Point(20, 250);
            this.dataGridView1.Size = new System.Drawing.Size(744, 260);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ReadOnly = true;

            this.ClientSize = new System.Drawing.Size(784, 531);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5); this.Controls.Add(this.nudGrade);
            this.Controls.Add(this.label4); this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label3); this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2); this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.label1); this.Controls.Add(this.cmbStudent);
            this.Text = "Практика студентов";
            this.Load += new System.EventHandler(this.FrmPractice_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.NumericUpDown nudGrade;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}