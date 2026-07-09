using FlexiLedger.Api.Models.Domain;
using FlexiLedger.Api.Models.DTOs;

namespace FlexiLedger.Api.Repositories
{
    public interface IFlexiRechargeRepository
    {
        Task<IEnumerable<FlexiRecharge>> GetAllAsync();
        Task<FlexiRecharge?> GetByIdAsync(int id);
        Task<FlexiRechargeRequestDto> AddAsync(FlexiRechargeRequestDto flexiRecharge);
        Task<FlexiRecharge?> UpdateAsync(FlexiRecharge flexiRecharge);
        Task<bool> DeleteAsync(int id);
    }
}