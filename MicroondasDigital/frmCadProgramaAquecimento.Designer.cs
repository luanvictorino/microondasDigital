namespace MicroOndasDigital
{
    partial class frmCadProgramaAquecimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProgramaAquecimento));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTempo = new System.Windows.Forms.Label();
            this.lbPotencia = new System.Windows.Forms.Label();
            this.lbInstrucao = new System.Windows.Forms.Label();
            this.txtCaracter = new System.Windows.Forms.TextBox();
            this.lbCaracter = new System.Windows.Forms.Label();
            this.btnAutoCompletarInst = new System.Windows.Forms.Button();
            this.mtxtTempo = new System.Windows.Forms.MaskedTextBox();
            this.cboPotencia = new System.Windows.Forms.ComboBox();
            this.rtfInstrucao = new System.Windows.Forms.RichTextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cboProgramas = new System.Windows.Forms.ComboBox();
            this.lbPrograma = new System.Windows.Forms.Label();
            this.chkMostrarProgramas = new System.Windows.Forms.CheckBox();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.grpCadProgramaAquecimento = new System.Windows.Forms.GroupBox();
            this.grpProgramasCadastrados = new System.Windows.Forms.GroupBox();
            this.grpCadProgramaAquecimento.SuspendLayout();
            this.grpProgramasCadastrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(153, 20);
            this.txtNome.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(370, 169);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 43);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(15, 26);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // lbTempo
            // 
            this.lbTempo.AutoSize = true;
            this.lbTempo.Location = new System.Drawing.Point(174, 26);
            this.lbTempo.Name = "lbTempo";
            this.lbTempo.Size = new System.Drawing.Size(40, 13);
            this.lbTempo.TabIndex = 6;
            this.lbTempo.Text = "Tempo";
            // 
            // lbPotencia
            // 
            this.lbPotencia.AutoSize = true;
            this.lbPotencia.Location = new System.Drawing.Point(230, 25);
            this.lbPotencia.Name = "lbPotencia";
            this.lbPotencia.Size = new System.Drawing.Size(49, 13);
            this.lbPotencia.TabIndex = 7;
            this.lbPotencia.Text = "Potência";
            // 
            // lbInstrucao
            // 
            this.lbInstrucao.AutoSize = true;
            this.lbInstrucao.Location = new System.Drawing.Point(15, 69);
            this.lbInstrucao.Name = "lbInstrucao";
            this.lbInstrucao.Size = new System.Drawing.Size(91, 13);
            this.lbInstrucao.TabIndex = 8;
            this.lbInstrucao.Text = "Instruções de uso";
            // 
            // txtCaracter
            // 
            this.txtCaracter.Location = new System.Drawing.Point(289, 41);
            this.txtCaracter.MaxLength = 1;
            this.txtCaracter.Name = "txtCaracter";
            this.txtCaracter.Size = new System.Drawing.Size(44, 20);
            this.txtCaracter.TabIndex = 3;
            // 
            // lbCaracter
            // 
            this.lbCaracter.AutoSize = true;
            this.lbCaracter.Location = new System.Drawing.Point(286, 25);
            this.lbCaracter.Name = "lbCaracter";
            this.lbCaracter.Size = new System.Drawing.Size(47, 13);
            this.lbCaracter.TabIndex = 10;
            this.lbCaracter.Text = "Caracter";
            // 
            // btnAutoCompletarInst
            // 
            this.btnAutoCompletarInst.Location = new System.Drawing.Point(18, 157);
            this.btnAutoCompletarInst.Name = "btnAutoCompletarInst";
            this.btnAutoCompletarInst.Size = new System.Drawing.Size(100, 43);
            this.btnAutoCompletarInst.TabIndex = 5;
            this.btnAutoCompletarInst.Text = "Auto Completar Instruções.";
            this.btnAutoCompletarInst.UseVisualStyleBackColor = true;
            this.btnAutoCompletarInst.Click += new System.EventHandler(this.btnAutoPreencher_Click);
            // 
            // mtxtTempo
            // 
            this.mtxtTempo.Location = new System.Drawing.Point(177, 42);
            this.mtxtTempo.Mask = "90:00";
            this.mtxtTempo.Name = "mtxtTempo";
            this.mtxtTempo.Size = new System.Drawing.Size(50, 20);
            this.mtxtTempo.TabIndex = 1;
            this.mtxtTempo.ValidatingType = typeof(System.DateTime);
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
            this.cboPotencia.Location = new System.Drawing.Point(233, 41);
            this.cboPotencia.Name = "cboPotencia";
            this.cboPotencia.Size = new System.Drawing.Size(50, 21);
            this.cboPotencia.TabIndex = 2;
            // 
            // rtfInstrucao
            // 
            this.rtfInstrucao.Location = new System.Drawing.Point(18, 85);
            this.rtfInstrucao.Name = "rtfInstrucao";
            this.rtfInstrucao.Size = new System.Drawing.Size(315, 68);
            this.rtfInstrucao.TabIndex = 4;
            this.rtfInstrucao.Text = "";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(480, 169);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 43);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cboProgramas
            // 
            this.cboProgramas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgramas.Enabled = false;
            this.cboProgramas.FormattingEnabled = true;
            this.cboProgramas.Location = new System.Drawing.Point(18, 76);
            this.cboProgramas.Name = "cboProgramas";
            this.cboProgramas.Size = new System.Drawing.Size(170, 21);
            this.cboProgramas.TabIndex = 12;
            this.cboProgramas.SelectedIndexChanged += new System.EventHandler(this.cboProgramas_SelectedIndexChanged);
            // 
            // lbPrograma
            // 
            this.lbPrograma.AutoSize = true;
            this.lbPrograma.Location = new System.Drawing.Point(15, 60);
            this.lbPrograma.Name = "lbPrograma";
            this.lbPrograma.Size = new System.Drawing.Size(118, 13);
            this.lbPrograma.TabIndex = 13;
            this.lbPrograma.Text = "Programas cadastrados";
            // 
            // chkMostrarProgramas
            // 
            this.chkMostrarProgramas.AutoSize = true;
            this.chkMostrarProgramas.Location = new System.Drawing.Point(18, 25);
            this.chkMostrarProgramas.Name = "chkMostrarProgramas";
            this.chkMostrarProgramas.Size = new System.Drawing.Size(157, 17);
            this.chkMostrarProgramas.TabIndex = 14;
            this.chkMostrarProgramas.Text = "Ver Programas Cadastrados";
            this.chkMostrarProgramas.UseVisualStyleBackColor = true;
            this.chkMostrarProgramas.CheckedChanged += new System.EventHandler(this.chkMostrarProgramas_CheckedChanged);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(233, 157);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(100, 43);
            this.btnLimparCampos.TabIndex = 15;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // grpCadProgramaAquecimento
            // 
            this.grpCadProgramaAquecimento.Controls.Add(this.txtNome);
            this.grpCadProgramaAquecimento.Controls.Add(this.btnLimparCampos);
            this.grpCadProgramaAquecimento.Controls.Add(this.lbNome);
            this.grpCadProgramaAquecimento.Controls.Add(this.lbTempo);
            this.grpCadProgramaAquecimento.Controls.Add(this.lbPotencia);
            this.grpCadProgramaAquecimento.Controls.Add(this.txtCaracter);
            this.grpCadProgramaAquecimento.Controls.Add(this.lbCaracter);
            this.grpCadProgramaAquecimento.Controls.Add(this.btnAutoCompletarInst);
            this.grpCadProgramaAquecimento.Controls.Add(this.rtfInstrucao);
            this.grpCadProgramaAquecimento.Controls.Add(this.mtxtTempo);
            this.grpCadProgramaAquecimento.Controls.Add(this.lbInstrucao);
            this.grpCadProgramaAquecimento.Controls.Add(this.cboPotencia);
            this.grpCadProgramaAquecimento.Location = new System.Drawing.Point(12, 12);
            this.grpCadProgramaAquecimento.Name = "grpCadProgramaAquecimento";
            this.grpCadProgramaAquecimento.Size = new System.Drawing.Size(352, 212);
            this.grpCadProgramaAquecimento.TabIndex = 16;
            this.grpCadProgramaAquecimento.TabStop = false;
            this.grpCadProgramaAquecimento.Text = "Cadastrar Programa";
            // 
            // grpProgramasCadastrados
            // 
            this.grpProgramasCadastrados.Controls.Add(this.chkMostrarProgramas);
            this.grpProgramasCadastrados.Controls.Add(this.lbPrograma);
            this.grpProgramasCadastrados.Controls.Add(this.cboProgramas);
            this.grpProgramasCadastrados.Location = new System.Drawing.Point(370, 12);
            this.grpProgramasCadastrados.Name = "grpProgramasCadastrados";
            this.grpProgramasCadastrados.Size = new System.Drawing.Size(210, 116);
            this.grpProgramasCadastrados.TabIndex = 17;
            this.grpProgramasCadastrados.TabStop = false;
            this.grpProgramasCadastrados.Text = "Programas Cadastrados";
            // 
            // frmCadProgramaAquecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 236);
            this.Controls.Add(this.grpProgramasCadastrados);
            this.Controls.Add(this.grpCadProgramaAquecimento);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadProgramaAquecimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Programa de Aquecimento";
            this.grpCadProgramaAquecimento.ResumeLayout(false);
            this.grpCadProgramaAquecimento.PerformLayout();
            this.grpProgramasCadastrados.ResumeLayout(false);
            this.grpProgramasCadastrados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTempo;
        private System.Windows.Forms.Label lbPotencia;
        private System.Windows.Forms.Label lbInstrucao;
        private System.Windows.Forms.TextBox txtCaracter;
        private System.Windows.Forms.Label lbCaracter;
        private System.Windows.Forms.Button btnAutoCompletarInst;
        private System.Windows.Forms.MaskedTextBox mtxtTempo;
        private System.Windows.Forms.ComboBox cboPotencia;
        private System.Windows.Forms.RichTextBox rtfInstrucao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cboProgramas;
        private System.Windows.Forms.Label lbPrograma;
        private System.Windows.Forms.CheckBox chkMostrarProgramas;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.GroupBox grpCadProgramaAquecimento;
        private System.Windows.Forms.GroupBox grpProgramasCadastrados;
    }
}