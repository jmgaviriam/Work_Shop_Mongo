using AutoMapper;
using Domain.Entities.Entities;
using Domain.UseCases.Gateway.Repository;
using DrivenAdapter.Mongo.EntitiesMongo;
using DrivenAdapter.Mongo.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivenAdapter.Mongo.Repositories
{
	public class DirectorRepository : IDirectorRepository
	{
		private readonly IMongoCollection<DirectorEntitie> coleccion;
		private readonly IMapper _mapper;

		public DirectorRepository(IContext context, IMapper mapper)
		{
			this.coleccion = context.Directores;
			_mapper = mapper;
		}

		public async Task<List<Director>> GetAllDirectorsAsync()
		{
			var directores = await coleccion.FindAsync(Builders<DirectorEntitie>.Filter.Empty);
			var listaDirectores = directores.ToEnumerable().Select(director => _mapper.Map<Director>(director)).ToList();
			return listaDirectores;
		}

		public Task<Director> GetDirectorByIdAsync(int idDirector)
		{
			throw new NotImplementedException();
		}

		public async Task<Director> InsertDirectorAsync(Director director)
		{
			var directorGuardar = _mapper.Map<DirectorEntitie>(director);
			await coleccion.InsertOneAsync(directorGuardar);
			return director;
		}

		public Task<Director> InsertDirectorSqlKataAsync(Director director)
		{
			throw new NotImplementedException();
		}
	}
}
