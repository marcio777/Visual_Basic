using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TemakeriaTeste
{
    public partial class addfuncionario : Form
    {
        public addfuncionario()
        {
            InitializeComponent();
            
            // Evento para deixar o desabilitado na tela principal de cadastro

            txtnome.Enabled = false;
            txttelefone.Enabled = false;
            txtcelular.Enabled = false;
            txtemail.Enabled = false;
            txtrg.Enabled = false;
            txtcpf.Enabled = false;
            txtnumero.Enabled = false;
            txtendereco.Enabled = false;
            txtbairro.Enabled = false;

            txtpesqnome.Enabled = false;



        }
        
        // conexão com banco de dados 
        SqlConnection sqlCon = null;
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CRUD;Data Source=DESKTOP-BFMCR9C";
        private string strsql = string.Empty;




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtcelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtrg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)  // Botao pesquisar
        {
            strsql = "select *from temakeria where Nome=@pesquisa";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strsql, sqlCon);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = txtpesqnome.Text;

            try
            {
                if (txtpesqnome.Text == string.Empty)
                {
                    MessageBox.Show("VOCE NAO DIGITOU O NOME");
                }

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("ESTE NOME NÃO ESTA CADASTRADO");
                }

                dr.Read();

                txtnome.Text = Convert.ToString(dr["Nome"]);
                txttelefone.Text = Convert.ToString(dr["Telefone"]);
                txtcelular.Text = Convert.ToString(dr["celular"]);
                txtemail.Text = Convert.ToString(dr["Email"]);
                txtendereco.Text = Convert.ToString(dr["Endereco"]);
                txtnumero.Text = Convert.ToString(dr["Numero"]);
                txtbairro.Text = Convert.ToString(dr["Bairro"]);
                txtrg.Text = Convert.ToString(dr["RG"]);
                txtcpf.Text = Convert.ToString(dr["CPF"]);

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

            txtpesqnome.Clear();
        }


        private void button2_Click(object sender, EventArgs e) //Botao Adicionar
        {
            strsql = "insert into temakeria (Nome,Telefone,Celular,Email,Endereco,Numero,Bairro,RG,CPF) values(@Nome,@telefone,@Celular,@Email,@Endereco,@Numero,@Bairro,@RG,@CPF)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strsql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtnome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txttelefone.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = txtcelular.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtemail.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txtendereco.Text;
            comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txtnumero.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txtbairro.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txtrg.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txtcpf.Text;

           // Tratamento de erro 
        try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("CADASTRO EFETUADO COM SUCESSO");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }


            txtpesqnome.Enabled = false;
            // Limpar os campos apos cadastramento efetuado
            txtnome.Clear();
            txttelefone.Clear();
            txtcelular.Clear();
            txtemail.Clear();
            txtrg.Clear();
            txtcpf.Clear();
            txtnumero.Clear();
            txtendereco.Clear();
            txtbairro.Clear();
            txtpesqnome.Clear();



        }

        private void addfuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            // Habilitar todos os campos após clicar na opção adicionar
            txtnome.Enabled = true;
            txttelefone.Enabled = true;
            txtcelular.Enabled = true;
            txtemail.Enabled = true;
            txtrg.Enabled = true;
            txtcpf.Enabled = true;
            txtnumero.Enabled = true;
            txtendereco.Enabled = true;
            txtbairro.Enabled = true;
            txtpesqnome.Enabled = true;
        }
    }
}


