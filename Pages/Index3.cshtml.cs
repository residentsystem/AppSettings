using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using AppSettings.Configurations;

namespace AppSettings.Pages
{
    public class Index3Model : PageModel
    {
        public string PageTitle = "Configuration from an XML file";

        public string Hostname { get; set; }

        public string SiteUrl { get; set; }

        public string Protocol { get; set; }

        public string Ssl { get; set; }

        public string Port { get; set; }

        private IConfiguration _configuration;

        public Index3Model(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            // Bind the content of default configuration file "appsettings.json" to an instance of DatabaseSettings 
            WebsiteSettings website = _configuration.GetSection("website").Get<WebsiteSettings>();

            Hostname = website.Hostname;
            SiteUrl = website.SiteUrl;
            Protocol = website.Protocol;
            Ssl = website.Ssl;
            Port = website.Port;   
        }
    }
}