using System.Configuration;
using CMSPlus.Domain.Interfaces;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Reflection;
using EvolveDb;

namespace CMSPlus.Domain.Services;

public class MigrationService:IMigrationService
{
    private readonly Evolve _evolve;
    public MigrationService(string connectionString)
    {
        var cnx = new SqlConnection(connectionString);
        var location = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Migrations");
        _evolve = new Evolve(cnx)
        {
            Locations = new[]{location},
            IsEraseDisabled = true,
        };
    }

    public void Migrate()   
    {
        try
        {
            System.Diagnostics.Debug.Write(">>Starting migration..........");
            _evolve.Migrate();
            System.Diagnostics.Debug.Write(">>Migration Completetd..........");

            var history = _evolve.AppliedMigrations;
            System.Diagnostics.Debug.WriteLine("Applied migrations:");
            foreach (var migration in history)
            {
                System.Diagnostics.Debug.WriteLine($"************{migration}");
            }

        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.Write($">>Failed to run migration..........{ex}");
            throw new Exception($"Failed to run migration", ex);
        }
    }
}