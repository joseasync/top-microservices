using Catalogo.API.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo.API.Repositorio
{
    public interface IProdutoRepository
    {
        Task CreateProduto(Produto produto);
        Task<bool> UpdateProduto(Produto produto);
        Task<bool> DeleteProduto(Produto produto);
        Task<IEnumerable<Produto>> GetProdutos();
        Task<Produto> GetProduto(string id);
        Task<IEnumerable<Produto>> GetProdutosPorNome(string nome);
        Task<IEnumerable<Produto>> GetProdutosPorCategoria(string categoria);
    }
}
