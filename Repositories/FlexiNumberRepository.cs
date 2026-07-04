using FlexiLedger.Api.Infrastructure;
using FlexiLedger.Api.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FlexiLedger.Api.Repositories;

public class FlexiNumberRepository(FlexiLedgerDbContext _context) : IFlexiNumberRepository
{
    public async Task<FlexiNumber> AddAsync(FlexiNumber flexiNumber)
    {
        _context.FlexiNumbers.Add(flexiNumber);
        await _context.SaveChangesAsync();
        return flexiNumber;
    }

    public async Task<IEnumerable<FlexiNumber>> GetAllAsync()
    {
        return await _context.FlexiNumbers.ToListAsync();
    }

    public async Task<FlexiNumber?> GetByIdAsync(int id)
    {
        return await _context.FlexiNumbers.FindAsync(id);
    }

    public async Task<FlexiNumber?> UpdateAsync(FlexiNumber flexiNumber)
    {
        var existingFlexiNumber = await _context.FlexiNumbers.FindAsync(flexiNumber.Id);
        if (existingFlexiNumber is null)
        {
            return null;
        }
        _context.FlexiNumbers.Update(flexiNumber);
        await _context.SaveChangesAsync();
        return flexiNumber;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var flexiNumber = await _context.FlexiNumbers.FindAsync(id);
        if (flexiNumber is null) return false;

        _context.FlexiNumbers.Remove(flexiNumber);
        await _context.SaveChangesAsync();
        return true;
    }
}
