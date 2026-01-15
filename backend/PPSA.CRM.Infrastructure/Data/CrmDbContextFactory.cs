using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PPSA.CRM.Infrastructure.Data; // <-- Check this matches your project

namespace PPSA.CRM.Infrastructure.Data; // <-- Check this matches your project

public class CrmDbContextFactory : IDesignTimeDbContextFactory<CrmDbContext>
{
    public CrmDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<CrmDbContext>();

        // Using a verbatim string (@) to safely handle special characters in your password
        var connectionString = @"Host=aws-1-eu-north-1.pooler.supabase.com;Port=6543;Database=postgres;Username=postgres.kfzwasdsqunqwynbyipp;Password=EsxLW7g7M%K/Qn@;Pgbouncer=true;Trust Server Certificate=True;SSL Mode=Require;";

        optionsBuilder.UseSqlServer(connectionString);

        return new CrmDbContext(optionsBuilder.Options);
    }
}