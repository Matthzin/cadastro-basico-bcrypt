using BCrypt.Net;
using Teste_BCrypt;

// Este projeto é uma aplicação de cadstro básico de usuário e senha utiliando criptografia de senha com a biblioteca BCrypt.Net;
// O projeto é um material para estudos da linguagem C# utilizando o .NET Framework 6.0; Este será atualizado com mais implementações de campos de cadastro;
// BCrypt.Net por ChrisMcKee no GitHub: https://github.com/BcryptNet/bcrypt.net

Cadastro cadastro = new Cadastro();

bool mainMenu = true;

while (mainMenu)
{
    Console.WriteLine("Menu principal\n");
    Console.WriteLine($"Olá, {cadastro.Usuario}! O que deseja fazer?\n");
    Console.WriteLine("1 - Cadastrar usuário\n2 - Sair");
    var userOptionMM = Convert.ToInt32(Console.ReadLine());
    if (userOptionMM == 1)
    {
        Console.Clear();
        cadastro.Cad();
        cadastro.Login();
    }
    if (userOptionMM == 2)
    {
        mainMenu= false;
    }
}

