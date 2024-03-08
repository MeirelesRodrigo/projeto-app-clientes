using Cadastro;

namespace repositorio;

public class ClienteRepositorio(){

    public List<Clientes> clientes = new List<Clientes>();

    public void ExcluirClinte(){
        Console.Clear();
        Console.WriteLine("INFORME O CÓDIGO DO CLIENTE ");
        var codigocliente = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigocliente));

        if(cliente == null){
            Console.WriteLine("CLIENTE NÃO ENCONTRADO! PRESSIONE [ENTER]");
            Console.ReadKey();
            return;
        }

        ImprimirCliente(cliente);
        clientes.Remove(cliente);
        Console.WriteLine("CLIENTE REMOVIDO COM SUCESSO! PRESSIONE [ENTER]");
        Console.ReadKey();
    }

    public void EditarCliente(){
        Console.Clear();
        Console.WriteLine("INFORME O CÓDIGO DO CLIENTE: ");
        var codigocliente = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigocliente));

        if(cliente == null){
            Console.WriteLine("CLIENTE NÃO ENCONTRADO! PRESSIONE [ENTER]");
            Console.ReadKey();
            return;
        }
        ImprimirCliente(cliente);

        Console.WriteLine("NOME CLIENTE: ");
        var nome = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("DATA NASCIMENTO: ");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);
        
        Console.WriteLine("DESCONTO: ");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        cliente.NomeCliente = nome;
        cliente.DtNascimento = dataNascimento;
        cliente.Desconto = desconto;


        Console.WriteLine("CLIENTE ALTERADO COM SUCESSSO, PRESSIONE [ENTER]");
        ImprimirCliente(cliente);
        Console.ReadKey();

    }

    public void CadastrarCliente(){
        Console.Clear();

        Console.WriteLine("INFORME O NOME DO CLIENTE");
        var nome = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("INFORME A DATA DE NASCIMENTO");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.WriteLine("INFORME O DESCONTO");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        //criando um instancia e atribuindo o que foi digitado para a propriedade na classe Cliente.
        var cliente = new Clientes();
        cliente.Id = clientes.Count +1;
        cliente.NomeCliente = nome;
        cliente.DtNascimento = dataNascimento;
        cliente.Desconto = desconto;
        cliente.CadastradoEm = DateTime.Now;

        clientes.Add(cliente);
        Console.WriteLine("CLIENTE CADASTRADO COM SUCESSO! PRESSIONE [ENTER]");
        ImprimirCliente(cliente);
        Console.ReadKey();
    }

    //CLASSE PARA MANIPULAR AS INFORMAÇÇOES DO CLIENTE.
    public void ImprimirCliente(Clientes cliente){ //INSTANCIA QUE CONTEM OS DADOS DOS CLIENTES
        Console.WriteLine("**********************************************************");
        Console.WriteLine("ID...............: "+cliente.Id);
        Console.WriteLine("NOME.............: "+cliente.NomeCliente);
        Console.WriteLine("DESCONTO.........: "+cliente.Desconto);
        Console.WriteLine("DATA NASCIMENTO..: "+cliente.DtNascimento);
        Console.WriteLine("CADASTRADO EM....: "+cliente.CadastradoEm);
        Console.WriteLine("**********************************************************");
    }

    //imprimindo os clientes que estao estanciados na lista !
    public void ExibirCliente(){
        Console.Clear();

        foreach (var exibirclientes in clientes)
        {
            ImprimirCliente(exibirclientes);
        }
            Console.ReadKey();
    }


}