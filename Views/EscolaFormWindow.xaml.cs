using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using Projeto_escola.DataBase;
using Projeto_escola.Models;

namespace Projeto_escola.Views
{
    /// <summary>
    /// Lógica interna para EscolaFormWindow.xaml
    /// </summary>
    public partial class EscolaFormWindow : Window
    {
        private Escola _escola = new Escola();   
        public EscolaFormWindow()
        {
            InitializeComponent();
        }

        private void txt_complemento_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        

        private void bt_salvar_Click(object sender, RoutedEventArgs e)
        {
            


            _escola.NomeFantasia = txt_nome.Text;
            _escola.RazaoSocial = txt_razao.Text;
            _escola.Cnpj = txt_cnpj.Text;
            _escola.InscricaoEst = txt_inscricao.Text;
            _escola.DataCriacao = dp_data.DisplayDate;
            _escola.Responsavel = txt_nomeP.Text;
            _escola.ResponsavelTelefone = txt_telefoneP.Text;
            _escola.Email = txt_email.Text;
            _escola.Telefone = txt_telefone.Text;
            _escola.Rua = txt_rua.Text;
            _escola.Numero = txt_numero.Text;
            _escola.Bairro = txt_Bairro.Text;
            _escola.Complemento = txt_complemento.Text;
            _escola.Cep = txt_cep.Text;
            _escola.Cidade = txt_cidade.Text;
            _escola.Estado = Convert.ToString(cb_estado.Text);
             _escola.SetTipo((bool)rdb_publico.IsChecked);
            
            try
            {
                var dao = new EscolaDAO();
                dao.Insert(_escola);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //MessageBox.Show(_escola.Estado);
            /*string nomeFantasia = txt_nome.Text;
            string razao = txt_razao.Text;
            string cnpj = txt_cnpj.Text;  
            string inscricao = txt_inscricao.Text;
            string tipo = "Privado";
            
            if ((bool)rdb_publico.IsChecked)
                tipo = "Público";

            var data = dp_data.SelectedDate?.ToString("yyyy-MM-dd");
           
            string responsavel = txt_nomeP.Text;
            string resp_tele = txt_telefoneP.Text;
            string email = txt_email.Text;
            string telefone = txt_telefone.Text;
            string rua = txt_rua.Text;
            string numero = txt_numero.Text;
            string bairro = txt_Bairro.Text;
            string complemento = txt_complemento.Text;
            string cep = txt_cep.Text;
            string cidade = txt_cidade.Text;
            string estado = Convert.ToString(cb_estado.Text);
            */



            

            /*
             * try 

            {
                var conexao = new Conexao();
                var comando = conexao.Query();
                
                comando.CommandText = "INSERT INTO escola values (null, @nome, @razao, @cnpj, @inscricao, @tipo, @data_criacao, @responsavel, @resp_tel, " +
                    "@email, @telefone, @rua, @numero, @bairro, @complemento, @cep, @cidade, @estado)";
               
                comando.Parameters.AddWithValue("@nome", _escola.NomeFantasia );
                comando.Parameters.AddWithValue("@razao", _escola.RazaoSocial);
                comando.Parameters.AddWithValue("@cnpj", cpf);
                comando.Parameters.AddWithValue("@inscricao", inscricao);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@data_criacao", data);
                comando.Parameters.AddWithValue("@responsavel",responsavel);
                comando.Parameters.AddWithValue("@resp_tel", resp_tele);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@rua", rua);
                comando.Parameters.AddWithValue("@numero", numero);
                comando.Parameters.AddWithValue("@bairro", bairro);
                comando.Parameters.AddWithValue("@complemento", complemento);
                comando.Parameters.AddWithValue("@cep", cep);
                comando.Parameters.AddWithValue("@cidade", cidade);
                comando.Parameters.AddWithValue("@estado", estado);

                var resultado = comando.ExecuteNonQuery();

                if( resultado > 0)
                {
                    MessageBox.Show("Registro salvo com sucesso!");
                }
            } 
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }*/

            //DUDU 45 DE BRAÇO
        }
    }
}
