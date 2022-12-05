using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_BCrypt
{
    public class Cadastro
    {
        public string Usuario { get; set; } = "usuário desconhecido";
        public string Senha { get; set; }

        public void Cad() // Método para cadastro
        {
            Console.WriteLine("Faça seu cadastro\n");
            Console.Write("Usuário: ");
            Usuario = Console.ReadLine();
            Console.Write("Senha: ");
            Senha = Console.ReadLine();
            var password = Senha = BCrypt.Net.BCrypt.HashPassword(Senha); // Método para criptografar a senha do usuário
            Console.WriteLine("\nCadastro Realizado!\nTecle ENTER para fazer Login");
            Console.ReadKey();
            Console.Clear();
        }
        public void Login() // Método para realizar login
        {
            bool userLoginMenu = true;
            bool userLogin;
            while (userLoginMenu)
            {
                Console.WriteLine("Área de Login\n");
                Console.Write("Usuário: ");
                var inputUserLogin = Console.ReadLine();
                Console.Write("Senha: ");
                var inputUserPassword = Console.ReadLine();
                if (inputUserLogin != Usuario)
                    userLogin = false;
                else
                {
                    userLogin = true;
                }
                bool validatePassword = BCrypt.Net.BCrypt.Verify(inputUserPassword, Senha); // Método para verificar a senha do usuário (Retorna true ou false)
                if (validatePassword && userLogin == true) // Se o usuário e a senha forem true, o acesso é garantido
                {
                    Console.WriteLine("\nAcesso autorizado!");
                    Console.WriteLine("Tecle ENTER para voltar ao Menu Principal");
                    Console.ReadKey();
                    Console.Clear();
                    userLoginMenu = false;
                }
                else // Caso usuário e senham não sejam ambos true, o acesso é negado
                {
                    Console.WriteLine("\nAcesso negado!");
                    Console.WriteLine("Tecle ENTER para tentar novamente");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }
    }
}
