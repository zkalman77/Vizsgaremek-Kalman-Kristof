using Orszagok_Dolgozat;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace orszagok
{
    public partial class Form1 : Form
    {
        private List<Orszag> orszagokLista = new List<Orszag>();
        private readonly string fajlNev = "orszagok.txt";

        public Form1()
        {
            InitializeComponent();
            AblakBeallitasok();
        }

        private void AblakBeallitasok()
        {
            this.Text = "Országok nyilvántartása";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightSkyBlue;
            this.Font = new Font("Segoe UI", 10);

            dgvOrszagok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrszagok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrszagok.ReadOnly = true;
        }

        private void TablazatFrissites(List<Orszag> lista)
        {
            dgvOrszagok.DataSource = null;
            dgvOrszagok.DataSource = lista;

            if (dgvOrszagok.Columns["Nev"] != null) dgvOrszagok.Columns["Nev"].HeaderText = "Ország";
            if (dgvOrszagok.Columns["Fovaros"] != null) dgvOrszagok.Columns["Fovaros"].HeaderText = "Főváros";
            if (dgvOrszagok.Columns["Lakossag"] != null)
            {
                dgvOrszagok.Columns["Lakossag"].HeaderText = "Lakosság";
                dgvOrszagok.Columns["Lakossag"].DefaultCellStyle.Format = "N0";
            }
        }

        private void btnBeolvasas_Click(object sender, EventArgs e)
        {
            if (!File.Exists(fajlNev))
            {
                MessageBox.Show("A fájl nem található!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            orszagokLista.Clear();
            try
            {
                string[] sorok = File.ReadAllLines(fajlNev, Encoding.UTF8);
                foreach (string sor in sorok)
                {
                    if (string.IsNullOrWhiteSpace(sor)) continue;

                    string[] adatok = sor.Split(';');
                    if (adatok.Length == 3 && int.TryParse(adatok[2].Trim(), out int lakossag))
                    {
                        orszagokLista.Add(new Orszag(adatok[0].Trim(), adatok[1].Trim(), lakossag));
                    }
                    else
                    {
                        MessageBox.Show($"Hibás adatsor a fájlban: {sor}", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                TablazatFrissites(orszagokLista);
                MessageBox.Show("Adatok sikeresen beolvasva!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHozzaadas_Click(object sender, EventArgs e)
        {
            string nev = txtOrszag.Text.Trim();
            string fovaros = txtFovaros.Text.Trim();
            string lakossagStr = txtLakossag.Text.Trim().Replace(" ", "");

            if (string.IsNullOrEmpty(nev) || string.IsNullOrEmpty(fovaros))
            {
                MessageBox.Show("Az ország és a főváros mező nem lehet üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(lakossagStr, out int lakossag) || lakossag <= 0)
            {
                MessageBox.Show("A lakosságnak pozitív egész számnak kell lennie!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            orszagokLista.Add(new Orszag(nev, fovaros, lakossag));

            try
            {
                File.AppendAllText(fajlNev, $"{nev};{fovaros};{lakossag}\n", Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mentési hiba: {ex.Message}", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            TablazatFrissites(orszagokLista);

            txtOrszag.Clear();
            txtFovaros.Clear();
            txtLakossag.Clear();
            txtOrszag.Focus();
        }

        private void btnKereses_Click(object sender, EventArgs e)
        {
            string keresendo = txtKereses.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keresendo))
            {
                TablazatFrissites(orszagokLista);
                return;
            }

            var talalatok = orszagokLista.Where(o => o.Nev.ToLower().Contains(keresendo) ||
                                                     o.Fovaros.ToLower().Contains(keresendo)).ToList();

            if (talalatok.Count == 0)
            {
                MessageBox.Show("Nincs a keresésnek megfelelő találat!", "Keresés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            TablazatFrissites(talalatok);
        }

        private void btnRendezes_Click(object sender, EventArgs e)
        {
            orszagokLista = orszagokLista.OrderByDescending(o => o.Lakossag).ToList();
            TablazatFrissites(orszagokLista);
        }
    }
}