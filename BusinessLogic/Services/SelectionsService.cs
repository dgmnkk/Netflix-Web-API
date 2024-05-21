using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using BusinessLogic.Specifications;
using System.Net;

namespace BusinessLogic.Services
{
    public class SelectionsService : ISelectionsService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Selection> selectionR;

        public SelectionsService(IMapper mapper, IRepository<Selection> selectionR)
        {
            this.mapper = mapper;
            this.selectionR = selectionR;
        }

        public async Task<IEnumerable<SelectionDto>> GetAll()
        {
            return mapper.Map<List<SelectionDto>>(selectionR.GetAll());
        }

    }
}
