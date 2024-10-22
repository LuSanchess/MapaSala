using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaSala.Classes
{
    public class Usuarios
    {
       
        private SqlConnection Conexao = new SqlConnection ("Server = LS05MPF; Database=AULA_DS;User Id = sa; Password=admsasql;");// link do site /comunicacao programa/banco

        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        public void Inserir()
        {
            Conexao.Open();
            string query = "insert into Cursos(Nome, Turno,Sigla, Ativo) Values (@nome, @turno,@sigla,@ativo)";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro1 = new SqlParameter("@login",Login);
            SqlParameter parametro2 = new SqlParameter("@senha", Senha);
            SqlParameter parametro3 = new SqlParameter("@ativo",Ativo);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
          
            comando.ExecuteNonQuery(); //nao retorna nd
            Conexao.Close();
        }
    }
}
