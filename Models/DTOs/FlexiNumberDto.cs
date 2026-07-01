using FlexiLedger.Api.Models.Enums;

namespace FlexiLedger.Api.Models.DTOs
{
    public class FlexiNumberDto
    {
        public int Id { get; set; }
        public Carrier Carrier { get; set; }
        public decimal Balance { get; set; }
    }
}