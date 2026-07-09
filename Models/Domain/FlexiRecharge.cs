using System.ComponentModel.DataAnnotations.Schema;
using FlexiLedger.Api.Models.Enums;

namespace FlexiLedger.Api.Models.Domain
{
    public class FlexiRecharge
    {
        public int Id { get; set; }
        public Carrier Carrier { get; set; }
        public string RechargeNumber { get; set; } = string.Empty;
        public decimal RechargeAmount { get; set; }
        // Foreign Key
        public int FlexiNumberId { get; set; }
        // Navigation Property
        public FlexiNumber? FlexiNumber { get; set; } = null!;
    }
}