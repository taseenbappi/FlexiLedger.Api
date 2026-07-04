using FlexiLedger.Api.Models.Domain;

namespace FlexiLedger.Api.Services;

public interface IFlexiNumberService
{
    Task<IEnumerable<FlexiNumber>> GetAllAsync();
    Task<FlexiNumber?> GetByIdAsync(int id);
    Task<FlexiNumber> AddAsync(FlexiNumber flexiNumber);
    Task<FlexiNumber?> UpdateAsync(FlexiNumber flexiNumber);
    Task<bool> DeleteAsync(int id);
}
