using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace formulario_melo.Classes
{
    class Funcionario
    {
        public int codigo;
        public String nome;
	    public String rua;
	    public int numero;
	    public String complemento;
	    public String bairro;
	    public String cidade;
	    public String uf;
	    public String pais;
	    public String data;
	    public String cpf;
	    public String rg;
	    public String pai;
	    public String mae;

        public void inserir(Funcionario f) {
            Banco banco = new Banco();
            SqlConnection connection = banco.con();
            String sql = "insert into cadastro (nome,rua,numero,complemento,bairro,cidade,uf,pais,data,cpf,rg,pai,mae) values (";
            sql += "'"+f.nome+"', '"+f.rua+"', "+f.numero+", '"+f.complemento+"', '"+f.bairro+"', '"+f.cidade+"', '"+f.uf+"', ";
            sql += "'"+f.pais+"', '"+f.data+"', '"+f.cpf+"', '"+f.rg+"', '"+f.pai+"', '"+f.mae+"')";
            SqlCommand Commando = new SqlCommand(sql, connection);
            connection.Open();
            Commando.ExecuteNonQuery();
            connection.Close();
        }

        public List<Funcionario> lista() {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Banco b = new Banco();
            SqlConnection connection = b.con();
            String sql = "select * from cadastro";
            SqlCommand Commando = new SqlCommand(sql, connection);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read()) {
                Funcionario f = new Funcionario();
                f.codigo = int.Parse(read[0].ToString());
                f.nome = read[1].ToString();
                f.rua = read[2].ToString();
                f.numero = int.Parse(read[3].ToString());
                f.complemento = read[4].ToString();
                f.bairro = read[5].ToString();
                f.cidade = read[6].ToString();
                f.uf = read[7].ToString();
                f.pais = read[8].ToString();
                f.data = read[9].ToString();
                f.cpf = read[10].ToString();
                f.rg = read[11].ToString();
                f.pai = read[12].ToString();
                f.mae = read[13].ToString();
                funcionarios.Add(f);
            }
            connection.Close();
            return funcionarios;
        }

        public List<Funcionario> Pesquisa(String cpf, int codigo, String rg) {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Banco b = new Banco();
            SqlConnection connection = b.con();
            String sql = "";

            if(cpf == "" && codigo == null && rg == ""){
                sql = "select * from cadastro";
            }
            if (cpf != "" && codigo != null) {
                sql = "select * from cadastro where cpf ='"+cpf+"' and codigo="+codigo+"";
            }

            if (codigo != null && rg != "")
            {
                sql = "select * from cadastro where rg ='" + rg + "' and codigo=" + codigo;
            }

            if (cpf != "" && rg != "")
            {
                sql = "select * from cadastro where rg ='" + rg + "' and cpf ='"+cpf+"'";
            }

            if (codigo != null) {
                sql = "select * from cadastro where codigo=" + codigo;
            }

            if (cpf != "") {
                sql = "select * from cadastro where cpf ='" + cpf + "'";
            }

            if (rg != "") {
                sql = "select * from cadastro where rg ='" + rg + "'";
            }
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                Funcionario f = new Funcionario();
                f.codigo = int.Parse(read[0].ToString());
                f.nome = read[1].ToString();
                f.rua = read[2].ToString();
                f.numero = int.Parse(read[3].ToString());
                f.complemento = read[4].ToString();
                f.bairro = read[5].ToString();
                f.cidade = read[6].ToString();
                f.uf = read[7].ToString();
                f.pais = read[8].ToString();
                f.data = read[9].ToString();
                f.cpf = read[10].ToString();
                f.rg = read[11].ToString();
                f.pai = read[12].ToString();
                f.mae = read[13].ToString();
                funcionarios.Add(f);
            }
            connection.Close();
            return funcionarios;
        }

        public void delete() { 
        
        }

        public void atualizar(Funcionario f)
        {
            Banco b = new Banco();
            SqlConnection connection = b.con();
            String sql = "update cadastro set nome = '"+f.nome+"', rua='"+ f.rua+"', numero="+f.numero+",";
            sql += "complemento='"+f.complemento+"', bairro='"+f.bairro+"', cidade='"+f.cidade+"', uf='"+f.uf+"',";
            sql +="pais='"+f.pais+"', data='"+f.data+"', cpf='"+f.cpf+"', rg='"+f.rg+"', pai='"+f.pai+"', mae='"+f.mae+"'";
            SqlCommand Commando = new SqlCommand(sql, connection);
            connection.Open();
            Commando.ExecuteNonQuery();
            connection.Close();
        }

    }
}
