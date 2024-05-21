using BusinessLogic.DTOs;


namespace BusinessLogic.Interfaces
{
    public interface ISelectionsService
    {
        Task<IEnumerable<SelectionDto>> GetAll();
        Task<SelectionDto> Get(int id);
    }
}
