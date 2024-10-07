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


namespace MapaSala.Formularios.editar
{
    public partial class frmEditarDisciplina : Form
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao; //comunicacao programa/banco
        public frmEditarDisciplina(int DisciplinaId)
        {
            InitializeComponent();
            string query = "select Id, Nome, Siga, Ativo" + "from Disciplina where Id = @Id";
        
            Conexao.Open();
            string query = "SELECT * FROM DISCIPLINAS ORDER BY Id desc";
            SqlCommand Comando = new SqlCommand(query, Conexao);
            Comando.Parameters.Add(new SqlParameter("@Id", DisciplinaId));
            SqlDataReader Leitura = Comando.ExecuteReader();
            if (Leitura.HasRows) //a linha existe? true or false
            {
                while (Leitura.Read())//para pegar mais de um registro, faz uma consulta
                {
                    label_Id.Text = Leitura[0].ToString();
                    txtNomeDisciplina.Text = Leitura[1].ToString();
                    txtSigla.Text = Leitura[2].ToString();
                    chkAtivo.Checked = Convert.ToBoolean(Leitura[3]);



                }
            }
            Conexao.Close();
        }

    
    }
}
