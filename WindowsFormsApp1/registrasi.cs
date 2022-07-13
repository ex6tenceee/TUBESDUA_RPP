using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class registrasi : Form
    {
        public registrasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama, telp, alamat, username, password;

            nama = textBox1.Text;
            telp = textBox2.Text;
            alamat = textBox3.Text;
            username = textBox4.Text;
            password = textBox5.Text;

            Debug.Assert(nama.Length > 0, "nama tidak boleh kosong");
            Debug.Assert(telp.Length > 0 && telp.Length < 13, "no tidak boleh kosong dan tidak boleh lebih dari 13");
            Debug.Assert(alamat.Length > 0, "alamat tidak boleh kosong");
            Debug.Assert(username.Length > 0 && username.Length < 11, "username tidak boleh lebih dari 11");
            Debug.Assert(password.Length > 0 && password.Length < 10, "password tidak boleh lebih dari 11");

        }
    }
}
