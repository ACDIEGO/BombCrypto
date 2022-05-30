using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombCrypto.classes
{
    public class Global
    {

        public void FecharFormularios()
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if ((Application.OpenForms[intIndex].Text != "FormMenuPrincipal") && (Application.OpenForms[intIndex].Text != "FormAuthentication"))
                    Application.OpenForms[intIndex].Close();
            }
        }


        public void AbrirFormulario<MiForm>(Panel panel) where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel.Controls.OfType<MiForm>().FirstOrDefault();
                                                                         
            if (formulario == null)
            {
                formulario = new MiForm
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                panel.Controls.Add(formulario);
                panel.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }


        public bool Authentication(string user, string pass)
        {
            if ((user == "admin") && (pass == "admin"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Select_txt(TextBox text)
        {
            if (text.Enabled)
            {
                text.Select();
                text.SelectionStart = 0;
                text.SelectionLength = text.TextLength;
            }
        }
        public static void Esc(KeyEventArgs e, Form form)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                form.Close();
            }
        }

        public static void OpenInExplorer(string path)
        {
            string cmd = "explorer.exe";
            string arg = "/select, " + path;
            Process.Start(cmd, arg);
        }

    }
}
