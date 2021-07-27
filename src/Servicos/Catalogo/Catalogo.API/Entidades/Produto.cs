using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalogo.API.Entidades
{
    public class Produto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Nome { get; set; }
        public long Preco { get; set; }
        public string Moeda { get; set; }
        public string Categoria { get; set; }
        public string Imagem { get; set; }
    }
}
