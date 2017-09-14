using System.Configuration;

namespace MFU.DataAccess
{
    public static class DataAccessAppSetting
    {
        public static readonly string DefaultDatabase = ConfigurationManager.AppSettings["DefaultDB"];
    }
}