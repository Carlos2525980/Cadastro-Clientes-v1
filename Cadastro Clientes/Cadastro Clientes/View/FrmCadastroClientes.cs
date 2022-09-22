
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Clientes
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
            carregar();
          
        }

        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;
        string strSQL;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo Nome é obrigatório!");
            }
            else if (txtEndereco.Text == "")
            {
                MessageBox.Show("O campo Endereço é obrigatório!");
            }
            else if (txtBairro.Text == "")
            {
                MessageBox.Show("O campo Bairro é obrigatório!");
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("O campo Cidade é obrigatório!");
            }
            else if (txtComplemento.Text == "")
            {
                MessageBox.Show("O campo Complemento é obrigatório!");
            }
            else if(txtTelefone.Text == "")
            {
                MessageBox.Show("O campo Telefone é obrigatório!");
            }
            else if (cbEstado.Text == "")
            {
                MessageBox.Show("O campo Estado é obrigatório!");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("O campo Email é obrigatório!");
            }
            else
            {
                try
                {
                    conexao = new SqlConnection(@"Data Source = CARLOSALEXANDRE\SQLEXPRESS; Initial Catalog = CADASTRO_CLIENTES; Persist Security Info = True; User ID = sa;Password=123456;TrustServerCertificate=True");

                    strSQL = "INSERT INTO CLIENTES(NOME , ENDERECO , BAIRRO, COMPLEMENTO ,CIDADE,EMAIL, TELEFONE, ESTADO) VALUES(@NOME, @ENDERECO, @BAIRRO, @COMPLEMENTO,@CIDADE, @EMAIL, @TELEFONE, @ESTADO)";

                    comando = new SqlCommand(strSQL, conexao);

                    comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                    comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                    comando.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                    comando.Parameters.AddWithValue("@COMPLEMENTO", txtComplemento.Text);
                    comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                    comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                    comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                   

                    //Seleção do combobox
                    if (cbEstado.Text == "")
                    {
                        MessageBox.Show("O campo Estado é obrigatório!");
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Acre")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.SelectedItem);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Alagoas")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Amapá")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Amazonas")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Bahia")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Ceará")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Goiás")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Maranhão")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Mato Grosso")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Mato Grosso do Sul")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Minas Gerais")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Pará")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Paraíba")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Paraná")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Pernambuco")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Piauí")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Rio de Janeiro")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Rio Grande do Norte")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Rio Grande do Sul")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Rondônia")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Roraima")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Santa Catarina")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "São Paulo")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Sergipe")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Tocantins")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }
                    else if (cbEstado.SelectedItem.ToString() == "Distrito Federal")
                    {
                        comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
                    }

                    /*
                     LIMPAR CAMPOS
                     */
                    txtNome.Clear();
                    txtEndereco.Clear();
                    txtBairro.Clear();
                    txtComplemento.Clear();
                    txtCidade.Clear();
                    txtEmail.Clear();
                    txtTelefone.Clear();
                    cbEstado.Text = "";


                    MessageBox.Show("Inserido com sucesso!");

                    /*
                      CARREGAR GRID
                      */
                    strSQL = "SELECT * FROM CLIENTES";
                    DataSet ds = new DataSet();
                    da = new SqlDataAdapter(strSQL, conexao);
                    //abre a conexao
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    da.Fill(ds);
                    //Seta o DataGridView da interface, tranformando em tabela, 
                    //e jogando as informaçoes da tabela dentro.
                    grid.DataSource = ds.Tables[0];                

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexao.Close();
                    comando.Clone();
                    conexao = null;
                    comando = null;
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source = CARLOSALEXANDRE\SQLEXPRESS; Initial Catalog = CADASTRO_CLIENTES; Persist Security Info = True; User ID = sa;Password=123456;TrustServerCertificate=True");

                strSQL = "SELECT * FROM CLIENTES WHERE NOME = @NOME";
                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NOME", txtPesquisar.Text);
              

                //abre a conexao
                conexao.Open();

                //instancia o datareader
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = (string)dr["nome"];

                    txtEndereco.Text = (string)dr["endereco"];

                    txtCidade.Text = (string)dr["cidade"];

                    txtEmail.Text = (string)dr["email"];

                    txtTelefone.Text = Convert.ToString(dr["telefone"]);

                    cbEstado.Text = Convert.ToString(dr["estado"]);

                    txtComplemento.Text = Convert.ToString(dr["complemento"]);

                    txtBairro.Text = Convert.ToString(dr["bairro"]);

                }
            }

            catch (Exception ex)
            {

                // SE DER ALGUM ERRO ESSA MENSAGEM DE ERRO SERÁ ATIVADA.
                MessageBox.Show(ex.Message);


            }
            finally
            {

                //FECHANDO A CONEXAO
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source = CARLOSALEXANDRE\SQLEXPRESS; Initial Catalog = CADASTRO_CLIENTES; Persist Security Info = True; User ID = sa;Password=123456;TrustServerCertificate=True");


                //Excluindo DADOS no banco de dados na tabela CAD_CLIENTE
                strSQL = "DELETE CLIENTES WHERE NOME = @NOME";

                //INSTANCIA A PRORPRIEDADE SQLCOMAND, SETANDO O CAMPO ID DA TABELA COM O TEXTBOX ID DA INTERFASE

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NOME", txtNome.Text);


                /*
                    LIMPAR CAMPOS
               */
                txtNome.Clear();
                txtEndereco.Clear();
                txtBairro.Clear();
                txtComplemento.Clear();
                txtCidade.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
                cbEstado.Text = "";

                MessageBox.Show("Deletado com sucesso!");

                /*
                   CARREGAR GRID
                   */
                strSQL = "SELECT * FROM CLIENTES";
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSQL, conexao);
                //abre a conexao
                conexao.Open();
                comando.ExecuteNonQuery();
                da.Fill(ds);
                //Seta o DataGridView da interface, tranformando em tabela, 
                //e jogando as informaçoes da tabela dentro.
                grid.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {

                // SE DER ALGUM ERRO ESSA MENSAGEM DE ERRO SERÁ ATIVADA.
                MessageBox.Show(ex.Message);


            }
            finally
            {

                //FECHANDO A CONEXAO
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }
        //Carregar Grid ao iniciar a tela
        public void carregar()
        {
            try
            {
                conexao = new SqlConnection(@"Data Source = CARLOSALEXANDRE\SQLEXPRESS; Initial Catalog = CADASTRO_CLIENTES; Persist Security Info = True; User ID = sa;Password=123456;TrustServerCertificate=True");

                strSQL = "SELECT * FROM CLIENTES";
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSQL, conexao);
                //abre a conexao
                conexao.Open();
                da.Fill(ds);
                //Seta o DataGridView da interface, tranformando em tabela, 
                //e jogando as informaçoes da tabela dentro.
                grid.DataSource = ds.Tables[0];
               

            }
            catch (Exception ex)
            {

                // SE DER ALGUM ERRO ESSA MENSAGEM DE ERRO SERÁ ATIVADA.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //FECHANDO A CONEXAO
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //FAZENDO A CONEXAO ENTRE INSTANCIA, BANCO DE DADOS.
                conexao = new SqlConnection(@"Data Source = CARLOSALEXANDRE\SQLEXPRESS; Initial Catalog = CADASTRO_CLIENTES; Persist Security Info = True; User ID = sa;Password=123456;TrustServerCertificate=True");

                //Vai alterar o valor anterior para o que o usuario digitar
                strSQL = "UPDATE CLIENTES SET ENDERECO = @ENDERECO, BAIRRO = @BAIRRO, COMPLEMENTO = @COMPLEMENTO, CIDADE = @CIDADE, EMAIL = @EMAIL, TELEFONE = @TELEFONE, ESTADO = @ESTADO WHERE NOME = @NOME;"; 

                //INSTANCIA A PRORPRIEDADE SQLCOMAND, SETANDO O CAMPOS DA TABELA COM OS TEXTBOX DA INTERFACE

                comando = new SqlCommand(strSQL, conexao);
 
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                comando.Parameters.AddWithValue("@COMPLEMENTO", txtComplemento.Text);
                comando.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@ESTADO", cbEstado.Text);
               

                /*
                      LIMPAR CAMPOS
                 */
                txtNome.Clear();
                txtEndereco.Clear();
                txtBairro.Clear();
                txtComplemento.Clear();
                txtCidade.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
                cbEstado.Text = "";
               
                MessageBox.Show("Alterado com sucesso!");

                /*
                   CARREGAR GRID
                   */
                strSQL = "SELECT * FROM CLIENTES";
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSQL, conexao);
                //abre a conexao
                conexao.Open();
                comando.ExecuteNonQuery();
                da.Fill(ds);
                //Seta o DataGridView da interface, tranformando em tabela, 
                //e jogando as informaçoes da tabela dentro.
                grid.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {

                // SE DER ALGUM ERRO ESSA MENSAGEM DE ERRO SERÁ ATIVADA.
                MessageBox.Show(ex.Message);


            }
            finally
            {

                //FECHANDO A CONEXAO
                conexao.Close();
                comando.Clone();
                conexao = null;
                comando = null;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source = CARLOSALEXANDRE\SQLEXPRESS; Initial Catalog = CADASTRO_CLIENTES; Persist Security Info = True; User ID = sa;Password=123456;TrustServerCertificate=True");

                strSQL = "SELECT * FROM CLIENTES";
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strSQL, conexao);
                //abre a conexao
                conexao.Open();
                da.Fill(ds);
                //Seta o DataGridView da interface, tranformando em tabela, 
                //e jogando as informaçoes da tabela dentro.
                grid.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {

                // SE DER ALGUM ERRO ESSA MENSAGEM DE ERRO SERÁ ATIVADA.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //FECHANDO A CONEXAO
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            lbmsg.Text = "A pesquisa deve ser feita através do nome do cliente!";
        }      

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            //imprimir relatorio
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Cadastro de clientes"; 
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true; 
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "fim"; 
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(grid);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            lbmsg.Text = "";
        }

        private void FrmCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            //fechamento da tela cadastro de clientes
            DialogResult Resultado = MessageBox.Show(" Deseja realmente fechar? ", "Confirmação de fechamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.No)
            {
                e.Cancel = true;
            }           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //botao limpar
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            cbEstado.Text = "";
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validação do campo Telefone
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números");
            }
        }
    }
}

    

