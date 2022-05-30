using BombCrypto.classes;
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

namespace BombCrypto.forms
{
    public partial class FormMenuPrincipal : Form
    {
        readonly Global _Global = new Global();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            _Global.AbrirFormulario<FormSetting>(PanelBody);
        }

        private void BtnRotina_Click(object sender, EventArgs e)
        {
            _Global.AbrirFormulario<FormRotina>(PanelBody);
        }

        private void BtnHistorico_Click(object sender, EventArgs e)
        {
            _Global.AbrirFormulario<FormHistorico>(PanelBody);
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                if (DialogResult.Yes == MessageBox.Show("Tem certeza disso?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }

            }
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
                   
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            _Global.FecharFormularios();
        }

        private void PanelTittle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
