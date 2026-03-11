namespace Bookworm.EFCore;

class AppConfig
{
    public static string GetConnectionString()
    {
        return "Data Source=Macoratti\\sqlexpress;Initial Catalog=JcmSoftDatabase;Integrated Security=True;TrustServerCertificate=True;";
    }
}
