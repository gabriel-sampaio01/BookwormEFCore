namespace Bookworm.EFCore;

class AppConfig
{
    public static string GetConnectionString()
    {
        return "Server=(localdb)\\MSSQLLocalDB;Database=BookwormDb;Trusted_Connection=True;";
    }
}
