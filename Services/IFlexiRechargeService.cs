using FlexiLedger.Api.Models.Domain;
using FlexiLedger.Api.Models.DTOs;

namespace FlexiLedger.Api.Services
{
    public interface IFlexiRechargeService
    {
        Task<IEnumerable<FlexiRecharge>> GetAllAsync();
        Task<FlexiRecharge?> GetByIdAsync(int id);
        Task<FlexiRechargeRequestDto> AddAsync(FlexiRechargeRequestDto flexiRecharge);
        Task<FlexiRecharge?> UpdateAsync(FlexiRecharge flexiRecharge);
        Task<bool> DeleteAsync(int id);
    }
}