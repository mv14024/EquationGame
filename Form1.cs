using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestIgrica
{
    public partial class Form1 : Form
    {
        public void SmanjiZivot()
        {
            if (prviZivot.Visible == true)
            {
                prviZivot.Visible = false;
                preostaloVreme += 10;
            }
            else if (drugiZivot.Visible == true)
            {
                drugiZivot.Visible = false;
                preostaloVreme += 10;
            }
            else
            {
                treciZivot.Visible = false;
                Jednacina.Text = "IZGUBILI STE :(";
                timer1.Stop();
                PreostaloV.Visible = false;
                labelVreme.Visible = false;
            }
        }
        public void PostaviResenja()
        {
            resenje12.Visible = true;
            resenje_8.Visible = true;
            resenje7.Visible = true;
            resenje_5.Visible = true;
            resenje11.Visible = true;
            resenje_9.Visible = true;
            resenje15.Visible = true;
            resenje_6.Visible = true;
            resenje4.Visible = true;
            resenje10.Visible = true;
            resenje_7.Visible = true;
            resenje_10.Visible = true;
        }
        public void PromeniVremeIPoene()
        {
            brojPoena += 2 * preostaloVreme;
            BrojPoena.Text = brojPoena.ToString();
            preostaloVreme = 20;
            PreostaloV.Text = preostaloVreme.ToString();
        }
        public void PromeniBoju()
        {
            Random rand = new Random();
            Color randBoja = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            Jednacina.ForeColor = randBoja;
        }
        public int preostaloVreme;
        public int brojPoena = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            resenje15.Text = 10.ToString();
        } 

        private void label11_Click(object sender, EventArgs e)
        {
            resenje_6.Text = 11.ToString();

        } 

        private void ZapocniIgru_Click(object sender, EventArgs e)
        {
            ZapocniIgru.Visible = false;
            preostaloVreme = 20;
            timer1.Start();
            Jednacina.Text = "2X - 5 = 3";
            PostaviResenja();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();
            timer2.Enabled = true;
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (preostaloVreme > 0)
            {
                preostaloVreme--;
                PreostaloV.Text = preostaloVreme.ToString();
            }
            if (preostaloVreme == 0)
                SmanjiZivot();

        }

        private void balon4_Click(object sender, EventArgs e)
        {
            if (Jednacina.Text.Equals("2X - 5 = 3"))
            {
                balon4.Visible = false;
                resenje4.Visible = false;
                PromeniVremeIPoene();
                PromeniBoju();
                Jednacina.Text = "3X + 4 = -11";
            }
            else
                SmanjiZivot();
        }

        private void balon_5_Click(object sender, EventArgs e)
        {
            if (Jednacina.Text.Equals("3X + 4 = -11"))
            {
                balon_5.Visible = false;
                resenje_5.Visible = false;
                PromeniVremeIPoene();
                PromeniBoju();
                Jednacina.Text = "-15 + X = -3";
            }
            else
                SmanjiZivot();
        }

        private void balon12_Click(object sender, EventArgs e)
        {
            if (Jednacina.Text.Equals("-15 + X = -3"))
            {
                balon12.Visible = false;
                resenje12.Visible = false;
                PromeniVremeIPoene();
                PromeniBoju();
                Jednacina.Text = "4X + 20 = -12";
            }
            else
                SmanjiZivot();
        }

        private void balon_8_Click(object sender, EventArgs e)
        {
            if (Jednacina.Text.Equals("4X + 20 = -12"))
            {
                balon_8.Visible = false;
                resenje_8.Visible = false;
                PromeniVremeIPoene();
                PromeniBoju();
                Jednacina.Text = "2X - 20 = 10";
            }
            else
                SmanjiZivot();
        }

        private void balon15_Click(object sender, EventArgs e)
        {
            if (Jednacina.Text.Equals("2X - 20 = 10"))
            {
                balon15.Visible = false;
                resenje15.Visible = false;
                PromeniVremeIPoene();
                PromeniBoju();
                Jednacina.Text = "27 - 5X = -23";
            }
            else
                SmanjiZivot();
        }

        private void balon10_Click(object sender, EventArgs e)
        {
            if (Jednacina.Text.Equals("27 - 5X = -23"))
            {
                balon10.Visible = false;
                resenje10.Visible = false;
                PromeniVremeIPoene();
                PromeniBoju();
                Jednacina.Text = "4X + 40 = 4";
            }
            else
                SmanjiZivot();
        }

        private void balon_9_Click(object sender, EventArgs e)
        {
            if (Jednacina.Text.Equals("4X + 40 = 4"))
            {
                balon_9.Visible = false;
                resenje_9.Visible = false;
                PromeniVremeIPoene();
                PromeniBoju();
                Jednacina.Text = "3X - 30 = 3";
            }
            else
                SmanjiZivot();
        }

        private void balon11_Click(object sender, EventArgs e)
        {
            if (Jednacina.Text.Equals("3X - 30 = 3"))
            {
                balon11.Visible = false;
                resenje11.Visible = false;
                PromeniVremeIPoene();
                PromeniBoju();
                Jednacina.Text = "20 + 4X = -20";
            }
            else
                SmanjiZivot();
        }

        private void balon_10_Click(object sender, EventArgs e)
        {
            if (Jednacina.Text.Equals("20 + 4X = -20"))
            {
                balon_10.Visible = false;
                resenje_10.Visible = false;
                PromeniVremeIPoene();
                PromeniBoju();
                Jednacina.Text = "3X - 13 = 8";
            }
            else
                SmanjiZivot();
        }

        private void balon7_Click(object sender, EventArgs e)
        {
            if (Jednacina.Text.Equals("3X - 13 = 8"))
            {
                balon7.Visible = false;
                resenje7.Visible = false;
                PromeniVremeIPoene();
                PromeniBoju();
                Jednacina.Text = "-11 - 6X = 31";
            }
            else
                SmanjiZivot();
        }

        private void balon_7_Click(object sender, EventArgs e)
        {
            if (Jednacina.Text.Equals("-11 - 6X = 31"))
            {
                balon_7.Visible = false;
                resenje_7.Visible = false;
                PromeniVremeIPoene();
                PromeniBoju();
                Jednacina.Text = "23 - 5X = 53";
            }
            else
                SmanjiZivot();
        }

        private void balon_6_Click(object sender, EventArgs e)
        {
            if (Jednacina.Text.Equals("23 - 5X = 53"))
            {
                balon_6.Visible = false;
                resenje_6.Visible = false;
                PromeniVremeIPoene();
                Jednacina.Text = "POBEDILI STE! :)";
                timer1.Stop();
                PreostaloV.Visible = false;
                labelPoeni.Visible = false;
                labelVreme.Visible = false;
                BrojPoena.Visible = false;
                KrajnjiRezultat.Visible = true;
                RezultatIspis.Text = brojPoena.ToString();
                timer2.Start();
                if (prviZivot.Visible == true)
                {
                    brojPoena += 50;
                    RezultatIspis.Text = brojPoena.ToString();
                }
                if (drugiZivot.Visible == true)
                {
                    brojPoena += 50;
                    RezultatIspis.Text = brojPoena.ToString();
                }
                if (treciZivot.Visible == true)
                {
                    brojPoena += 50;
                    RezultatIspis.Text = brojPoena.ToString();
                }
            }
            else
                SmanjiZivot();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int formWidth = this.Width;
            int formHeight = this.Height;
            if (prviZivot.Visible == true)
            {
                if (prviZivot.Location.X < formWidth - prviZivot.Width - 20)
                    prviZivot.Location = new Point(prviZivot.Location.X + 5, prviZivot.Location.Y);
            }
            if (drugiZivot.Visible == true)
            {
                if (drugiZivot.Location.Y < formHeight - 2*drugiZivot.Height + 5)
                    drugiZivot.Location = new Point(drugiZivot.Location.X + 5, drugiZivot.Location.Y + 5);
            }
            if (treciZivot.Visible == true)
                if (treciZivot.Location.Y < formHeight - 2*treciZivot.Height + 5)
                    treciZivot.Location = new Point(treciZivot.Location.X, treciZivot.Location.Y + 5);
        }
    }
}
