using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BombCrypto.classes;

namespace BombCrypto.forms
{
    public partial class FormAuthentication : Form
    {
        #region Load

        readonly Global bg = new Global();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion
        public FormAuthentication()
        {
            InitializeComponent();
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            var condition = TxtUsuario.Text == "USUÁRIO";
            if (condition)
            {
                TxtUsuario.Text = string.Empty;
                TxtUsuario.ForeColor = Color.White;
                TxtPass.Enabled = true;
                TxtPass.Text = string.Empty;
                TxtPass.ForeColor = Color.White;
  
            }

        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            var condition = TxtUsuario.Text == "";
            if (condition)
            {
                TxtUsuario.Text = "USUÁRIO";
                TxtUsuario.ForeColor = Color.DarkGray;
                TxtPass.Text = "SENHA";
                TxtPass.Enabled = false;    
                TxtPass.ForeColor = Color.DarkGray;

            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelAuthenticationLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                var condition = TxtUsuario.Text != "USUÁRIO";
                if (condition)
                {
                    using (DataTable dataTableRotinas = this.tableUsersTableAdapter.GetDataByPerfil(TxtUsuario.Text, TxtPass.Text))
                    {
                        if(dataTableRotinas.Rows.Count > 0)
                        {
                            int codigo = (int) dataTableRotinas.Rows[0][0];
                            string nome = (string) dataTableRotinas.Rows[0][1];
                            string email = (string)dataTableRotinas.Rows[0][2];
                            string telefone = (string)dataTableRotinas.Rows[0][3];

                            new FormMenuPrincipal().Show();
                            TxtUsuario.Text = String.Empty;
                            TxtPass.Text = String.Empty;
                            this.Hide();
                        }
                        else
                        {
                            Global.Select_txt(TxtUsuario);
                            TxtPass.Text = String.Empty;
                            LblStatusLogin.Visible = true;
                        }
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            LblStatusLogin.Visible = false;
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                BtnEnter_Click(sender, e);
            }
        }
    }
}
