namespace PreDiplomaPractice
{
    partial class Report3
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
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSpecialty
            // 
            this.cmbSpecialty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecialty.Location = new System.Drawing.Point(150, 15);
            this.cmbSpecialty.Name = "cmbSpecialty";
            this.cmbSpecialty.Size = new System.Drawing.Size(320, 23);
            this.cmbSpecialty.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Text = "Специальность:";
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(150, 55);
            this.nudYear.Size = new System.Drawing.Size(80, 23);
            this.nudYear.Minimum = new decimal(new int[] { 2015, 0, 0, 0 });
            this.nudYear.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            this.nudYear.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Text = "Год поступления:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(150, 95);
            this.dtpDate.Size = new System.Drawing.Size(120, 23);
            this.dtpDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Text = "На дату (защита должна быть до):";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(300, 85);
            this.btnShow.Size = new System.Drawing.Size(140, 40);
            this.btnShow.Text = "Показать должников";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 320);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblCount.Location = new System.Drawing.Point(12, 470);
            this.lblCount.Text = "Найдено студентов без оценки: 0";
            // 
            // Report3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSpecialty);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Report3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт 3: Студенты без оценки на дату";
            this.Load += new System.EventHandler(this.Report3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbSpecialty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCount;
    }
}