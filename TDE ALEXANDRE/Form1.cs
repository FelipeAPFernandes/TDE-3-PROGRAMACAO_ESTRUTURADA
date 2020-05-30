using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDE_ALEXANDRE
{
    public partial class Form1 : Form
    {
        static String path = AppDomain.CurrentDomain.BaseDirectory + "dados";
        static String file = path + "/Banco.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int desgraca = 0;

            if (txtEmail.Text == "")
            {
                //Validação Convencional
                //Message.Box.Show("Email Obrigatório");
                errorProvider.SetError(txtEmail, "Email Obrigatório");
                desgraca = 1;
            }
            else
            {
                errorProvider.SetError(txtEmail, "");
                desgraca = 0;
            }
            if(txtNome.Text == "")
            {
                errorProvider.SetError(txtNome, "Nome Obrigatório");
                desgraca = 1;
            }
            else
            {
                errorProvider.SetError(txtNome, "");
                desgraca = 0;
            }
            if (mtbCPF.Text == "")
            {
                errorProvider.SetError(mtbCPF, "Cpf Obrigatório");
                desgraca = 1;
            }
            else
            {
                errorProvider.SetError(mtbCPF, "");
                desgraca = 0;
            }
            if (txtSobrenome.Text == "")
            {
                errorProvider.SetError(txtSobrenome, "Sobrenome Obrigatório");
                desgraca = 1;
            }
            else
            {
                errorProvider.SetError(txtSobrenome, "");
                desgraca = 0;
            }
            if (txtSenha.Text == "")
            {
                errorProvider.SetError(txtSenha, "Senha Obrigatório");
                desgraca = 1;
            }
            else
            {
                errorProvider.SetError(txtSenha, "");
                desgraca = 0;
            }
            if (txtConfirmarSenha.Text == "")
            {
                errorProvider.SetError(txtConfirmarSenha, "Senha Obrigatório");
                desgraca = 1;
            }
            else
            {
                errorProvider.SetError(txtConfirmarSenha, "");
                desgraca = 0;
            }
            if(desgraca == 1)
            {
                MessageBox.Show("Por favor, preencha os campos obrigatórios");
            }
            else
            {
                bool checkDirExist = Directory.Exists(path);
                if (!checkDirExist)
                {
                    Directory.CreateDirectory(path);
                }

                bool checkFileExist = File.Exists(file);
                String line = "|| " + txtNome.Text + " || " + txtSobrenome.Text + " || " + mtbCPF.Text + " || " + txtSenha.Text + " || " + txtEmail.Text + " ||";

                if (!checkFileExist)
                {
                    using (StreamWriter sw = File.CreateText(file))
                    {
                        sw.WriteLine(line);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(file))
                    {
                        sw.WriteLine(line);
                    }
                }
            }       
        }          
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //textbox clear code
            txtNome.Text = "";
            txtSenha.Text = "";
            txtSobrenome.Text = "";
            txtConfirmarSenha.Text = "";
            txtEmail.Text = "";

            //maskedtextbox clear code
            mtbCPF.Text = "";            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
