using FlexiLedger.Api.Models.Domain;
using FlexiLedger.Api.Models.DTOs;
using FlexiLedger.Api.Repositories;

namespace FlexiLedger.Api.Services;

public class FlexiRechargeService(IFlexiRechargeRepository flexiRechargeRepository) : IFlexiRechargeService
{
    private readonly IFlexiRechargeRepository _flexiRechargeRepository = flexiRechargeRepository;

    public async Task<FlexiRechargeRequestDto> AddAsync(FlexiRechargeRequestDto flexiRecharge)
    {
        return await _flexiRechargeRepository.AddAsync(flexiRecharge);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _flexiRechargeRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<FlexiRecharge>> GetAllAsync()
    {
        return await _flexiRechargeRepository.GetAllAsync();
    }

    public async Task<FlexiRecharge?> GetByIdAsync(int id)
    {
        return await _flexiRechargeRepository.GetByIdAsync(id);
    }

    public async Task<FlexiRecharge?> UpdateAsync(FlexiRecharge flexiRecharge)
    {
        return await _flexiRechargeRepository.UpdateAsync(flexiRecharge);
    }
}