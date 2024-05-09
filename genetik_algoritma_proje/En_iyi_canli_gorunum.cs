using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genetik_algoritma_proje
{
    public partial class En_iyi_canli_gorunum : UserControl
    {
        public Canli Canli { get; set; }

        public En_iyi_canli_gorunum()
        {
            InitializeComponent();
        }
        public En_iyi_canli_gorunum(Canli c, int no) : this()
        {
            this.Canli = c;
            label5.Text = no.ToString();
            label8.Text = c.Gen.x1.ToString();
            label9.Text = c.Gen.x2.ToString();
            label3.Text = c.Gen.MatyasFormulSkor.ToString();
            Renklendir();
        }

        private void Renklendir()
        {
            double d = Canli.Gen.MatyasFormulSkor;
            int ratio = (int)(d * 1700), r = 100, g = 0;
            if (ratio <= 100)
            {
                r = (int)(255 * ((double)ratio / (double)100));
                g = (int)(255 * ((double)(100 - ratio) / (double)101));
            }

            pictureBox2.BackColor = Color.FromArgb(r, g, 0);


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void En_iyi_canli_gorunum_Load(object sender, EventArgs e)
        {

        }
    }
}
