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
    public partial class FormRotina : Form
    {
        private readonly Global gb = new Global();  
        public FormRotina()
        {
            InitializeComponent();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            try
            {
                string _rotina = txtRotina.Text;
                bool _loop = ckbLooping.Checked;
                string _parametro = txtParametro.Text;
                string _tipo = cbxTipoRotina.Text;
                bool _status = false;

                if (_rotina != string.Empty)
                {

                    DataTable dataTableRotinas = new DataTable();

                    dataTableRotinas = this.RotinaTableAdapter.GetData(_rotina, _loop, _parametro, _status, _tipo);

                    foreach (DataRow rotina in dataTableRotinas.Rows)
                    {
                        txtCodigo.Text = rotina[0].ToString();
                        MessageBox.Show("Rotina salva com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gbCriarTorina.Enabled = false;
                        gb.AbrirFormulario<FormRotinaAddAutoClick>(PanelCriarRotina);
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos são obrigatórios.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
