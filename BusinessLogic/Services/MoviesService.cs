using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Specifications;
using System.Net;


namespace BusinessLogic.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Movie> moviesR;
        private readonly IRepository<Genre> genresR;
        //private readonly ShopDbContext context;

        public MoviesService(IMapper mapper,
                               IRepository<Movie> moviesR,
                                IRepository<Genre> genresR)
        {
            this.mapper = mapper;
            this.moviesR = moviesR;
            this.genresR = genresR;
        }

        public void Create(CreateMovieModel movie)
        {
            moviesR.Insert(mapper.Map<Movie>(movie));
            moviesR.Save();
        }

        public void Delete(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustBePositive, HttpStatusCode.BadRequest);

            // delete product by id
            var product = moviesR.GetById(id);

            if (product == null) throw new HttpException(Errors.ItemNotFound, HttpStatusCode.NotFound);

            moviesR.Delete(product);
            moviesR.Save();
        }

        public void Edit(MovieDto product)
        {
            moviesR.Update(mapper.Map<Movie>(product));
            moviesR.Save();
        }

        public async Task<MovieDto?> Get(int id)
        {
            if (id < 0) throw new HttpException(Errors.IdMustBePositive, HttpStatusCode.BadRequest);

            var item = await moviesR.GetItemBySpec(new MovieSpecs.ById(id));
            if (item == null) throw new HttpException(Errors.ItemNotFound, HttpStatusCode.NotFound);

            var dto = mapper.Map<MovieDto>(item);

            return dto;
        }

        public async Task<IEnumerable<MovieDto>> Get(IEnumerable<int> ids)
        {
            return mapper.Map<List<MovieDto>>(await moviesR.GetListBySpec(new MovieSpecs.ByIds(ids)));
        }

        public async Task<IEnumerable<MovieDto>> GetAll()
        {
            return mapper.Map<List<MovieDto>>(await moviesR.GetListBySpec(new MovieSpecs.All()));
        }

        public async Task<IEnumerable<MovieDto>> GetByGenre(int id)
        {
            return mapper.Map<List<MovieDto>>(await moviesR.GetListBySpec(new MovieSpecs.ByGenre(id)));
        }

        public async Task<IEnumerable<MovieDto>> GetBySelection(int id)
        {
            return mapper.Map<List<MovieDto>>(await moviesR.GetListBySpec(new MovieSpecs.BySelection(id)));
        }
    }
}
