using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjFormClasse
{
    public partial class frmFormClasse : Form
    {
        public frmFormClasse()
        {
            InitializeComponent();        
        }

        #region Calcular
        private void btnCalc_Click(object sender, EventArgs e)
        {
            prjClasse.segundo_grau segundo_grau = new prjClasse.segundo_grau();

            try
            {
                segundo_grau.a = double.Parse(txtA.Text);
                segundo_grau.b = double.Parse(txtB.Text);
                segundo_grau.c = double.Parse(txtC.Text);
            }
            catch
            {
                MessageBox.Show("Insira somente números", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus();
                return;
            }

            lstRes.Items.Clear();
            #region caixa de If's
            if (segundo_grau.delta < 0)
            {
                lstRes.Items.Add("∆ = " + segundo_grau.b + "² – 4 * " + segundo_grau.a + " * " + segundo_grau.c);
                lstRes.Items.Add("∆ = " + segundo_grau.delta.ToString());
                lstRes.Items.Add("-----------------------------------");
                lstRes.Items.Add("");
                lstRes.Items.Add("Delta negativo não possui raízes reais!");

                if (segundo_grau.a > 0)
                {
                    pcbGrafico.Image = Properties.Resources.DME0AMA0;
                }
                else
                {
                    pcbGrafico.Image = Properties.Resources.DME0AME0;
                }
            }
            else
            {
                if (segundo_grau.delta == 0)
                {
                    lstRes.Items.Add("∆ = " + segundo_grau.b + "² – 4 * " + segundo_grau.a + " * " + segundo_grau.c);
                    lstRes.Items.Add("∆ = " + segundo_grau.delta.ToString());
                    lstRes.Items.Add("-----------------------------------");
                    lstRes.Items.Add("x = - (" + segundo_grau.b + ") + - √ " + segundo_grau.delta + "/ 2 * " + segundo_grau.a);
                    lstRes.Items.Add("");
                    lstRes.Items.Add("x¹ = " + segundo_grau.x1.ToString());
                    lstRes.Items.Add("x² = " + segundo_grau.x2.ToString());

                    if (segundo_grau.a > 0)
                    {
                        pcbGrafico.Image = Properties.Resources.D0AMA0;
                    }
                    else
                    {
                        pcbGrafico.Image = Properties.Resources.D0AME0;
                    }
                }
                else
                {
                    lstRes.Items.Add("∆ = " + segundo_grau.b + "² – 4 * " + segundo_grau.a + " * " + segundo_grau.c);
                    lstRes.Items.Add("∆ = " + segundo_grau.delta.ToString());
                    lstRes.Items.Add("-----------------------------------");
                    lstRes.Items.Add("x = - (" + segundo_grau.b + ") + - √ " + segundo_grau.delta + "/ 2 * " + segundo_grau.a);
                    lstRes.Items.Add("");
                    lstRes.Items.Add("x¹ e x² = " + segundo_grau.x1);

                    if (segundo_grau.a > 0)
                    {
                        pcbGrafico.Image = Properties.Resources.DMA0AMA0;
                    }
                    else
                    {
                        pcbGrafico.Image = Properties.Resources.DMA0AME0;
                    }
                }
            }
            #endregion
        }
        #endregion

        #region Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Focus();
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            lstRes.Items.Clear();
            pcbGrafico.Image = Properties.Resources.baskara;
        }
        #endregion

    }
}
