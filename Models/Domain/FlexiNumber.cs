using FlexiLedger.Api.Models.Enums;

namespace FlexiLedger.Api.Models.Domain;

public class FlexiNumber
{
    public int Id { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public Carrier Carrier { get; set; }
    public decimal Balance { get; set; }

}