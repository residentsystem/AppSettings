using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using AppSettings.Configurations;

namespace AppSettings.Pages
{
    public class Index2Model : PageModel
    {
        public string PageTitle = "Configuration from a JSON file";

        public string SqlServerName { get; set; }

        public string InstanceName { get; set; }

        public string DatabaseName { get; set; }

        public string UserId { get; set; }

        public string Password { get; set; }

        public string ConnectionString { get; set; }

        public string ServerName { get; set; }

        public string IPAddress { get; set; }

        public string OperatingSystem { get; set; }

        public string Domain { get; set; }

        private IConfiguration _configuration;

        public Index2Model(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            // Bind the content of default configuration file "appsettings.json" to an instance of DatabaseSettings 
            DatabaseSettings database = _configuration.GetSection("Database").Get<DatabaseSettings>();

            SqlServerName = database.SqlServerName;
            InstanceName = database.InstanceName;
            DatabaseName = database.DatabaseName;
            UserId = database.UserId;
            Password = database.Password;

            ConnectionString = $"Server={SqlServerName}\\{InstanceName};Database={DatabaseName};User Id={UserId};Password={Password};";

            // Bind the content of custom configuration file "serversettings.json" to an instance of ServerSettings
            ServerSettings server = _configuration.GetSection("Server").Get<ServerSettings>();

            ServerName = server.ServerName;
            IPAddress = server.IPAddress;
            OperatingSystem = server.OperatingSystem;
            Domain = server.Domain;
        }
    }
}
