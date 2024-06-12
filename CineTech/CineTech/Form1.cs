using CineTech.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace CineTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarImagem();
        }

        private void btnConfirmar_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmar.BackColor = Color.Blue;
        }

        private void btnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmar.BackColor= Color.White;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnAssistir_MouseEnter(object sender, EventArgs e)
        {
            btnAssistir.BackColor = Color.Blue;

        }

        private void btnAssistir_MouseLeave(object sender, EventArgs e)
        {
            btnAssistir.BackColor = Color.White;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var filme = cmbFilme.Text;
            try
            {
                if (cmbFilme.SelectedIndex != null)
                {
                    // A ComboBox está preenchida com valores
                    panelCompletarDados.Visible = true;
                }
                else
                {
                    // A ComboBox está vazia
                    MessageBox.Show("Você precisa escolher um filme.");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtNascimento_TextChanged(object sender, EventArgs e)
        {
            var idade = txtNascimento.Text;
            int idadeMenor = DateTime.Now.Year; 
            var permitir = int.Parse(idade) - idadeMenor;
            
            if(permitir > 0) 
            {
                MessageBox.Show("Deu certo :)");

            }
        }

        private void CarregarImagem() {
            cmbFilme.Items.Add(" Poderoso Chefão");
            cmbFilme.Items.Add(" A Origem");
            cmbFilme.Items.Add(" O Senhor dos Anéis: O Retorno do Rei");
            cmbFilme.Items.Add(" O Grande Lebowski");
            cmbFilme.Items.Add(" Clube da Luta");
            cmbFilme.Items.Add(" O Labirinto do Fauno");
            cmbFilme.Items.Add(" Cidade de Deus");
            cmbFilme.Items.Add(" Forrest Gump");

            cmbFilme.SelectedIndexChanged += cmbFilme_SelectedIndexChanged;
        }    
        private void cmbFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeDoFilme = cmbFilme.SelectedItem.ToString();
            switch (nomeDoFilme)
            {
                case "O Poderoso Chefão":
                    PbFilmes.Image = Resources.OPoderosoChefão;
                    break;
                case "A Origem":
                    PbFilmes.Image = Properties.Resources.AOrigem;
                    break;
                case "O Senhor dos Anéis: O Retorno do Rei":
                    PbFilmes.Image = Resources.OSenhordosAnéisORetornodoRei;
                    break;
                case "Clube da Luta":
                    PbFilmes.Image = Resources.OSenhordosAnéisORetornodoRei;
                    break;
                case "O Grande Lebowski":
                    PbFilmes.Image = Resources.OGrandeLebowski;
                    break;
                case "O Labirinto do Fauno":
                    PbFilmes.Image = Resources.OLabirintodoFauno;
                    break;
                case "Cidade de Deus":
                    PbFilmes.Image = Resources.CidadedeDeus;
                    break;
                case " Forrest Gump":
                    PbFilmes.Image = Resources.ForrestGump;
                    break;
                default:
                    PbFilmes.Image = null;
                    break;
            }
        }
    }
}
