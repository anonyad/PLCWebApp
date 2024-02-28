using Microsoft.EntityFrameworkCore;

namespace PLCWebApi;

public class DataBaseTags : DbContext
{
    public DataBaseTags(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AnalogueOut> AnalogueOut { get; set; }
    public DbSet<AnalogueIn> AnalogueIn { get; set; }
    public DbSet<DigitalOut> DigitalOut { get; set; }
    public DbSet<DigitalIn> DigitalIn { get; set; }
}