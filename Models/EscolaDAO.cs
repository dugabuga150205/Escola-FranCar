using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_escola.DataBase;
    


namespace Projeto_escola.Models
{
    internal class EscolaDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Escola escola)
        {
            try

            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO escola values (null, @nome, @razao, @cnpj, @inscricao, @tipo, @data_criacao, @responsavel, @resp_tel, " +
                    "@email, @telefone, @rua, @numero, @bairro, @complemento, @cep, @cidade, @estado)";

                var data = escola.DataCriacao?.ToString("yyyy-MM-dd");

                comando.Parameters.AddWithValue("@nome", escola.NomeFantasia);
                comando.Parameters.AddWithValue("@razao", escola.RazaoSocial);
                comando.Parameters.AddWithValue("@cnpj", escola.Cnpj);
                comando.Parameters.AddWithValue("@inscricao", escola.InscricaoEst);
                comando.Parameters.AddWithValue("@tipo", escola.Tipo);
                comando.Parameters.AddWithValue("@data_criacao", data);
                comando.Parameters.AddWithValue("@responsavel", escola.Responsavel);
                comando.Parameters.AddWithValue("@resp_tel", escola.ResponsavelTelefone);
                comando.Parameters.AddWithValue("@email", escola.Email);
                comando.Parameters.AddWithValue("@telefone", escola.Telefone);
                comando.Parameters.AddWithValue("@rua", escola.Rua);
                comando.Parameters.AddWithValue("@numero", escola.Numero);
                comando.Parameters.AddWithValue("@bairro", escola.Bairro);
                comando.Parameters.AddWithValue("@complemento", escola.Complemento);
                comando.Parameters.AddWithValue("@cep", escola.Cep);
                comando.Parameters.AddWithValue("@cidade", escola.Cidade);
                comando.Parameters.AddWithValue("@estado", escola.Estado);

                var resultado = comando.ExecuteNonQuery();

                /*if (resultado > 0)
                {
                    MessageBox.Show("Registro salvo com sucesso!");
                }*/
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        





    }
}
