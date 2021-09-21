using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Urna_Eletronica
{
    public partial class Form1 : Form
    {
        int Eleitores, canda, candb, candc, candd, vencedor;
        string vencedorVotos;

        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipText = "Executando";
            notifyIcon1.ShowBalloonTip(6000);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCandA_Click(object sender, EventArgs e)
        {
            ++canda;
            if (canda > vencedor) vencedorVotos = "Candidato A";
            vencedor = canda;
            ++Eleitores;
         }

        private void btnCandB_Click(object sender, EventArgs e)
        {
            ++candb;
            if (candb > vencedor) vencedorVotos = "Candidato B";
            vencedor = candb;
            Eleitores++;
        }

        private void btnCandC_Click(object sender, EventArgs e)
        {
            ++candc;
            if (candc > vencedor) vencedorVotos = "Candidato C";
            vencedor = candc;
            Eleitores++;
        }
        private void btnCandD_Click(object sender, EventArgs e)
        {
            ++candd;
            if (candd > vencedor) vencedorVotos = "Candidato D";
            vencedor = candd;
            Eleitores++;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            btnEncerrar.Enabled = false;
            lblVotosA.Text = canda.ToString();
            lblVotosB.Text = candb.ToString();
            lblVotosC.Text = candc.ToString();
            lblVotosD.Text = candd.ToString();

            lblPorA.Text = ((double)canda / (double)Eleitores).ToString("P2");
            lblPorB.Text = ((double)candb / (double)Eleitores).ToString("P2");
            lblPorC.Text = ((double)candc / (double)Eleitores).ToString("P2");
            lblPorD.Text = ((double)candd / (double)Eleitores).ToString("P2");

            lblVencedor.Text = vencedorVotos;
        }

    }
}
