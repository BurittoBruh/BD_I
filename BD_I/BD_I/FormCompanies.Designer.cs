namespace PreDiplomaPractice
{
    partial class FrmCompanies
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtShort = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            this.label1.Location = new System.Drawing.Point(20, 20); this.label1.Text = "Код:";
            this.txtCode.Location = new System.Drawing.Point(120, 17); this.txtCode.Width = 150;

            this.label2.Location = new System.Drawing.Point(20, 50); this.label2.Text = "Полное название:";
            this.txtName.Location = new System.Drawing.Point(120, 47); this.txtName.Width = 500;

            this.label3.Location = new System.Drawing.Point(20, 80); this.label3.Text = "Краткое название:";
            this.txtShort.Location = new System.Drawing.Point(120, 77); this.txtShort.Width = 400;

            this.label4.Location = new System.Drawing.Point(20, 110); this.label4.Text = "Адрес:";
            this.txtAddress.Location = new System.Drawing.Point(120, 107); this.txtAddress.Width = 600;

            this.btnAdd.Location = new System.Drawing.Point(120, 150); this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += btnAdd_Click;

            this.btnDelete.Location = new System.Drawing.Point(250, 150); this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += btnDelete_Click;

            this.dataGridView1.Location = new System.Drawing.Point(20, 200);
            this.dataGridView1.Size = new System.Drawing.Size(744, 300);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ReadOnly = true;

            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd); this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4); this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3); this.Controls.Add(this.txtShort);
            this.Controls.Add(this.label2); this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1); this.Controls.Add(this.txtCode);
            this.Text = "Справочник: Предприятия";
            this.Load += new System.EventHandler(this.FrmCompanies_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtShort;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}