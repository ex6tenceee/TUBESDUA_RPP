namespace Automata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        List<string> namaMhs = new List<string>();
        List<string> judulBuku = new List<string>();

        

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {   
            {
                
                string input = String(textBox3);
                string input2 = String(textBox4);
                if (input != "Daffa")
                {
                    MessageBox.Show("Mahasiswa tidak terdaftar!");
                    MessageBox.Show("Masukkan nama yang benar!");
                }
                else if (input2 != "Laskar Pelangi")
                {
                    MessageBox.Show("Judul buku tidak tersedia!");
                }
                else
                {
                    MessageBox.Show("Anda berhasil mendaftarkan pengembalian buku!");
                }
            }
        }

        private string String(TextBox textBox3)
        {
            throw new NotImplementedException();
        }
    }
}