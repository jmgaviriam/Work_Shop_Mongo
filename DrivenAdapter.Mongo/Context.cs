using DrivenAdapter.Mongo.EntitiesMongo;
using DrivenAdapter.Mongo.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivenAdapter.Mongo
{
	public class Context : IContext
	{
		private readonly IMongoDatabase _database;

		public Context(string stringConnection, string DBname)
		{
			MongoClient cliente = new MongoClient(stringConnection);
			_database = cliente.GetDatabase(DBname);
		}

		public IMongoCollection<DirectorEntitie> Directores => _database.GetCollection<DirectorEntitie>("directores");
	}
}
