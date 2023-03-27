using AutoMapper;
using Domain.Entities.Commands;
using Domain.Entities.Entities;
using DrivenAdapter.Mongo.EntitiesMongo;

namespace Api.Mongo.Automapper
{
    public class ConfigurationProfile : Profile
    {

        public ConfigurationProfile()
        {
			CreateMap<InsertNewDirector, Director>().ReverseMap();
			CreateMap<DirectorEntitie, Director>().ReverseMap();
        }
    }
}
