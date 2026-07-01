using FlexiLedger.Api.Infrastructure;
using FlexiLedger.Api.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FlexiLedger.Api.Repositories;

public class FlexiNumberRepository(FlexiLedgerDbContext _context) : IFlexiNumberRepository
{
    public async Task<IEnumerable<FlexiNumber>> GetAllAsync()
    {
        return await _context.FlexiNumbers.ToListAsync();
    }
}
