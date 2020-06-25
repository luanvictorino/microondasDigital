using MicroondasDigital.Models;
using MicroOndasDigital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroondasDigital
{
    public partial class FrmMicroondasDigital : Form
    {
        private int intMinutos = 0;
        private int intSegundos = 0;
        private string strCaracterAtual = ".";
        private bool bCadProgramaFechado = false;

        List<ProgramasAquecimento> listPrograma = new List<ProgramasAquecimento>();
        List<ProgramasAquecimento> listProgramaVazio = new List<ProgramasAquecimento>();

        public FrmMicroondasDigital()
        {
            InitializeComponent();
            carregarProgramas();
        }

        private void carregarProgramas()
        {
            int intQtdeItensComboBox = cboProgramas.Items.Count;
            string strNomeArquivo = "arquivoProgramasAquecimento.txt";
            String strPath = (System.AppDomain.CurrentDomain.BaseDirectory.ToString()) + strNomeArquivo;
            string strNome = "";
            string strTempo = "";
            string strPotencia = "";
            string strCaracter = "";
            string strInstrucao = "";

            if (!File.Exists(strPath))
            {
                StreamWriter arquivoProgramasAquecimento = new StreamWriter(strPath, true);

                arquivoProgramasAquecimento.WriteLine("Pizza✂01:00✂9✂!✂Para aquecer usando esse programa, " +
                    "digite 'Pizza', na caixa de entrada e clique em 'Iniciar/Retomar'.");

                arquivoProgramasAquecimento.WriteLine("Pipoca✂01:45✂6✂@✂Para aquecer usando esse programa, " +
                    "digite 'Pipoca', na caixa de entrada e clique em 'Iniciar/Retomar'.");

                arquivoProgramasAquecimento.WriteLine("Carne✂01:25✂7✂#✂Para aquecer usando esse programa, " +
                    "digite 'Carne', na caixa de entrada e clique em 'Iniciar/Retomar'.");

                arquivoProgramasAquecimento.WriteLine("Lasanha✂00:45✂8✂$✂Para aquecer usando esse programa, " +
                    "digite 'Lasanha', na caixa de entrada e clique em 'Iniciar/Retomar'.");

                arquivoProgramasAquecimento.WriteLine("Brigadeiro✂00:25✂3✂%✂Para aquecer usando esse programa, " +
                    "digite 'Brigadeiro', na caixa de entrada e clique em 'Iniciar/Retomar'.");

                arquivoProgramasAquecimento.Close();
            }

            string[] lines = File.ReadAllLines(strNomeArquivo, Encoding.UTF8);
            if (bCadProgramaFechado)
            {
                listPrograma.Clear();
                cboProgramas.DataSource = null;
                cboProgramas.Items.Clear();
                bCadProgramaFechado = false;
            }

            foreach (var line in lines)
            {
                string[] programa = line.Split('✂');
                strNome = programa[0];
                strTempo = programa[1];
                strPotencia = programa[2];
                strCaracter = programa[3];
                strInstrucao = programa[4];

                listPrograma.Add(new ProgramasAquecimento(strNome, strTempo, Convert.ToInt16(strPotencia)-1, 
                    Convert.ToChar(strCaracter), strInstrucao));
            }

            cboProgramas.DataSource = listPrograma;
            cboProgramas.DisplayMember = "Nome";
            cboProgramas.SelectedIndex = -1;
            cboProgramas.Enabled = false;
            rtfInstrucoesPrograma.Clear();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            iniciar();
        }

        private void iniciar()
        {
            bool bProgramasHabilitados = chkHabilitarProgramas.Checked;
            bool bProgramaSelecionado = cboProgramas.Text != "";

            habilitarBotoes(false);
            if (bProgramasHabilitados && !cboProgramas.SelectedIndex.Equals(-1))
            {
                if (bProgramaSelecionado)
                {
                    definirProgramaSelecionado();
                    definirTempo();
                }
                else 
                {
                    MessageBox.Show("Escolha um programa!");
                }
            }
            else
            {
                definirTempo();
            }
        }

        private void definirProgramaSelecionado()
        {
            if (bProgramaEhCompativel())
            {
                if (lbTemporizador.Text.Equals("00:00"))
                {
                    rtfForno.Clear();
                    strCaracterAtual = listPrograma.ElementAt(cboProgramas.SelectedIndex).Caracter.ToString();
                    lbTemporizador.Text = listPrograma.ElementAt(cboProgramas.SelectedIndex).Tempo;
                    mtxtTemporizador.Text = lbTemporizador.Text;
                    cboPotencia.SelectedIndex = listPrograma.ElementAt(cboProgramas.SelectedIndex).Potencia;
                    txtAquecer.Text = listPrograma.ElementAt(cboProgramas.SelectedIndex).Nome;
                }
            }
            else
            {
                throw new Exception("Programa incompatível com o tipo de alimento!");
            }
        }

        private bool bProgramaEhCompativel()
        {
            string strProgramaSelecionado = listPrograma.ElementAt(cboProgramas.SelectedIndex).Nome;
            return txtAquecer.Text.ToLower().Equals(strProgramaSelecionado.ToLower());
        }

        private void definirTempo()
        {
            bool bTemporizadorZerado = lbTemporizador.Text.Equals("00:00");
            if (bTemporizadorZerado)
            {
                string[] strTempo = mtxtTemporizador.Text.Split(':');
                rtfForno.Clear();

                if (string.IsNullOrWhiteSpace(txtAquecer.Text))
                    throw new Exception("Informe o que deseja aquecer!");

                if (string.IsNullOrWhiteSpace(strTempo[0]) && string.IsNullOrWhiteSpace(strTempo[1]))
                    throw new Exception("Informe o tempo!");

                verificarPotencia();
                intMinutos = strToIntDef((strTempo[0]), 0);
                intSegundos = strToIntDef((strTempo[1]), 0);

                if (bTempoValido(intMinutos, intSegundos))
                {
                    tmrTemporizador.Enabled = true;
                    rtfForno.Clear();
                }
                else
                {
                    throw new Exception("Informe um tempo válido!");
                }
            }
            else
            {
                retomar();
            }
        }

        private int strToIntDef(string _str, int @default)
        {
            int numero;
            if (int.TryParse(_str, out numero))
                return numero;
            return @default;
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

        private void retomar()
        {
            string[] strTempo = lbTemporizador.Text.Split(':');
            verificarPotencia();
            intMinutos = Convert.ToInt16(strTempo[0]);
            intSegundos = Convert.ToInt16(strTempo[1]);
            tmrTemporizador.Enabled = true;
        }

        private void verificarPotencia()
        {
            if (cboPotencia.SelectedIndex.Equals(-1))
            {
                cboPotencia.SelectedIndex = cboPotencia.Items.Count - 1;
            }
        }

        private void tmrTemporizador_Tick(object sender, EventArgs e)
        {
            intSegundos--;
            if (intMinutos > 0)
            {
                if (intSegundos < 0)
                {
                    intSegundos = 59;
                    intMinutos--;
                }
            }

            if (!chkHabilitarProgramas.Checked)
                strCaracterAtual = ".";

            adicionarCaracter(strCaracterAtual);
            mostrarContador();
            
            if (intMinutos == 0 && intSegundos == 0)
            {
                tmrTemporizador.Enabled = false;
                rtfForno.AppendText(" aquecida!!");
                habilitarBotoes(true);
            }
        }

        private void habilitarBotoes(bool _bAtivado)
        {
            chkHabilitarProgramas.Enabled = _bAtivado;
            mtxtTemporizador.Enabled = _bAtivado;
            cboPotencia.Enabled = _bAtivado;

            if (chkHabilitarProgramas.Checked)
            {
                if (cboProgramas.SelectedIndex.Equals(-1))
                {
                    chkHabilitarProgramas.Checked = false;
                }
                btnCadastrar.Enabled = _bAtivado;
                cboProgramas.Enabled = _bAtivado;
            }
            else
            {
                btnCadastrar.Enabled = false;
                cboProgramas.Enabled = false;
            }
        }

        public void adicionarCaracter(string _strCaracterAtual)
        {
            int intPotencia = cboPotencia.SelectedIndex;
            string strCaracter = "";

            for (int i = 0; i <= intPotencia; i++)
            {
                strCaracter = strCaracter + _strCaracterAtual;
            }

            rtfForno.AppendText(strCaracter);
        }

        private void mostrarContador()
        {
            if (intSegundos < 10)
            {
                lbTemporizador.Text = "0" + intMinutos + ":0" + intSegundos;
            }
            else
            {
                lbTemporizador.Text = "0" + intMinutos + ":" + intSegundos;
            }
        }

        private void btnInicioRapido_Click(object sender, EventArgs e)
        {
            inicioRapido();
        }

        private void inicioRapido()
        {
            if (cboProgramas.SelectedIndex.Equals(-1))
            {
                rtfForno.Clear();
                lbTemporizador.Text = "00:30";
                mtxtTemporizador.Text = lbTemporizador.Text;
                cboPotencia.SelectedIndex = 7;
                iniciar();
            }
            else
            {
                iniciar();
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            parar();
        }

        private void parar()
        {
            tmrTemporizador.Stop();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void cancelar()
        {
            tmrTemporizador.Stop();
            lbTemporizador.Text = "00:00";
            rtfForno.Clear();
            habilitarBotoes(true);

            if (chkHabilitarProgramas.Checked)
            {
                mtxtTemporizador.Enabled = false;
                cboPotencia.Enabled = false;
            }
        }


        private void cbxHabilitarProgramas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitarProgramas.Checked)
            {
                rtfForno.Clear();
                lbTemporizador.Text = "00:00";
                tmrTemporizador.Enabled = false;
                mtxtTemporizador.Enabled = false;
                cboPotencia.Enabled = false;
                cboProgramas.Enabled = true;
                btnCadastrar.Enabled = true;
            }
            else
            {
                mtxtTemporizador.Enabled = true;
                cboPotencia.Enabled = true;
                cboProgramas.Enabled = false;
                btnCadastrar.Enabled = false;
                rtfInstrucoesPrograma.Clear();
                cboProgramas.SelectedIndex = -1;
            }
        }

        private void cbbProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboProgramas.SelectedIndex.Equals(-1))
            {
                rtfInstrucoesPrograma.Clear();
                rtfInstrucoesPrograma.AppendText(listPrograma.ElementAt(cboProgramas.SelectedIndex).Instrucoes);
            }
                
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadProgramaAquecimento FrmCadProgramaAquecimento = new frmCadProgramaAquecimento();
            FrmCadProgramaAquecimento.ShowDialog();

            if (FrmCadProgramaAquecimento.DialogResult == DialogResult.Cancel)
            {
                bCadProgramaFechado = true;
                carregarProgramas();
                cboProgramas.Enabled = true;
            }
        }
    }
}
