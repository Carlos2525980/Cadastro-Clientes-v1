using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Clientes
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }      

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            //verifica se a imagem foi carregada 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //seleciona a imgaem e vincula a mesma ao pictureBox chamado "exibirImagem"
                foto.ImageLocation = openFileDialog1.FileName;
                //carrega a imagem selecionada no Picture box "exibirImagem"
                foto.Load();
               

            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //verificação de senha e usuário
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Usuáro e Senha em branco ou incorreta!");
            }
            else
            {
                if (txtUsuario.Text == "admin" && txtSenha.Text == "admin")
                {
                    this.Hide();
                    MessageBox.Show(" Seja bem vindo ao cadastro de clientes! ");
                    FrmCadastro cadastro = new FrmCadastro();
                    cadastro.Closed += (s, args) => this.Close();
                    cadastro.Show();              
                    
                }
                else
                {
                    MessageBox.Show(" Verifique se o Usuário e senha foram digitados corretamente e tente novamente!");
                }
            }           
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //fechar aplicação
            Close();
        }
    }
}
