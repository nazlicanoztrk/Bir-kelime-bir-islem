using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace birkelimebirislemn
{
    public partial class klavye : Form
    {
        public klavye()
        {
            InitializeComponent();
        }
      
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J1S6UT\\SQLEXPRESS02;Initial Catalog=Kelime;Integrated Security=True");
      
        private void verileriGöster()
        {
listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Kelime", baglanti);
        SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
        ekle.Text= oku["kelime"].ToString();
        listView1.Items.Add(ekle);

            }
    baglanti.Close();
        }
        
        

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtCevap.Text.Length > 0)
                txtCevap.Text = txtCevap.Text.Remove(txtCevap.Text.Length - 2);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (txtCevap.Text.Length > 0)
                txtCevap.Text = "";
        }

      

        private void klavye_Load(object sender, EventArgs e)
        {
            txtCevap.MaxLength = 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCevap.Text = txtCevap.Text + ((Button)sender).Text;
        }

        private void txtkelimecevap_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCevap_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void ENTER_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Kelime where  kelime like '%" + txtCevap.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

             

            while (oku.Read())
            {
                  ListViewItem ekle = new ListViewItem();
                ekle.Text= oku["kelime"].ToString();
                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }

        private void radioyanıtyok_CheckedChanged(object sender, EventArgs e)
        {
            SAYİLAR sylform = new SAYİLAR();
            sylform.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button31.Text = 5.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button31.Text = 5.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button31.Text = 6.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button31.Text = 6.ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button31.Text = 7.ToString();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button31.Text = 7.ToString();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button31.Text = 8.ToString();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            button31.Text = 8.ToString();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            button31.Text = 9.ToString();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            button31.Text = 9.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           SAYİLAR  sylr= new SAYİLAR();
            sylr.Show();
            this.Hide();
        }
    }
}
