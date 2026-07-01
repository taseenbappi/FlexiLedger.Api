using FlexiLedger.Api.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FlexiLedger.Api.Infrastructure;

public class FlexiLedgerDbContext(DbContextOptions<FlexiLedgerDbContext> options) : DbContext(options)
{
    public DbSet<FlexiNumber> FlexiNumbers { get; set; }
    public DbSet<FlexiRecharge> FlexiRecharges { get; set; }
}
