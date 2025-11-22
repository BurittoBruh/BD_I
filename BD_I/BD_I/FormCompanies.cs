using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace PreDiplomaPractice
{
    public partial class FrmCompanies : Form
    {
        public FrmCompanies() => InitializeComponent();

        private void FrmCompanies_Load(object sender, EventArgs e) => LoadGrid();

        private void LoadGrid()
        {
            using var con = new NpgsqlConnection(DbConnection.ConnectionString);
            con.Open();
            var sql = @"
                SELECT company_id,
                       code AS ""Код"",
                       name AS ""Полное название"",
                       short_name AS ""Краткое"",
                       address AS ""Адрес""
                FROM company
                ORDER BY name";
            var dt = new DataTable();
            new NpgsqlDataAdapter(sql, con).Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Заполните Код и Название!");
                return;
            }

            using var con = new NpgsqlConnection(DbConnection.ConnectionString);
            con.Open();
            var cmd = new NpgsqlCommand(@"
                INSERT INTO company (code, name, short_name, address)
                VALUES (@c, @n, @s, @a)", con);
            cmd.Parameters.AddWithValue("c", txtCode.Text.Trim());
            cmd.Parameters.AddWithValue("n", txtName.Text.Trim());
            cmd.Parameters.AddWithValue("s", txtShort.Text.Trim());
            cmd.Parameters.AddWithValue("a", txtAddress.Text.Trim());
            cmd.ExecuteNonQuery();

            LoadGrid();
            txtCode.Clear(); txtName.Clear(); txtShort.Clear(); txtAddress.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var id = dataGridView1.SelectedRows[0].Cells[0].Value;
            if (MessageBox.Show("Удалить предприятие?", "Да?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var con = new NpgsqlConnection(DbConnection.ConnectionString);
                con.Open();
                new NpgsqlCommand($"DELETE FROM company WHERE company_id = {id}", con).ExecuteNonQuery();
                LoadGrid();
            }
        }
    }
}