using System;
using System.Data.SqlClient;

namespace CRUD {
    class Program {
        
        private static void Menu() {

            // Menu

            Console.WriteLine("  ╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("  ║                    Basic CRUD :: by Luiz                   ║");
            Console.WriteLine("  ╚════════════════════════════════════════════════════════════╝\n");

            Console.WriteLine("  ╔══════════════════════|Menu principal|══════════════════════╗");
            Console.WriteLine("  ║                                                            ║");
            Console.WriteLine("  ║ > Digite o número da opção desejada!                       ║");
            Console.WriteLine("  ║                                                            ║");
            Console.WriteLine("  ╠════════════════════════════════════════════════════════════╣");
            Console.WriteLine("  ║ >> 1. Ver tabelas disponíveis;                             ║");
            Console.WriteLine("  ║ >> 2. Ver dados gravados nas tabelas;                      ║");
            Console.WriteLine("  ║ >> 3. Adicionar item na tabela;                            ║");
            Console.WriteLine("  ║ >> 4. Atualizar dado na tabela;                            ║");
            Console.WriteLine("  ║ >> 5. Remover item da tabela;                              ║");
            Console.WriteLine("  ║ >> Enter 2x para sair;                                     ║");
            Console.WriteLine("  ╚════════════════════════════════════════════════════════════╝\n");   
        }

        static void Main() {

            // Carregar o MENU e tratar entrada do usuário;
            Menu();

            while (true) {
                Console.Write(" :: Opção > ");
                var comando = Console.ReadLine();

                if (comando == "1") {

                    // Declarando a variável que utilizará o método "show_tables" da classe "db_manager";
                    db_manager list = new db_manager();
                    list.show_tables();

                }                
                
            }
            

                
        }
    }
}
