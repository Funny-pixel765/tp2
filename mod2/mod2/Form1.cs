using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mod2
{
    public partial class Form1 : Form
    {
        
        private TextBox textBoxNama;
        private Button buttonN;
        private Label labelTitle;
        private Label labelOutput;


        public Form1()
        {
            InitializeComponent();
            SetupComponents(); 
        }


        private void SetupComponents()
        {
            this.Text = "Praktikan";
            this.Size = new Size(400, 300);

            
            labelTitle = new Label();
            labelTitle.Text = "Masukkan nama anda";
            labelTitle.Location = new Point(110, 20);
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            this.Controls.Add(labelTitle);

            
            textBoxNama = new TextBox();
            textBoxNama.Location = new Point(100, 70);
            textBoxNama.Size = new Size(200, 20);
            this.Controls.Add(textBoxNama);

            
            buttonN = new Button();
            buttonN.Text = "Kirim";
            buttonN.Location = new Point(150, 100);
            buttonN.Size = new Size(100, 30);
            buttonN.Click += new EventHandler(button1_Click);
            this.Controls.Add(buttonN);

            labelOutput = new Label();
            labelOutput.Text = "";
            labelOutput.Location = new Point(150, 150);
            labelOutput.AutoSize = true;
            this.Controls.Add(labelOutput);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNama == null || buttonN == null)
            {
                MessageBox.Show("Komponen belum diinisialisasi dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string namaPraktikan = textBoxNama.Text;

            if (string.IsNullOrEmpty(namaPraktikan))
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            labelOutput.Text = "Halo, " + namaPraktikan;
        }


        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}