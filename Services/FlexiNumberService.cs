using FlexiLedger.Api.Models.Domain;
using FlexiLedger.Api.Repositories;

namespace FlexiLedger.Api.Services;

public class FlexiNumberService(IFlexiNumberRepository _flexiNumberRepository) : IFlexiNumberService
{
    public async Task<FlexiNumber> AddAsync(FlexiNumber flexiNumber)
    {
        return await _flexiNumberRepository.AddAsync(flexiNumber);
    }

    public async Task<IEnumerable<FlexiNumber>> GetAllAsync()
    {
        return await _flexiNumberRepository.GetAllAsync();
    }

    public async Task<FlexiNumber?> GetByIdAsync(int id)
    {
        return await _flexiNumberRepository.GetByIdAsync(id);
    }

    public async Task<FlexiNumber?> UpdateAsync(FlexiNumber flexiNumber)
    {
        if (await _flexiNumberRepository.GetByIdAsync(flexiNumber.Id) is null)
        {
            return null;
        }
        return await _flexiNumberRepository.UpdateAsync(flexiNumber);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _flexiNumberRepository.DeleteAsync(id);
    }
}
