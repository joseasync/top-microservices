using Catalogo.API.Entidades;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo.API.Data
{
    public interface ICatalogoContext
    {
        IMongoCollection<Produto> Produtos { get; }
    }
}
