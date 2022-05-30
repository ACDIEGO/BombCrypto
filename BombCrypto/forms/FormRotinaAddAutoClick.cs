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

namespace BombCrypto.forms
{
    public partial class FormRotinaAddAutoClick : Form
    {
        private readonly Global gb = new Global();
        public FormRotinaAddAutoClick()
        {
            InitializeComponent();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            gb.AbrirFormulario<FormRotinaAddParametro>(PanelRotinaAutoClick);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
