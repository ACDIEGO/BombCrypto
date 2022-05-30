namespace BombCrypto.forms
{
    partial class FormSetting
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDownAntiAFK = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExecucao = new System.Windows.Forms.NumericUpDown();
            this.GB_cadastro_audiencia = new System.Windows.Forms.GroupBox();
            this.btnSalvarAntiAFK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTimeExecucao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAntiAFK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExecucao)).BeginInit();
            this.GB_cadastro_audiencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownAntiAFK
            // 
            this.numericUpDownAntiAFK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownAntiAFK.Location = new System.Drawing.Point(162, 71);
            this.numericUpDownAntiAFK.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownAntiAFK.Minimum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownAntiAFK.Name = "numericUpDownAntiAFK";
            this.numericUpDownAntiAFK.Size = new System.Drawing.Size(174, 23);
            this.numericUpDownAntiAFK.TabIndex = 96;
            this.toolTip.SetToolTip(this.numericUpDownAntiAFK, "Executar o Anti-AFK a cada um período de tempo em milésimos de segundos.");
            this.numericUpDownAntiAFK.Value = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            // 
            // numericUpDownExecucao
            // 
            this.numericUpDownExecucao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownExecucao.Location = new System.Drawing.Point(162, 41);
            this.numericUpDownExecucao.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownExecucao.Name = "numericUpDownExecucao";
            this.numericUpDownExecucao.Size = new System.Drawing.Size(174, 23);
            this.numericUpDownExecucao.TabIndex = 93;
            this.toolTip.SetToolTip(this.numericUpDownExecucao, "Executar a rotina a cada um período de tempo em milésimos de segundos.");
            // 
            // GB_cadastro_audiencia
            // 
            this.GB_cadastro_audiencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GB_cadastro_audiencia.Controls.Add(this.btnSalvarAntiAFK);
            this.GB_cadastro_audiencia.Controls.Add(this.btnClose);
            this.GB_cadastro_audiencia.Controls.Add(this.numericUpDownAntiAFK);
            this.GB_cadastro_audiencia.Controls.Add(this.numericUpDownExecucao);
            this.GB_cadastro_audiencia.Controls.Add(this.lblTimeExecucao);
            this.GB_cadastro_audiencia.Controls.Add(this.label1);
            this.GB_cadastro_audiencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_cadastro_audiencia.ForeColor = System.Drawing.Color.Black;
            this.GB_cadastro_audiencia.Location = new System.Drawing.Point(101, 130);
            this.GB_cadastro_audiencia.Margin = new System.Windows.Forms.Padding(6);
            this.GB_cadastro_audiencia.Name = "GB_cadastro_audiencia";
            this.GB_cadastro_audiencia.Size = new System.Drawing.Size(396, 166);
            this.GB_cadastro_audiencia.TabIndex = 99;
            this.GB_cadastro_audiencia.TabStop = false;
            this.GB_cadastro_audiencia.Text = "TEMPO DE EXECUÇÃO";
            // 
            // btnSalvarAntiAFK
            // 
            this.btnSalvarAntiAFK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvarAntiAFK.BackColor = System.Drawing.Color.Silver;
            this.btnSalvarAntiAFK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarAntiAFK.FlatAppearance.BorderSize = 0;
            this.btnSalvarAntiAFK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarAntiAFK.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarAntiAFK.Location = new System.Drawing.Point(201, 101);
            this.btnSalvarAntiAFK.Name = "btnSalvarAntiAFK";
            this.btnSalvarAntiAFK.Size = new System.Drawing.Size(135, 27);
            this.btnSalvarAntiAFK.TabIndex = 97;
            this.btnSalvarAntiAFK.Text = "&SALVAR";
            this.btnSalvarAntiAFK.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(60, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 27);
            this.btnClose.TabIndex = 94;
            this.btnClose.Text = "&FECHAR";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblTimeExecucao
            // 
            this.lblTimeExecucao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimeExecucao.BackColor = System.Drawing.Color.Silver;
            this.lblTimeExecucao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTimeExecucao.ForeColor = System.Drawing.Color.Black;
            this.lblTimeExecucao.Location = new System.Drawing.Point(60, 41);
            this.lblTimeExecucao.Name = "lblTimeExecucao";
            this.lblTimeExecucao.Size = new System.Drawing.Size(96, 23);
            this.lblTimeExecucao.TabIndex = 95;
            this.lblTimeExecucao.Text = "ROTINA:";
            this.lblTimeExecucao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(60, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 98;
            this.label1.Text = "ANTI-AFK:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 427);
            this.Controls.Add(this.GB_cadastro_audiencia);
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAntiAFK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExecucao)).EndInit();
            this.GB_cadastro_audiencia.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox GB_cadastro_audiencia;
        private System.Windows.Forms.Button btnSalvarAntiAFK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown numericUpDownAntiAFK;
        private System.Windows.Forms.NumericUpDown numericUpDownExecucao;
        private System.Windows.Forms.Label lblTimeExecucao;
        private System.Windows.Forms.Label label1;
    }
}