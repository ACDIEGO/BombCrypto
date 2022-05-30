namespace BombCrypto.forms
{
    partial class FormAuthentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthentication));
            this.PanelAuthenticationLogo = new System.Windows.Forms.Panel();
            this.PictureBoxAuthentication = new System.Windows.Forms.PictureBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LblStatusLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cryptoDataSet = new BombCrypto.CryptoDataSet();
            this.tableUsersTableAdapter = new BombCrypto.CryptoDataSetTableAdapters.TableUsersTableAdapter();
            this.PanelAuthenticationLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAuthentication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelAuthenticationLogo
            // 
            this.PanelAuthenticationLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PanelAuthenticationLogo.Controls.Add(this.PictureBoxAuthentication);
            this.PanelAuthenticationLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelAuthenticationLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelAuthenticationLogo.Name = "PanelAuthenticationLogo";
            this.PanelAuthenticationLogo.Size = new System.Drawing.Size(177, 344);
            this.PanelAuthenticationLogo.TabIndex = 0;
            this.PanelAuthenticationLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelAuthenticationLogo_MouseDown);
            // 
            // PictureBoxAuthentication
            // 
            this.PictureBoxAuthentication.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxAuthentication.Image")));
            this.PictureBoxAuthentication.Location = new System.Drawing.Point(14, 90);
            this.PictureBoxAuthentication.Name = "PictureBoxAuthentication";
            this.PictureBoxAuthentication.Size = new System.Drawing.Size(149, 165);
            this.PictureBoxAuthentication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxAuthentication.TabIndex = 1;
            this.PictureBoxAuthentication.TabStop = false;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtUsuario.Location = new System.Drawing.Point(254, 110);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(278, 22);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.Text = "USUÁRIO";
            this.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsuario_KeyDown);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass.Enabled = false;
            this.TxtPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtPass.Location = new System.Drawing.Point(254, 157);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(278, 22);
            this.TxtPass.TabIndex = 2;
            this.TxtPass.Text = "SENHA";
            this.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPass.UseSystemPasswordChar = true;
            this.TxtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPass_KeyDown);
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEnter.FlatAppearance.BorderSize = 0;
            this.BtnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnter.ForeColor = System.Drawing.Color.White;
            this.BtnEnter.Location = new System.Drawing.Point(244, 209);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(298, 35);
            this.BtnEnter.TabIndex = 0;
            this.BtnEnter.Text = "ENTER";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(340, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(573, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(33, 31);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.linkLabel1.Location = new System.Drawing.Point(342, 258);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueceu a senha?";
            // 
            // LblStatusLogin
            // 
            this.LblStatusLogin.AutoSize = true;
            this.LblStatusLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatusLogin.ForeColor = System.Drawing.Color.Red;
            this.LblStatusLogin.Location = new System.Drawing.Point(275, 289);
            this.LblStatusLogin.Name = "LblStatusLogin";
            this.LblStatusLogin.Size = new System.Drawing.Size(237, 21);
            this.LblStatusLogin.TabIndex = 8;
            this.LblStatusLogin.Text = "Usuário e/ou senha inválidos!\r\n";
            this.LblStatusLogin.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(244, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 1);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(244, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 1);
            this.panel2.TabIndex = 10;
            // 
            // cryptoDataSet
            // 
            this.cryptoDataSet.DataSetName = "CryptoDataSet";
            this.cryptoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableUsersTableAdapter
            // 
            this.tableUsersTableAdapter.ClearBeforeFill = true;
            // 
            // FormAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(610, 344);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblStatusLogin);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.PanelAuthenticationLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAuthentication";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAuthentication";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelAuthenticationLogo_MouseDown);
            this.PanelAuthenticationLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAuthentication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelAuthenticationLogo;
        private System.Windows.Forms.PictureBox PictureBoxAuthentication;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label LblStatusLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CryptoDataSet cryptoDataSet;
        private CryptoDataSetTableAdapters.TableUsersTableAdapter tableUsersTableAdapter;
    }
}