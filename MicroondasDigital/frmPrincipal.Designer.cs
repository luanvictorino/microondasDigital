namespace MicroondasDigital
{
    partial class FrmMicroondasDigital
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMicroondasDigital));
            this.txtAquecer = new System.Windows.Forms.TextBox();
            this.lbComida = new System.Windows.Forms.Label();
            this.lbTempo = new System.Windows.Forms.Label();
            this.lbPotencia = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lbTemporizador = new System.Windows.Forms.Label();
            this.tmrTemporizador = new System.Windows.Forms.Timer(this.components);
            this.mtxtTemporizador = new System.Windows.Forms.MaskedTextBox();
            this.cboPotencia = new System.Windows.Forms.ComboBox();
            this.btnInicioRapido = new System.Windows.Forms.Button();
            this.rtfForno = new System.Windows.Forms.RichTextBox();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboProgramas = new System.Windows.Forms.ComboBox();
            this.chkHabilitarProgramas = new System.Windows.Forms.CheckBox();
            this.grpPrincipal = new System.Windows.Forms.GroupBox();
            this.grpProgramas = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.rtfInstrucoesPrograma = new System.Windows.Forms.RichTextBox();
            this.lbInstrucoes = new System.Windows.Forms.Label();
            this.grpPrincipal.SuspendLayout();
            this.grpProgramas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAquecer
            // 
            this.txtAquecer.Location = new System.Drawing.Point(19, 35);
            this.txtAquecer.Name = "txtAquecer";
            this.txtAquecer.Size = new System.Drawing.Size(209, 20);
            this.txtAquecer.TabIndex = 1;
            // 
            // lbComida
            // 
            this.lbComida.AutoSize = true;
            this.lbComida.Location = new System.Drawing.Point(16, 19);
            this.lbComida.Name = "lbComida";
            this.lbComida.Size = new System.Drawing.Size(50, 13);
            this.lbComida.TabIndex = 3;
            this.lbComida.Text = "Aquecer:";
            // 
            // lbTempo
            // 
            this.lbTempo.AutoSize = true;
            this.lbTempo.Location = new System.Drawing.Point(16, 58);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(43, 13);
            this.lbTempo.TabIndex = 4;
            this.lbTempo.Text = "Tempo:";
            // 
            // lbPotencia
            // 
            this.lbPotencia.AutoSize = true;
            this.lbPotencia.Location = new System.Drawing.Point(123, 58);
            this.lbPotencia.Name = "lbPotencia";
            this.lbPotencia.Size = new System.Drawing.Size(52, 13);
            this.lbPotencia.TabIndex = 5;
            this.lbPotencia.Text = "Potência:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(19, 105);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(102, 23);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iníciar/Retomar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lbTemporizador
            // 
            this.lbTemporizador.AutoSize = true;
            this.lbTemporizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemporizador.Location = new System.Drawing.Point(672, 12);
            this.lbTemporizador.Name = "lbTemporizador";
            this.lbTemporizador.Size = new System.Drawing.Size(92, 33);
            this.lbTemporizador.TabIndex = 0;
            this.lbTemporizador.Text = "00:00";
            // 
            // tmrTemporizador
            // 
            this.tmrTemporizador.Interval = 1000;
            this.tmrTemporizador.Tick += new System.EventHandler(this.tmrTemporizador_Tick);
            // 
            // mtxtTemporizador
            // 
            this.mtxtTemporizador.Location = new System.Drawing.Point(19, 74);
            this.mtxtTemporizador.Mask = "00:00";
            this.mtxtTemporizador.Name = "mtxtTemporizador";
            this.mtxtTemporizador.Size = new System.Drawing.Size(57, 20);
            this.mtxtTemporizador.TabIndex = 2;
            this.mtxtTemporizador.ValidatingType = typeof(System.DateTime);
            // 
            // cboPotencia
            // 
            this.cboPotencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPotencia.FormattingEnabled = true;
            this.cboPotencia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboPotencia.Location = new System.Drawing.Point(126, 74);
            this.cboPotencia.Name = "cboPotencia";
            this.cboPotencia.Size = new System.Drawing.Size(46, 21);
            this.cboPotencia.TabIndex = 3;
            // 
            // btnInicioRapido
            // 
            this.btnInicioRapido.Location = new System.Drawing.Point(126, 105);
            this.btnInicioRapido.Name = "btnInicioRapido";
            this.btnInicioRapido.Size = new System.Drawing.Size(102, 23);
            this.btnInicioRapido.TabIndex = 5;
            this.btnInicioRapido.Text = "Início Rápido";
            this.btnInicioRapido.UseVisualStyleBackColor = true;
            this.btnInicioRapido.Click += new System.EventHandler(this.btnInicioRapido_Click);
            // 
            // rtfForno
            // 
            this.rtfForno.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtfForno.Cursor = System.Windows.Forms.Cursors.No;
            this.rtfForno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfForno.ForeColor = System.Drawing.Color.LawnGreen;
            this.rtfForno.Location = new System.Drawing.Point(12, 12);
            this.rtfForno.Name = "rtfForno";
            this.rtfForno.ReadOnly = true;
            this.rtfForno.Size = new System.Drawing.Size(574, 379);
            this.rtfForno.TabIndex = 8;
            this.rtfForno.Text = "";
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(19, 134);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(102, 23);
            this.btnParar.TabIndex = 6;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(126, 134);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboProgramas
            // 
            this.cboProgramas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgramas.FormattingEnabled = true;
            this.cboProgramas.Location = new System.Drawing.Point(19, 50);
            this.cboProgramas.Name = "cboProgramas";
            this.cboProgramas.Size = new System.Drawing.Size(102, 21);
            this.cboProgramas.TabIndex = 9;
            this.cboProgramas.SelectedIndexChanged += new System.EventHandler(this.cbbProgramas_SelectedIndexChanged);
            // 
            // chkHabilitarProgramas
            // 
            this.chkHabilitarProgramas.AutoSize = true;
            this.chkHabilitarProgramas.Location = new System.Drawing.Point(19, 27);
            this.chkHabilitarProgramas.Name = "chkHabilitarProgramas";
            this.chkHabilitarProgramas.Size = new System.Drawing.Size(117, 17);
            this.chkHabilitarProgramas.TabIndex = 11;
            this.chkHabilitarProgramas.Text = "Habilitar Programas";
            this.chkHabilitarProgramas.UseVisualStyleBackColor = true;
            this.chkHabilitarProgramas.CheckedChanged += new System.EventHandler(this.cbxHabilitarProgramas_CheckedChanged);
            // 
            // grpPrincipal
            // 
            this.grpPrincipal.Controls.Add(this.txtAquecer);
            this.grpPrincipal.Controls.Add(this.lbComida);
            this.grpPrincipal.Controls.Add(this.mtxtTemporizador);
            this.grpPrincipal.Controls.Add(this.btnCancelar);
            this.grpPrincipal.Controls.Add(this.lbTempo);
            this.grpPrincipal.Controls.Add(this.btnParar);
            this.grpPrincipal.Controls.Add(this.cboPotencia);
            this.grpPrincipal.Controls.Add(this.lbPotencia);
            this.grpPrincipal.Controls.Add(this.btnInicioRapido);
            this.grpPrincipal.Controls.Add(this.btnIniciar);
            this.grpPrincipal.Location = new System.Drawing.Point(592, 47);
            this.grpPrincipal.Name = "grpPrincipal";
            this.grpPrincipal.Size = new System.Drawing.Size(247, 177);
            this.grpPrincipal.TabIndex = 12;
            this.grpPrincipal.TabStop = false;
            this.grpPrincipal.Text = "Informe:";
            // 
            // grpProgramas
            // 
            this.grpProgramas.Controls.Add(this.btnCadastrar);
            this.grpProgramas.Controls.Add(this.rtfInstrucoesPrograma);
            this.grpProgramas.Controls.Add(this.lbInstrucoes);
            this.grpProgramas.Controls.Add(this.cboProgramas);
            this.grpProgramas.Controls.Add(this.chkHabilitarProgramas);
            this.grpProgramas.Location = new System.Drawing.Point(592, 230);
            this.grpProgramas.Name = "grpProgramas";
            this.grpProgramas.Size = new System.Drawing.Size(247, 161);
            this.grpProgramas.TabIndex = 13;
            this.grpProgramas.TabStop = false;
            this.grpProgramas.Text = "Programas de Aquecimento";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Location = new System.Drawing.Point(126, 50);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(102, 23);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // rtfInstrucoesPrograma
            // 
            this.rtfInstrucoesPrograma.Location = new System.Drawing.Point(19, 90);
            this.rtfInstrucoesPrograma.Name = "rtfInstrucoesPrograma";
            this.rtfInstrucoesPrograma.ReadOnly = true;
            this.rtfInstrucoesPrograma.Size = new System.Drawing.Size(209, 56);
            this.rtfInstrucoesPrograma.TabIndex = 14;
            this.rtfInstrucoesPrograma.Text = "";
            // 
            // lbInstrucoes
            // 
            this.lbInstrucoes.AutoSize = true;
            this.lbInstrucoes.Location = new System.Drawing.Point(16, 74);
            this.lbInstrucoes.Name = "lbInstrucoes";
            this.lbInstrucoes.Size = new System.Drawing.Size(121, 13);
            this.lbInstrucoes.TabIndex = 13;
            this.lbInstrucoes.Text = "Instruções do programa:";
            // 
            // FrmMicroondasDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 404);
            this.Controls.Add(this.grpProgramas);
            this.Controls.Add(this.grpPrincipal);
            this.Controls.Add(this.rtfForno);
            this.Controls.Add(this.lbTemporizador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMicroondasDigital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microondas Digital";
            this.grpPrincipal.ResumeLayout(false);
            this.grpPrincipal.PerformLayout();
            this.grpProgramas.ResumeLayout(false);
            this.grpProgramas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAquecer;
        private System.Windows.Forms.Label lbComida;
        private System.Windows.Forms.Label lbTempo;
        private System.Windows.Forms.Label lbPotencia;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lbTemporizador;
        private System.Windows.Forms.Timer tmrTemporizador;
        private System.Windows.Forms.MaskedTextBox mtxtTemporizador;
        private System.Windows.Forms.ComboBox cboPotencia;
        private System.Windows.Forms.Button btnInicioRapido;
        private System.Windows.Forms.RichTextBox rtfForno;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboProgramas;
        private System.Windows.Forms.CheckBox chkHabilitarProgramas;
        private System.Windows.Forms.GroupBox grpPrincipal;
        private System.Windows.Forms.GroupBox grpProgramas;
        private System.Windows.Forms.RichTextBox rtfInstrucoesPrograma;
        private System.Windows.Forms.Label lbInstrucoes;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

