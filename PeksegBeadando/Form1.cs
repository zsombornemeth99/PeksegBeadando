﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeksegBeadando
{
    public partial class PeksegForm : Form
    {
        public PeksegForm()
        {
            InitializeComponent();
        }

        private void txtBx_ar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBx_nev_Enter(object sender, EventArgs e)
        {
            txtBx_nev.ForeColor = Color.Black;
            //Placeholder
            if (txtBx_nev.Text == "Írja be a pékáru nevét..")
            {
                txtBx_nev.Text = "";
            }
        }

        private void txtBx_nev_Leave(object sender, EventArgs e)
        {
            //Placeholder
            if (txtBx_nev.Text == "")
            {
                txtBx_nev.ForeColor = Color.Gray;
                txtBx_nev.Text = "Írja be a pékáru nevét..";
            }
        }

        private void txtBx_ar_Enter(object sender, EventArgs e)
        {
            txtBx_ar.ForeColor = Color.Black;
            //Placeholder
            if (txtBx_ar.Text == "Írja be az árat..")
            {
                txtBx_ar.Text = "";
            }
        }

        private void txtBx_ar_Leave(object sender, EventArgs e)
        {
            //Placeholder
            if (txtBx_ar.Text == "")
            {
                txtBx_ar.ForeColor = Color.Gray;
                txtBx_ar.Text = "Írja be az árat..";
            }
        }

        private void bttn_hozzaadasPekaru_Click(object sender, EventArgs e)
        {
            if (bttn_hozzaadasPekaru.Text == "Hozzáadás")
            {
                if (txtBx_ar.Text == "Írja be az árat.." || txtBx_nev.Text == "Írja be a pékáru nevét..")
                {
                    MessageBox.Show("Ellenőrízze, hogy mindent kitöltött e!", "Hiba!");
                }
                else
                {
                    Pekaru p = new Pekaru
                    {
                        Ar = int.Parse(txtBx_ar.Text),
                        Nev = txtBx_nev.Text,
                        Laktozmentes = chckBx_laktoz.Checked ? true : false
                    };
                    lstBx_pekaru.Items.Add(p);
                    txtBx_ar.ForeColor = Color.Gray;
                    txtBx_nev.ForeColor = Color.Gray;
                    txtBx_ar.Text = "Írja be az árat..";
                    txtBx_nev.Text = "Írja be a pékáru nevét..";
                    chckBx_laktoz.Checked = false;
                }
            }            
            else
            {
                if (txtBx_ar.Text == "Írja be az árat.." || txtBx_nev.Text == "Írja be a pékáru nevét..")
                {
                    MessageBox.Show("Ellenőrízze, hogy mindent kitöltött e!", "Hiba!");
                }
                else
                {
                    Pekaru p = (Pekaru)lstBx_pekaru.SelectedItem;
                    p.Nev = txtBx_nev.Text;
                    p.Ar = int.Parse(txtBx_ar.Text);
                    p.Laktozmentes = chckBx_laktoz.Checked ? true : false;
                    lstBx_pekaru.Refresh();
                    txtBx_ar.ForeColor = Color.Gray;
                    txtBx_nev.ForeColor = Color.Gray;
                    txtBx_ar.Text = "Írja be az árat..";
                    txtBx_nev.Text = "Írja be a pékáru nevét..";
                    chckBx_laktoz.Checked = false;
                    bttn_hozzaadasPekaru.Text = "Hozzáadás";
                }
            }
        }

        private void lstBx_pekaru_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstBx_pekaru.SelectedItem != null)
            {
                bttn_hozzaadasPekaru.Text = "Módosít";
                Pekaru p = (Pekaru)lstBx_pekaru.SelectedItem;
                txtBx_nev.Text = p.Nev;
                txtBx_ar.Text = p.Ar.ToString();
                if (p.Laktozmentes)
                    chckBx_laktoz.Checked = true;
                else
                    chckBx_laktoz.Checked = false;
            }
        }

        private void lstBx_pekaru_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstBx_pekaru.SelectedItem != null)
            {
                var result = MessageBox.Show("Biztos törli a kijelölt elemet?", "Törlés", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    lstBx_pekaru.Items.Remove(lstBx_pekaru.SelectedItem);
                    txtBx_ar.ForeColor = Color.Gray;
                    txtBx_nev.ForeColor = Color.Gray;
                    txtBx_ar.Text = "Írja be az árat..";
                    txtBx_nev.Text = "Írja be a pékáru nevét..";
                    chckBx_laktoz.Checked = false;
                }
            }
        }

        private void txtBx_pekseg_Enter(object sender, EventArgs e)
        {
            txtBx_pekseg.ForeColor = Color.Black;
            //Placeholder
            if (txtBx_pekseg.Text == "Írja be a pékség nevét..")
            {
                txtBx_pekseg.Text = "";
            }
        }

        private void txtBx_pekseg_Leave(object sender, EventArgs e)
        {
            //Placeholder
            if (txtBx_pekseg.Text == "")
            {
                txtBx_pekseg.ForeColor = Color.Gray;
                txtBx_pekseg.Text = "Írja be a pékség nevét..";
            }
        }

        private void bttn_hozzaadasPekseg_Click(object sender, EventArgs e)
        {
            if (txtBx_pekseg.Text == "Írja be a pékség nevét..")
            {
                MessageBox.Show("Ellenőrízze, hogy mindent kitöltött e!", "Hiba!");
            }
            else
            {
                Pekseg p = new Pekseg
                {
                    Nev = txtBx_pekseg.Text,
                    Termekek = new List<Pekaru>(),
                    Alapitva = DateTime.Now
                };
                lstBx_peksegek.Items.Add(p);
                txtBx_pekseg.ForeColor = Color.Gray;
                txtBx_pekseg.Text = "Írja be a pékség nevét..";
            }
        }

        private void lstBx_peksegek_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstBx_peksegek.SelectedItem != null)
            {
                var p = (Pekseg)lstBx_peksegek.SelectedItem;
                if (p.Termekek != null)
                {
                    lstBx_peksegTermekei.Items.Clear();
                    foreach (var item in p.Termekek)
                    {
                        lstBx_peksegTermekei.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Még nincs a pékséghez termék társítva!", "Hiba!");
                }
            }
        }

        private void bttn_plusz_Click(object sender, EventArgs e)
        {
            if (lstBx_pekaru.SelectedItem != null && lstBx_peksegek.SelectedItem != null)
            {
                var p = (Pekseg)lstBx_peksegek.SelectedItem;
                p.Termekek.Add((Pekaru)lstBx_pekaru.SelectedItem);
                lstBx_peksegTermekei.Items.Clear();
                foreach (var item in p.Termekek)
                {
                    lstBx_peksegTermekei.Items.Add(item);
                }
                lstBx_pekaru.SelectedItem = null;
            }
        }

        private void lstBx_pekaru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBx_pekaru.SelectedItem == null)
            {
                txtBx_ar.ForeColor = Color.Gray;
                txtBx_nev.ForeColor = Color.Gray;
                txtBx_ar.Text = "Írja be az árat..";
                txtBx_nev.Text = "Írja be a pékáru nevét..";
                chckBx_laktoz.Checked = false;
                bttn_hozzaadasPekaru.Text = "Hozzáadás";
            }
        }

        private void lstBx_peksegek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBx_peksegek.SelectedItem == null)
            {
                txtBx_pekseg.ForeColor = Color.Gray;
                txtBx_pekseg.Text = "Írja be a pékség nevét..";
                lstBx_peksegTermekei.Items.Clear();
            }
        }
    }
}
