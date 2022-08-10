namespace Aprendendo_API.NovaPasta3
{
    public class Produto
    {
     public int ProdutoID { get; set; }
     public string?Nome { get; set; }
     public string?Descrição { get; set; }
     public decimal Preço { get; set;}
     public string?ImagemUrl { get; set; }
     public float  Estoque { get; set; }
     public DateTime DataCadastro { get; set; }
    }
}
