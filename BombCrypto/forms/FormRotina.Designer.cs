namespace BombCrypto.forms
{
    partial class FormRotina
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
            this.gbCriarTorina = new System.Windows.Forms.GroupBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbxTipoRotina = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRotina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbLooping = new System.Windows.Forms.CheckBox();
            this.PanelCriarRotina = new System.Windows.Forms.Panel();
            this.RotinaTableAdapter = new BombCrypto.CryptoDataSetTableAdapters.PCD_INSERT_ROTINASTableAdapter();
            this.gbCriarTorina.SuspendLayout();
            this.PanelCriarRotina.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCriarTorina
            // 
            this.gbCriarTorina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCriarTorina.Controls.Add(this.cbxTipoRotina);
            this.gbCriarTorina.Controls.Add(this.label5);
            this.gbCriarTorina.Controls.Add(this.label4);
            this.gbCriarTorina.Controls.Add(this.txtParametro);
            this.gbCriarTorina.Controls.Add(this.txtCodigo);
            this.gbCriarTorina.Controls.Add(this.label1);
            this.gbCriarTorina.Controls.Add(this.label2);
            this.gbCriarTorina.Controls.Add(this.txtRotina);
            this.gbCriarTorina.Controls.Add(this.label3);
            this.gbCriarTorina.Controls.Add(this.ckbLooping);
            this.gbCriarTorina.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCriarTorina.ForeColor = System.Drawing.Color.White;
            this.gbCriarTorina.Location = new System.Drawing.Point(88, 87);
            this.gbCriarTorina.Name = "gbCriarTorina";
            this.gbCriarTorina.Size = new System.Drawing.Size(377, 182);
            this.gbCriarTorina.TabIndex = 120;
            this.gbCriarTorina.TabStop = false;
            this.gbCriarTorina.Text = "CRIAR ROTINA";
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProximo.BackColor = System.Drawing.Color.Silver;
            this.btnProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.ForeColor = System.Drawing.Color.Black;
            this.btnProximo.Location = new System.Drawing.Point(286, 274);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(143, 34);
            this.btnProximo.TabIndex = 5;
            this.btnProximo.Text = "&PRÓXIMO";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(127, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&FECHAR";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // cbxTipoRotina
            // 
            this.cbxTipoRotina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTipoRotina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoRotina.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoRotina.FormattingEnabled = true;
            this.cbxTipoRotina.Items.AddRange(new object[] {
            "WORK",
            "ANTI-AFK"});
            this.cbxTipoRotina.Location = new System.Drawing.Point(140, 56);
            this.cbxTipoRotina.Name = "cbxTipoRotina";
            this.cbxTipoRotina.Size = new System.Drawing.Size(201, 23);
            this.cbxTipoRotina.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "TAREFA:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(40, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "PARÂMETRO:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtParametro
            // 
            this.txtParametro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro.Location = new System.Drawing.Point(140, 104);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(201, 21);
            this.txtParametro.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(140, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(201, 21);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "CÓDIGO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "ROTINA:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRotina
            // 
            this.txtRotina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRotina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRotina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRotina.Location = new System.Drawing.Point(140, 81);
            this.txtRotina.Name = "txtRotina";
            this.txtRotina.Size = new System.Drawing.Size(201, 21);
            this.txtRotina.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "REPETIR:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ckbLooping
            // 
            this.ckbLooping.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbLooping.AutoSize = true;
            this.ckbLooping.BackColor = System.Drawing.Color.Transparent;
            this.ckbLooping.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLooping.ForeColor = System.Drawing.Color.Black;
            this.ckbLooping.Location = new System.Drawing.Point(140, 132);
            this.ckbLooping.Name = "ckbLooping";
            this.ckbLooping.Size = new System.Drawing.Size(82, 19);
            this.ckbLooping.TabIndex = 4;
            this.ckbLooping.Text = "SIM/ NÃO";
            this.ckbLooping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbLooping.UseVisualStyleBackColor = false;
            // 
            // PanelCriarRotina
            // 
            this.PanelCriarRotina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelCriarRotina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelCriarRotina.Controls.Add(this.btnProximo);
            this.PanelCriarRotina.Controls.Add(this.btnClose);
            this.PanelCriarRotina.Controls.Add(this.gbCriarTorina);
            this.PanelCriarRotina.Location = new System.Drawing.Point(23, 26);
            this.PanelCriarRotina.Name = "PanelCriarRotina";
            this.PanelCriarRotina.Size = new System.Drawing.Size(553, 375);
            this.PanelCriarRotina.TabIndex = 121;
            // 
            // RotinaTableAdapter
            // 
            this.RotinaTableAdapter.ClearBeforeFill = true;
            // 
            // FormRotina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 427);
            this.Controls.Add(this.PanelCriarRotina);
            this.Name = "FormRotina";
            this.Text = "FormRotina";
            this.gbCriarTorina.ResumeLayout(false);
            this.gbCriarTorina.PerformLayout();
            this.PanelCriarRotina.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCriarTorina;
        private System.Windows.Forms.ComboBox cbxTipoRotina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRotina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbLooping;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel PanelCriarRotina;
        private CryptoDataSetTableAdapters.PCD_INSERT_ROTINASTableAdapter RotinaTableAdapter;
    }
}