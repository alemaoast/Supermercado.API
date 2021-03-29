namespace Supermercado.API.Domain.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public short QuantidadedePacote { get; set; }
        public EUnidadeMedida UnidadeMedida { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}