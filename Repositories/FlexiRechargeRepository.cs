using FlexiLedger.Api.Infrastructure;
using FlexiLedger.Api.Models.Domain;
using FlexiLedger.Api.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace FlexiLedger.Api.Repositories;

public class FlexiRechargeRepository : IFlexiRechargeRepository

{
    private readonly FlexiLedgerDbContext _context;
    public FlexiRechargeRepository(FlexiLedgerDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<FlexiRecharge>> GetAllAsync()
    {
        var flexiRecharges = await _context.FlexiRecharges.ToListAsync();
        return flexiRecharges;

    }
    public async Task<FlexiRechargeRequestDto> AddAsync(FlexiRechargeRequestDto flexiRecharge)
    {
        var formattedFlexiRecharge = new FlexiRecharge
        {
            Carrier = flexiRecharge.Carrier,
            RechargeNumber = flexiRecharge.RechargeNumber,
            RechargeAmount = flexiRecharge.RechargeAmount,
            FlexiNumberId = flexiRecharge.FlexiNumberId
        };
        _context.FlexiRecharges.Add(formattedFlexiRecharge);
        await _context.SaveChangesAsync();
        return flexiRecharge;
    }


    public async Task<bool> DeleteAsync(int id)
    {
        var flexiRecharge = await _context.FlexiRecharges.FindAsync(id);
        if (flexiRecharge is null) return false;

        _context.FlexiRecharges.Remove(flexiRecharge);
        await _context.SaveChangesAsync();
        return true;
    }


    public async Task<FlexiRecharge?> GetByIdAsync(int id)
    {
        return await _context.FlexiRecharges.FindAsync(id);
    }

    public async Task<FlexiRecharge?> UpdateAsync(FlexiRecharge flexiRecharge)
    {
        var existingFlexiRecharge = await _context.FlexiRecharges.FindAsync(flexiRecharge.Id);
        if (existingFlexiRecharge is null)
        {
            return null;
        }
        _context.FlexiRecharges.Update(flexiRecharge);
        await _context.SaveChangesAsync();
        return flexiRecharge;
    }
}