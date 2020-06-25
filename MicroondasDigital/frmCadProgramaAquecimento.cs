using MicroondasDigital.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroOndasDigital
{
    public partial class frmCadProgramaAquecimento : Form
    {
        String strPath = (System.AppDomain.CurrentDomain.BaseDirectory.ToString());
        private string strNomeArquivo = "arquivoProgramasAquecimento.txt";
        private bool bAlterandoPrograma;
        List<ProgramasAquecimento> listPrograma = new List<ProgramasAquecimento>();

        public frmCadProgramaAquecimento()
        {
            InitializeComponent();
            carregarProgramas();
            limparCampos();
        }

        private void carregarProgramas()
        {
            int intQtdeItensComboBox = cboProgramas.Items.Count;
            string strNome = "";
            string strTempo = "";
            string strPotencia = "";
            string strCaracter = "";
            string strInstrucao = "";
            string[] lines = File.ReadAllLines(strNomeArquivo, Encoding.UTF8);

            listPrograma.Clear();
            cboProgramas.DataSource = null;
            cboProgramas.Items.Clear();

            foreach (var line in lines)
            {
                string[] programa = line.Split('✂');
                strNome = programa[0];
                strTempo = programa[1];
                strPotencia = programa[2];
                strCaracter = programa[3];
                strInstrucao = programa[4];

                listPrograma.Add(new ProgramasAquecimento(strNome, strTempo, Convert.ToInt16(strPotencia) - 1, Convert.ToChar(strCaracter), strInstrucao));
            }

            cboProgramas.DataSource = listPrograma;
            cboProgramas.DisplayMember = "Nome";
            cboProgramas.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvar()
        {   
            string strProgramaSalvo = "Programa salvo!";
            bAlterandoPrograma = (chkMostrarProgramas.Checked && !(cboProgramas.SelectedIndex.Equals(-1)));

            if (bCamposPreenchidos())
            {
                try
                {
                    String strPath = (System.AppDomain.CurrentDomain.BaseDirectory.ToString()) + strNomeArquivo;


                    if (bAlterandoPrograma)
                    {
                        excluir();
                        strProgramaSalvo = "Programa alterado!";
                        bAlterandoPrograma = false;
                    }

                    StreamWriter arquivoProgramasAquecimento = new StreamWriter(strPath, true);
                    arquivoProgramasAquecimento.WriteLine(identarPrograma(txtNome.Text, mtxtTempo.Text, Convert.ToString((cboPotencia.SelectedIndex) + 1),
                        txtCaracter.Text, rtfInstrucao.Text));

                    arquivoProgramasAquecimento.Close();
                    MessageBox.Show(strProgramaSalvo);
                    carregarProgramas();
                }
                catch (Exception E)
                {
                    MessageBox.Show(string.Format("Não foi possível salvar o programa. Erro: {0}",
                        E.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                limparCampos();
            }
        }

        private bool bCamposPreenchidos()
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Informe o nome do programa!");
                txtNome.Focus();
                return false;
            }

            string[] strTempo = mtxtTempo.Text.Split(':');
            if (string.IsNullOrWhiteSpace(strTempo[0]) && string.IsNullOrWhiteSpace(strTempo[1]))
            {
                MessageBox.Show("Informe o tempo do programa!");
                mtxtTempo.Focus();
                return false;
            }
            else
            {
                int intMinutos = Convert.ToInt16(strTempo[0]);
                int intSegundos = Convert.ToInt16(strTempo[1]);
                if (!bTempoValido(intMinutos, intSegundos))
                {
                    MessageBox.Show("Informe um tempo válido!");
                    mtxtTempo.Focus();
                    return false;
                }
            }

            if (cboPotencia.SelectedIndex == -1)
            {
                MessageBox.Show("Informe a potência do programa!");
                cboPotencia.Focus();
                return false;
            }

            if (txtCaracter.Text == string.Empty)
            {
                MessageBox.Show("Informe o caracter do programa!");
                txtCaracter.Focus();
                return false;
            }

            if (rtfInstrucao.Text == string.Empty)
            {
                MessageBox.Show("Informe as intruções de uso do programa!");
                rtfInstrucao.Focus();
                return false;
            }
            return true;
        }

        private bool bTempoValido(int _intMinutos, int _intSegundos)
        {
            if (_intMinutos > 2 || _intSegundos > 60)
            {
                return false;
            }

            if (_intMinutos.Equals(2) && _intSegundos > 0)
            {
                return false;
            }

            if (_intMinutos.Equals(0) && _intSegundos.Equals(0))
            {
                return false;
            }
            return true;
        }

        private string identarPrograma(string _strNome, string _strTempo, string _strPotencia, string _strCaracter, string _strInstrucao)
        {
            string programaIdentado = "";

            programaIdentado = _strNome + "✂" + _strTempo + "✂" + _strPotencia + "✂" + _strCaracter + "✂" + _strInstrucao;
            return programaIdentado;
        }

        private void btnAutoPreencher_Click(object sender, EventArgs e)
        {
            rtfInstrucao.Text = "Para aquecer usando esse programa, digite '" + txtNome.Text + "', na caixa de entrada e clique em 'Iniciar/Retomar'.";
        }

        private void cboProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboProgramas.SelectedIndex.Equals(-1))
            {
                rtfInstrucao.Clear();
                txtNome.Text = listPrograma.ElementAt(cboProgramas.SelectedIndex).Nome;
                mtxtTempo.Text = listPrograma.ElementAt(cboProgramas.SelectedIndex).Tempo;
                cboPotencia.SelectedIndex = listPrograma.ElementAt(cboProgramas.SelectedIndex).Potencia;
                txtCaracter.Text = listPrograma.ElementAt(cboProgramas.SelectedIndex).Caracter.ToString();
                rtfInstrucao.AppendText(listPrograma.ElementAt(cboProgramas.SelectedIndex).Instrucoes);
            }
        }

        private void chkMostrarProgramas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarProgramas.Checked){
                cboProgramas.Enabled = true;
            }
            else
            {
                cboProgramas.Enabled = false;
                limparCampos();
            }
        }

        private void limparCampos()
        {
            txtNome.Clear();
            mtxtTempo.Clear();
            cboPotencia.Text = "";
            cboPotencia.SelectedIndex = -1;
            cboProgramas.SelectedIndex = -1;
            txtCaracter.Clear();
            rtfInstrucao.Clear();
            chkMostrarProgramas.Checked = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluir();
        }

        private void excluir()
        {
            try
            {
                List<string> strLinhas = new List<string>();
                using (StreamReader arqLer = new StreamReader(strPath + strNomeArquivo))
                {
                    while (!arqLer.EndOfStream)
                    {
                        strLinhas.Add(arqLer.ReadLine());
                    }
                }

                strLinhas.RemoveAt(cboProgramas.SelectedIndex);

                using (StreamWriter arqEscrever = new StreamWriter(strPath + strNomeArquivo, false))
                {
                    foreach (string strLinha in strLinhas)
                    {
                        arqEscrever.WriteLine(strLinha);
                    }
                }
            }
            catch(Exception E)
            {
                MessageBox.Show(string.Format("Não foi possível excluir o programa. Erro: {0}",
                        E.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!bAlterandoPrograma)
            {
                MessageBox.Show("Programa excluído!");
                carregarProgramas();
                limparCampos();
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
