namespace Cadastro;


public class Clientes(){

    public int Id { get; set; }
    public string NomeCliente { get; set; }
    public DateOnly DtNascimento { get; set; }
    public DateTime CadastradoEm {get; set;}
    public decimal Desconto { get; set; }

}