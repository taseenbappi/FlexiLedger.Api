using FlexiLedger.Api.Models.Domain;

namespace FlexiLedger.Api.Repositories
{
    public interface IFlexiNumberRepository
    {
        Task<IEnumerable<FlexiNumber>> GetAllAsync();
    }
}