using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PreDiplomaPractice
{
    public partial class FrmPractice : Form
    {
        public FrmPractice() => InitializeComponent();

        private void FrmPractice_Load(object sender, EventArgs e)
        {
            LoadCombos();
            LoadGrid();
        }

        private void LoadCombos()
        {
            using var con = new NpgsqlConnection(DbConnection.ConnectionString);
            con.Open();

            // Студенты
            var dtSt = new DataTable();
            new NpgsqlDataAdapter(
                "SELECT student_id, record_book_num || ' – ' || fio AS info FROM student ORDER BY fio", con)
                .Fill(dtSt);
            cmbStudent.DataSource = dtSt;
            cmbStudent.DisplayMember = "info";
            cmbStudent.ValueMember = "student_id";

            // Предприятия
            var dtComp = new DataTable();
            new NpgsqlDataAdapter("SELECT company_id, name FROM company ORDER BY name", con)
                .Fill(dtComp);
            cmbCompany.DataSource = dtComp;
            cmbCompany.DisplayMember = "name";
            cmbCompany.ValueMember = "company_id";
        }

        private void LoadGrid()
        {
            using var con = new NpgsqlConnection(DbConnection.ConnectionString);
            con.Open();
            var sql = @"
                SELECT p.practice_id,
                       s.fio AS ""Студент"",
                       c.name AS ""Предприятие"",
                       p.date_start AS ""Начало"",
                       p.date_end AS ""Конец"",
                       p.grade AS ""Оценка""
                FROM practice p
                JOIN student s ON p.student_id = s.student_id
                JOIN company c ON p.company_id = c.company_id
                ORDER BY p.date_start DESC";
            var dt = new DataTable();
            new NpgsqlDataAdapter(sql, con).Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedValue == null || cmbCompany.SelectedValue == null) return;

            using var con = new NpgsqlConnection(DbConnection.ConnectionString);
            con.Open();
            var cmd = new NpgsqlCommand(@"
                INSERT INTO practice 
                (student_id, company_id, date_start, date_end, grade)
                VALUES (@st, @comp, @ds, @de, @gr)", con);

            cmd.Parameters.AddWithValue("st", cmbStudent.SelectedValue);
            cmd.Parameters.AddWithValue("comp", cmbCompany.SelectedValue);
            cmd.Parameters.AddWithValue("ds", dtpStart.Value.Date);
            cmd.Parameters.AddWithValue("de", dtpEnd.Value.Date);
            cmd.Parameters.AddWithValue("gr",
                nudGrade.Value == 0 ? (object)DBNull.Value : nudGrade.Value);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Практика сохранена!");
            LoadGrid();
        }
    }
}