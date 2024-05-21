using BusinessLogic.DTOs;

namespace BusinessLogic.Interfaces
{
    public interface IMoviesService
    {
        Task<IEnumerable<MovieDto>> GetAll();
        Task<IEnumerable<MovieDto>> Get(IEnumerable<int> ids);
        Task<MovieDto?> Get(int id);
        Task<IEnumerable<MovieDto>> GetByGenre(int id);
        Task<IEnumerable<MovieDto>> GetBySelection(int id);
        void Create(CreateMovieModel product);
        void Edit(MovieDto product);
        void Delete(int id);
    }
}
