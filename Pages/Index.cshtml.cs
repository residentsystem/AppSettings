using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using AppSettings.Configurations;

namespace AppSettings.Pages
{
    public class IndexModel : PageModel
    {
        public string PageTitle = "Configuration from a INI file";

        public string Owner { get; set; }

        public string Developper { get; set; }

        public string Product { get; set; }

        public string Storage { get; set; }

        public string Display { get; set; }

        private IConfiguration _configuration;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            // Bind the content of default configuration file "appsettings.json" to an instance of DatabaseSettings 
            ConsoleSettings console = _configuration.GetSection("xbox").Get<ConsoleSettings>();

            Owner = console.Owner;
            Developper = console.Developper;
            Product = console.Product;
            Storage = console.Storage;
            Display = console.Display;   
        }
    }
}