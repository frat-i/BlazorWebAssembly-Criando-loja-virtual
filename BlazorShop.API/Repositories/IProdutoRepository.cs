using BlazorShop.API.Entities;

namespace BlazorShop.API.Repositories;

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> GetItens(); // <- aqui ele vai criar uma lista com os produtos e retornar todos os produtos de um carrinho
    Task<Produto> GetItem(int id); // <- vai pegar um produto pelo ID do produto

    Task<IEnumerable<Produto>> GetItensPorCategoria(int id); // vai retornar uma lista de produtos pelo ID da categoria selecionada
}
