using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AutoRendezes
{
    public partial class Form1 : Form
    {
        private List<Auto> autok = new List<Auto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeolvas_Click(object sender, EventArgs e)
        {
            try
            {
                autok.Clear();
                listBox1.Items.Clear();
                string fajl = Path.Combine(AppContext.BaseDirectory, "adat.txt");

                foreach (string sor in File.ReadAllLines(fajl))
                {
                    if (string.IsNullOrWhiteSpace(sor)) continue;
                    string[] adat = sor.Split(',');
                    if (adat.Length == 2 && int.TryParse(adat[1], out int ev))
                    {
                        Auto auto = new Auto();
                        auto.Marka = adat[0].Trim();
                        auto.Ev = ev;

                        autok.Add(auto);
                        listBox1.Items.Add(auto);
                    }
                }
                lblInfo.Text = "Beolvasva: " + autok.Count + " autó";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}