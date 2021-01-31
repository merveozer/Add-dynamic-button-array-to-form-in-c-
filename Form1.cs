using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buton.ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                void butonOlustur() {
                int xEkseni = 50;
                int yEkseni = 50;
                System.Windows.Forms.Button[] butonDizi = new System.Windows.Forms.Button[6];

                for (int i = 0; i < 6; i++)
                {
                    butonDizi[i] = new System.Windows.Forms.Button();
                }

                
                for (int a=0;a<6;a++)
                {
                    butonDizi[a].Width = 20;
                    butonDizi[a].Height = 20;
                    butonDizi[a].Left = xEkseni;
                    butonDizi[a].Top = yEkseni;


                    if (a == 0 || a % 2 == 0)
                    {
                        butonDizi[a].BackColor = Color.White;
                    }
                    else
                    {
                        butonDizi[a].BackColor = Color.Red;
                    }

                    xEkseni = xEkseni + butonDizi[a].Width;
                }

            }

            butonOlustur();
        }

        
    }
}