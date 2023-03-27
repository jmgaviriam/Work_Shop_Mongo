using DrivenAdapter.Mongo.EntitiesMongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivenAdapter.Mongo.Interfaces
{
	public interface IContext
	{
		public IMongoCollection<DirectorEntitie> Directores { get; }


	}
}
