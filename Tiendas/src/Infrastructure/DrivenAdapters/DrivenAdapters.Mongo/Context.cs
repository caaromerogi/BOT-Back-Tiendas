using DrivenAdapters.Mongo.Entities;
using MongoDB.Driver;
using System.Diagnostics.CodeAnalysis;

namespace DrivenAdapters.Mongo
{
    /// <summary>
    /// Context is an implementation of <see cref="IContext"/>
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Context : IContext
    {
        private readonly IMongoDatabase _database;

        /// <summary>
        /// crea una nueva instancia de la clase <see cref="Context"/>
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="databaseName"></param>
        public Context(string connectionString, string databaseName)
        {
            MongoClient _mongoClient = new MongoClient(connectionString);
            _database = _mongoClient.GetDatabase(databaseName);
        }

        /// <summary>
        /// <see cref="IContext.Tiendas"/>
        /// </summary>
        public IMongoCollection<TiendaEntity> Tiendas => _database.GetCollection<TiendaEntity>("Tiendas");

        /// <summary>
        /// <see cref="IContext.Tipos"/>
        /// </summary>
        public IMongoCollection<TipoEntity> Tipos => _database.GetCollection<TipoEntity>("TiposTienda");
    }
}