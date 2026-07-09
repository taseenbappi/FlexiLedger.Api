using FlexiLedger.Api.Models.Enums;

namespace FlexiLedger.Api.Models.DTOs;

public record FlexiRechargeRequestDto()
{
    public Carrier Carrier { get; set; }
    public string RechargeNumber { get; set; } = string.Empty;
    public decimal RechargeAmount { get; set; }
    public int FlexiNumberId { get; set; }
}