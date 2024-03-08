using repositorio;

namespace AppClientes;

class Program{

    static ClienteRepositorio _clienterepositorio = new ClienteRepositorio();

    static void Main(string[] args){
        
        while(true){
            Menu();
            Console.ReadKey();    
        }
            
    }

    static void Menu(){
        Console.Clear();
        
        Console.WriteLine("****************************");
        Console.WriteLine("*       MENU DE OPÇÕES     *");
        Console.WriteLine("*        APP CLIENTES      *");
        Console.WriteLine("****************************");
        Console.WriteLine("* 1 - CADASTRAR CLIENTES   *");
        Console.WriteLine("* 2 -   EXIBIR CLIENTE     *");
        Console.WriteLine("* 3 -   EDITAR CLIENTE     *");
        Console.WriteLine("* 4 -   EXCLUIR CLIENTE    *");
        Console.WriteLine("* 5 -             knkn         *");
        Console.WriteLine("* 6 -        SAIR          *");
        Console.WriteLine("****************************");

        EscolherOpcao();
        
    }


    static void EscolherOpcao(){
        Console.WriteLine("ESCOLHA UMA OPÇÃO: ");
        var opcao = Console.ReadLine();

        switch (int.Parse(opcao)){
            
            case 1: {
                _clienterepositorio.CadastrarCliente();
                Menu();
                break;
            }

            case 2:{
                _clienterepositorio.ExibirCliente();
                Menu();
                break;
            }

            case 3:{
                _clienterepositorio.EditarCliente();
                Menu();
                break;
            }
            case 4:{
                _clienterepositorio.ExcluirClinte();
                Menu();
                break;
            }
            case 6:{
                Environment.Exit(0);
                break;
            }
            default:{
                Console.Clear();
                Console.WriteLine("OPÇÃO INVÁLIDA!");
                break;
            }

        }
    }


}