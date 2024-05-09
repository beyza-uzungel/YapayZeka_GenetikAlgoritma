using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Schema;


namespace genetik_algoritma_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isRunning = false;
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void TabloOlustur(List<Canli> c, int cap = 10, Color? color = null, Image img = null)
        {
            bool check = img == null;

            if (check)
                img = Properties.Resources.matyas;

            foreach (Canli canli in c)
            {
                int x = (int)((double)((canli.Gen.x1 + 10) / 20) * (img.Width - 50));
                int y = (int)((double)((canli.Gen.x2 + 10) / 20) * (img.Height - 60));
                noktaCiz(x + 25, y + 30, img, cap, color);
            }
            if (check)
                pictureBox1.Image = img;

        }
        public void noktaCiz(int x, int y, Image img, int radius = 10, Color? color = null)
        {
            Graphics g = Graphics.FromImage(img);
            int alpha = (int)numericUpDown7.Value;
            Color colorTemp = Color.Empty;

            Point dPoint = new Point(x, (img.Height - y));
            dPoint.X = dPoint.X - 2;
            dPoint.Y = dPoint.Y - 2;
            if (color.HasValue)
            {
                colorTemp = Color.FromArgb(alpha, color.Value.R, color.Value.G, color.Value.B);
                g.CemberDoldur(new SolidBrush(Color.FromArgb(alpha, color.Value.R, color.Value.G, color.Value.B)), dPoint.X, dPoint.Y, 2);
                g.CemberCiz(new Pen(colorTemp), dPoint.X, dPoint.Y, radius);//çember
            }
            else
            {
                g.CemberDoldur(new SolidBrush(Color.FromArgb(255, 0, 50, 255)), dPoint.X, dPoint.Y, 2);
                g.CemberCiz(new Pen(Color.DarkBlue), dPoint.X, dPoint.Y, radius);//çember
            }

            g.Dispose();
        }

        private bool Durdur_Hesapla_kontrol()
        {
            if (isRunning)
            {
                isRunning = false;
                button1.Text = "HESAPLA";
            }
            else
            {
                button1.Text = "Durdur";
                isRunning = true;
            }

            return isRunning;
        }
        private Series GenSerisi()
        {

            flowLayoutPanel1.Controls.Clear();
            label11.Text = "Toplam:0";
            pictureBox1.Image = Properties.Resources.matyas;
            this.chart1.Series.Clear();
            Series series = this.chart1.Series.Add("Sonuclar");
            chart1.IsSoftShadows = false;

            series.ChartType = SeriesChartType.Area;
            series.BorderWidth = 3;
            series.Color = Color.IndianRed;
            return series;
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            if (!Durdur_Hesapla_kontrol()) return;

            Series series = GenSerisi();

            int popSayi = (int)numericUpDown1.Value;
            int elitPop = (int)numericUpDown5.Value;
            int iterasyon = (int)numericUpDown4.Value;
            double carazlamaOran = (double)numericUpDown2.Value / 100;
            double mutasyonOran = (double)numericUpDown3.Value / 100;
            int ms = (int)numericUpDown6.Value;

            GenetikAlgoritmaKontrolu GenDrv = new GenetikAlgoritmaKontrolu(popSayi);
            GenDrv.elitPop = elitPop;

            Image img = Properties.Resources.matyas;
            for (int j = 0; j < iterasyon; j++)
            {
                await Task.Delay(ms);
                GenDrv.Elitizm();
                GenDrv.TurnuvaCiftiOlustur();
                GenDrv.Caprazla(carazlamaOran);
                GenDrv.Mutasyon(mutasyonOran);

                EnIyiCanlilarPaneliOlustur(GenDrv.BestCanli());

                TabloOlustur(GenDrv.canliList, 10, colorDialog1.Color, img);
                TabloOlustur(GenDrv.elitList, 10, colorDialog2.Color, img);
                pictureBox1.Image = img;

                var eniyiSkor = GenDrv.BestCanli().Gen.MatyasFormulSkor * 10000;
                series.Points.AddXY(j, eniyiSkor);
                label8.Text = GenDrv.BestCanli().Gen.x1.ToString();
                label9.Text = GenDrv.BestCanli().Gen.x2.ToString();


                if (!isRunning) break;
                if (j == iterasyon - 1) Durdur_Hesapla_kontrol();
            }
        }


        public bool EnIyiCanlilarPaneliOlustur(Canli c)
        {
            foreach (var elitizm in flowLayoutPanel1.Controls.OfType<En_iyi_canli_gorunum>())
                if (c.Gen.MatyasFormulSkor == elitizm.Canli.Gen.MatyasFormulSkor)
                    return false;

            label11.Text = "Toplam:" + (flowLayoutPanel1.Controls.Count + 1);
            var comp = new En_iyi_canli_gorunum(c, flowLayoutPanel1.Controls.Count + 1);

            comp.pictureBox2.Click += (s, arg) =>
            {
                var canli = ((s as Control).Parent.Parent.Parent as En_iyi_canli_gorunum).Canli;
                var list = new List<Canli>();
                list.Add(canli);
                TabloOlustur(list, 20);
            };
            flowLayoutPanel1.Controls.Add(comp);
            return true;
        }


        private void buttonClr1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btn.BackColor = colorDialog1.Color;
            }
        }

        private void buttonClr2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                btn.BackColor = colorDialog2.Color;
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public static class GrafikUzantilari
    {
        public static void CemberCiz(this Graphics g, Pen pen,
            float centerX, float centerY, float radius)
        {
            g.DrawEllipse(pen, centerX - radius, centerY - radius,
                radius + radius, radius + radius);
        }

        public static void CemberDoldur(this Graphics g, Brush brush,
            float centerX, float centerY, float radius)
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius,
                radius + radius, radius + radius);
        }
    }

}
