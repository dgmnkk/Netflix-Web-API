using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Specifications;
using System.Net;

namespace BusinessLogic.Services
{
    public class GenresServices : IGenresService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Genre> genresR;

        public GenresServices(IMapper mapper, IRepository<Genre> genresR)
        {
            this.mapper = mapper;
            this.genresR = genresR;
        }

        public async Task<IEnumerable<GenreDto>> GetAll()
        {
            return mapper.Map<List<GenreDto>>(genresR.GetAll());
        }

        public async Task<GenreDto?> Get(int id)
        {
            var item = await genresR.GetListBySpec(new GenreSpecs.ById(id));
            if (item == null) throw new HttpException(Errors.ItemNotFound, HttpStatusCode.NotFound);
            return mapper.Map<GenreDto?>(item);
        }
    }
}
