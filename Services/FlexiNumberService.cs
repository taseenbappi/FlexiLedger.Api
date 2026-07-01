using FlexiLedger.Api.Models.Domain;
using FlexiLedger.Api.Repositories;

namespace FlexiLedger.Api.Services;

public class FlexiNumberService(IFlexiNumberRepository _flexiNumberRepository) : IFlexiNumberService
{

    public async Task<IEnumerable<FlexiNumber>> GetAllAsync()
    {
        return await _flexiNumberRepository.GetAllAsync();
    }
}
