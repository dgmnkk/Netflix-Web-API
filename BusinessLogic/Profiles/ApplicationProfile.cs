using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;


namespace BusinessLogic.Profiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile(IFileService fileService)
        {
            CreateMap<MovieDto, Movie>()
                .ForMember(x => x.Genre, opt => opt.Ignore());
            CreateMap<Movie, MovieDto>();

            CreateMap<Genre, GenreDto>().ReverseMap();
            CreateMap<Selection, SelectionDto>().ReverseMap();

            CreateMap<CreateMovieModel, Movie>()
                .ForMember(x => x.Image, opt => opt.MapFrom(src => fileService.SaveMovieImage(src.Image).Result));

            CreateMap<RegisterModel, User>()
                .ForMember(x => x.UserName, opts => opts.MapFrom(s => s.Email));
        }
    }
}
