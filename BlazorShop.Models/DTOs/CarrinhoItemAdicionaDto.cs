using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models.DTOs;
public class CarrinhoItemAdicionaDto
{
    [Required] // <- validação de dados que vão ser requeridos para adicionar item ao carrinho
    public int CarrinhoId { get; set; }
    [Required]
    public int ProdutoId { get; set; }
    [Required]
    public int Quantidade { get; set; }
}
