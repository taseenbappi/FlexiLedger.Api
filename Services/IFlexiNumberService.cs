using FlexiLedger.Api.Models.Domain;

namespace FlexiLedger.Api.Services;

public interface IFlexiNumberService
{
    Task<IEnumerable<FlexiNumber>> GetAllAsync();
}
