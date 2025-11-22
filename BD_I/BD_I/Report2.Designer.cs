namespace PreDiplomaPractice
{
    partial class Report2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbSpecialty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSpecialty
            // 
            this.cmbSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecialty.FormattingEnabled = true;
            this.cmbSpecialty.Location = new System.Drawing.Point(130, 15);
            this.cmbSpecialty.Name = "cmbSpecialty";
            this.cmbSpecialty.Size = new System.Drawing.Size(350, 23);
            this.cmbSpecialty.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Специальность:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(130, 55);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(120, 23);
            this.dtpFrom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Период с:";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(130, 90);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(120, 23);
            this.dtpTo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Период по:";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(280, 80);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 35);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Показать";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(760, 350);
            this.dataGridView1.TabIndex = 7;
            // 
            // Report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSpecialty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Report2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт 2: Предприятия по специальности за период";
            this.Load += new System.EventHandler(this.Report2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbSpecialty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}