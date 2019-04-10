using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GEFIDAPI.Models
{
    public class DalHelper
    {
        protected static string GetStringConexao()
        {
            return ConfigurationManager.ConnectionStrings["GEFIDAPIModelos"].ConnectionString;
        }

        public static List<Acesso> GetAcessos()
        {
            List<Acesso> _acessos = new List<Acesso>();
            using (SqlConnection con = new SqlConnection(GetStringConexao()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM acesso", con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                var acesso = new Acesso();
                                acesso.IdLogin = Convert.ToInt32(dr["idLogin"]);
                                acesso.IdGrupo = Convert.ToInt32(dr["idGrupo"]);
                                acesso.Email = dr["email"].ToString();
                                acesso.Senha = dr["senha"].ToString();
                                acesso.Cpf = dr["cpf"].ToString();
                                acesso.Ativo = Convert.ToBoolean(dr["ativo"]);
                                acesso.Nome = dr["nome"].ToString();
                                acesso.Sobrenome = dr["sobrenome"].ToString();
                                acesso.IdCliente = Convert.ToInt32(dr["idCliente"]);
                                _acessos.Add(acesso);
                            }
                        }
                        return _acessos;
                    }
                }
            }
        }

        public static Acesso GetAcesso(string id)
        {
            Acesso _acesso = null;
            using (SqlConnection con = new SqlConnection(GetStringConexao()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM acesso WHERE cpf='" + id + "'", con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                _acesso = new Acesso();
                                _acesso.IdLogin = Convert.ToInt32(dr["idLogin"]);
                                _acesso.IdGrupo = Convert.ToInt32(dr["idGrupo"]);
                                _acesso.Email = dr["email"].ToString();
                                _acesso.Senha = dr["senha"].ToString();
                                _acesso.Cpf = dr["cpf"].ToString();
                                _acesso.Ativo = Convert.ToBoolean(dr["ativo"]);
                                _acesso.Nome = dr["nome"].ToString();
                                _acesso.Sobrenome = dr["sobrenome"].ToString();
                                _acesso.IdCliente = Convert.ToInt32(dr["idCliente"]);
                            }
                        }
                        return _acesso;
                    }
                }
            }
        }

        public static int InsertAcesso(Acesso acesso)
        {
            int reg = 0;
            using (SqlConnection con = new SqlConnection(GetStringConexao()))
            {
                string sql = "INSERT INTO acesso (idGrupo,email,senha,cpf,ativo,nome,sobrenome,idCliente) values (@idGrupo,@email,@senha,@cpf,@ativo,@nome,@sobrenome,@idCliente)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idGrupo", acesso.IdGrupo);
                    cmd.Parameters.AddWithValue("@email", acesso.Email);
                    cmd.Parameters.AddWithValue("@senha", acesso.Senha);
                    cmd.Parameters.AddWithValue("@cpf", acesso.Cpf);
                    cmd.Parameters.AddWithValue("@ativo", acesso.Ativo);
                    cmd.Parameters.AddWithValue("@nome", acesso.Nome);
                    cmd.Parameters.AddWithValue("@sobrenome", acesso.Sobrenome);
                    cmd.Parameters.AddWithValue("@idCliente", acesso.IdCliente);

                    con.Open();
                    reg = cmd.ExecuteNonQuery();
                    con.Close();
                }
                return reg;
            }
        }

        public static int UpdateAcesso(Acesso acesso)
        {
            int reg = 0;
            using (SqlConnection con = new SqlConnection(GetStringConexao()))
            {
                string sql = "UPDATE acesso SET email=@email, senha=@senha, nome=@nome, sobrenome=@sobrenome";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@email", acesso.Email);
                    cmd.Parameters.AddWithValue("@senha", acesso.Senha);
                    cmd.Parameters.AddWithValue("@nome", acesso.Nome);
                    cmd.Parameters.AddWithValue("@sobrenome", acesso.Sobrenome);

                    con.Open();
                    reg = cmd.ExecuteNonQuery();
                    con.Close();
                }
                return reg;
            }
        }

        public static int DeleteAcesso(int id)
        {
            int reg = 0;
            using (SqlConnection con = new SqlConnection(GetStringConexao()))
            {
                string sql = "DELETE FROM acesso WHERE id=" + id;
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idLogin", id);
                    con.Open();
                    reg = cmd.ExecuteNonQuery();
                    con.Close();
                }
                return reg;
            }
        }
    }
}