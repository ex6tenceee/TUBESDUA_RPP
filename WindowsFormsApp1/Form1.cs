using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\auzan\Documents\DataBuku.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into data_buku values (@KodeBuku,@NamaBuku,@TanggalTerbit,@DeskripsiBuku)", con);
            cmd.Parameters.AddWithValue("@KodeBuku", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@NamaBuku", (textBox2.Text));
            cmd.Parameters.AddWithValue("@TanggalTerbit", double.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@DeskripsiBuku", (textBox4.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Berhasil di Input");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\auzan\Documents\DataBuku.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update data_buku set NamaBuku=@NamaBuku, TanggalTerbit=@TanggalTerbit, DeskripsiBuku=@DeskripsiBuku where KodeBuku=@KodeBuku", con);
            cmd.Parameters.AddWithValue("@KodeBuku", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@NamaBuku", (textBox2.Text));
            cmd.Parameters.AddWithValue("@TanggalTerbit", double.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@DeskripsiBuku", (textBox4.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Berhasil di Update");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\auzan\Documents\DataBuku.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete data_buku where KodeBuku=@KodeBuku", con);
            cmd.Parameters.AddWithValue("@KodeBuku", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Berhasil di Hapus");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\auzan\Documents\DataBuku.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from data_buku where KodeBuku=@KodeBuku", con);
            cmd.Parameters.AddWithValue("KodeBuku", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
