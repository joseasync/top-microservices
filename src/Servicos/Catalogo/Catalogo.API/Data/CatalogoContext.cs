using Catalogo.API.Entidades;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogo.API.Data
{
    public class CatalogoContext : ICatalogoContext
    {
        public CatalogoContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DataBaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DataBaseSettings:Database"));
            Produtos = database.GetCollection<Produto>(configuration.GetValue<string>("DataBaseSettings:Collection"));
        }

        public IMongoCollection<Produto> Produtos { get; }
    }
}
