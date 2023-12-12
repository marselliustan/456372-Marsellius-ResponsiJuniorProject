using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Responsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=HR";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM karyawan_insert(:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tb_nama.Text);
                cmd.Parameters.AddWithValue("_id_dep", int.Parse(tb_iddep.Text));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users berhasil diinputkan");
                    conn.Close();
                    tb_nama.Text = tb_iddep.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate");
                return;
            }

            try
            {
                conn.Open();
                sql = @"SELECT * FROM karyawan_update(:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", tb_nama.Text);
                cmd.Parameters.AddWithValue("_id_dep", tb_iddep.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users berhasil diupdate");
                    conn.Close();
                    tb_nama.Text = tb_iddep.Text = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Update FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate");
                return;
            }

            if (MessageBox.Show("Apakah benar anda ingin menghapus data " + r.Cells["_nama"].Value.ToString() + " ?", "Hapus data terkonfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                try
                {
                    conn.Open();
                    sql = @"SELECT * FROM karyawan_delete(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["_id_karyawan"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Users berhasil dihapus");
                        conn.Close();
                        tb_nama.Text = tb_iddep.Text = null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Update FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgv_data.DataSource = null;
                sql = "SELECT * FROM karyawan_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgv_data.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
