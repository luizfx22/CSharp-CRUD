using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace This_is_a_CRUD {
    class connection {

        MySqlConnection con;
        
        public DataTable get_data(string query) {
            
            MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable data_table = new DataTable();

            data.Fill(data_table);

            return data_table;
            

        }

        public void open(MySqlConnection conn) {
            conn.Open();
            con = conn;
        }

        public void close(MySqlConnection conn) {
            conn.Close();
        }

        public bool db_conn(string uid, string pwd, string srvr, string db, int command) {
            string username = uid;
            string password = pwd;
            string database = db;
            string server = srvr;
            string conn_str;
            bool ret = true;

            conn_str = string.Format("server={0};database={1};uid={2};pwd={3}", server, database, username, password);
            MySqlConnection conn = new MySqlConnection(conn_str);


            if (command == 0) {  

                try {

                    open(conn);
                    ret = true;                    

                } catch (MySqlException ex) {

                    MessageBox.Show(ex.ToString());                    

                }

            } else if (command == 1) {

                if (conn.State == System.Data.ConnectionState.Open) {
                    try {

                        close(conn);
                        ret = false;


                    } catch (MySqlException ex) {

                        MessageBox.Show(ex.ToString());
                        
                    }
                }              
            }

            return ret;
        }
    }
}
