using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PreDiplomaPractice
{
    public partial class Report1 : Form
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            using var con = new NpgsqlConnection(DbConnection.ConnectionString);
            con.Open();
            var dt = new DataTable();
            new NpgsqlDataAdapter("SELECT company_id, name FROM company ORDER BY name", con).Fill(dt);
            cmbCompany.DataSource = dt;
            cmbCompany.DisplayMember = "name";
            cmbCompany.ValueMember = "company_id";

            dtpFrom.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpTo.Value = DateTime.Now;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using var con = new NpgsqlConnection(DbConnection.ConnectionString);
            con.Open();
            var sql = @"
                SELECT c.name AS ""Предприятие"", COUNT(DISTINCT p.student_id) AS ""Количество студентов""
                FROM practice p
                JOIN company c ON p.company_id = c.company_id
                WHERE p.company_id = @cid
                  AND p.date_start <= @to 
                  AND p.date_end >= @from
                GROUP BY c.company_id, c.name";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("cid", cmbCompany.SelectedValue);
            cmd.Parameters.AddWithValue("from", dtpFrom.Value.Date);
            cmd.Parameters.AddWithValue("to", dtpTo.Value.Date);

            var dt = new DataTable();
            new NpgsqlDataAdapter(cmd).Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}