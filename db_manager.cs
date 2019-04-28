using System.Data.SqlClient;

namespace CRUD {   

    class db_manager {

        // Método para mostrar as tabelas da base de dados
        public void show_tables() {
            // Criar o conector para o banco de dados
            SqlConnection db_conn = new SqlConnection();

            // Conectar ao banco de dados
            db_conn.ConnectionString = "Data source=(localdb)\\MSSQLLocalDB";
            
        }

    }


}
