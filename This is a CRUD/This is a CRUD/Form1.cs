using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace This_is_a_CRUD {
    public partial class main : Form {
        
        public main() {
            InitializeComponent();
            
        }
        
        private bool click_old = false;

        connection conn = new connection();

        private void connect_Click(object sender, EventArgs e) {

            string server = server_input.Text;
            string database = database_input.Text;
            string username = username_input.Text;
            string password = password_input.Text;

            bool conn_stats;
            
            conn_stats = conn.db_conn(username, password, server, database, 0);
            
            if (!click_old) {

                refresh_btn.Enabled = false;

                if (conn_stats == false) {

                } else {
                    click_old = true;
                    status.Text = "Conectado!";
                    status.ForeColor = Color.Green;
                    connection_status.Text = "Online como";
                    conection_address.Text = username + "@" + server;
                    connect.Text = "Desconectar";
                    refresh_btn.Enabled = true;

                    username_input.ReadOnly = true;
                    database_input.ReadOnly = true;
                    password_input.ReadOnly = true;
                    server_input.ReadOnly = true;                                       
                    
                    clientes_view.DataSource = conn.get_data("SELECT * FROM clientes_table");
                    parentes_view.DataSource = conn.get_data("SELECT * FROM parentes_table");

                    /*
                    foreach (string item in GetListByDataTable(conn.get_data("SELECT * FROM parentes"))) {
                        MessageBox.Show(item);
                    }
                    */

                }

            } else {
                if (conn_stats == true) {
                    click_old = !click_old;
                    conn.db_conn("", "", "", "", 1);

                    status.Text = "Desconectado";
                    status.ForeColor = Color.Red;
                    connection_status.Text = "Desconectado";
                    conection_address.Text = "User@Server";
                    connect.Text = "Conectar";
                    
                    username_input.ReadOnly = false;
                    database_input.ReadOnly = false;
                    password_input.ReadOnly = false;
                    server_input.ReadOnly = false;
                    refresh_btn.Enabled = false;


                } else {

                }
            }
        }

        private void main_Load(object sender, EventArgs e) {

        }

        private void refresh_btn_Click(object sender, EventArgs e) {
            clientes_view.DataSource = conn.get_data("SELECT * FROM clientes_table");
            parentes_view.DataSource = conn.get_data("SELECT * FROM parentes_table");
            
        }
        
    }
}

