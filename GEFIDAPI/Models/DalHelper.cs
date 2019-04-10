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
                                acesso.idLogin = Convert.ToInt32(dr["idLogin"]);
                                acesso.idGrupo = Convert.ToInt32(dr["idGrupo"]);
                                acesso.email = dr["email"].ToString();
                                acesso.senha = dr["senha"].ToString();
                                acesso.cpf = dr["cpf"].ToString();
                                acesso.ativo = Convert.ToBoolean(dr["ativo"]);
                                acesso.nome = dr["nome"].ToString();
                                acesso.sobrenome = dr["sobrenome"].ToString();
                                acesso.idCliente = Convert.ToInt32(dr["idCliente"]);
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
                                _acesso.idLogin = Convert.ToInt32(dr["idLogin"]);
                                _acesso.idGrupo = Convert.ToInt32(dr["idGrupo"]);
                                _acesso.email = dr["email"].ToString();
                                _acesso.senha = dr["senha"].ToString();
                                _acesso.cpf = dr["cpf"].ToString();
                                _acesso.ativo = Convert.ToBoolean(dr["ativo"]);
                                _acesso.nome = dr["nome"].ToString();
                                _acesso.sobrenome = dr["sobrenome"].ToString();
                                _acesso.idCliente = Convert.ToInt32(dr["idCliente"]);
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
                    cmd.Parameters.AddWithValue("@idGrupo", acesso.idGrupo);
                    cmd.Parameters.AddWithValue("@email", acesso.email);
                    cmd.Parameters.AddWithValue("@senha", acesso.senha);
                    cmd.Parameters.AddWithValue("@cpf", acesso.cpf);
                    cmd.Parameters.AddWithValue("@ativo", acesso.ativo);
                    cmd.Parameters.AddWithValue("@nome", acesso.nome);
                    cmd.Parameters.AddWithValue("@sobrenome", acesso.sobrenome);
                    cmd.Parameters.AddWithValue("@idCliente", acesso.idCliente);

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
                    cmd.Parameters.AddWithValue("@email", acesso.email);
                    cmd.Parameters.AddWithValue("@senha", acesso.senha);
                    cmd.Parameters.AddWithValue("@nome", acesso.nome);
                    cmd.Parameters.AddWithValue("@sobrenome", acesso.sobrenome);

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