using BlazorShop.API.Context;
using BlazorShop.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.API.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Produto> GetItem(int id)
    {
        var produto = await _context.Produtos.Include(c => c.Categoria).SingleOrDefaultAsync(c => c.Id == id); // <- consulta que retorna o produto com
                                                                                                               // o mesmo id pesquisado, junto com info categoria
        return produto;

    }

    public async Task<IEnumerable<Produto>> GetItens()
    {
        var produtos = await _context.Produtos.Include(p => p.Categoria).ToListAsync(); // <- retorna uma lista de produtos
        return produtos;
    }

    public async Task<IEnumerable<Produto>> GetItensPorCategoria(int id)
    {
        var produtos = await _context.Produtos.Include(p => p.Categoria).Where(p => p.CategoriaId == id).ToListAsync(); // <- retorna uma lista de itens em dada categoria
                                                                                                                        // onde categoria do produto tem que ser a mesma passada
        return produtos;
    }
}
