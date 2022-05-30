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
    public partial class FormRotinaAddParametro : Form
    {
        private readonly Global _Global = new Global();
        public FormRotinaAddParametro()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            _Global.FecharFormularios();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
