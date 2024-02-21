namespace SuggestionsAppUI
{
    public static class RegisterServices
    {
        //creating Extension method attached to WebApplicationBuilder that will configure services
        public static void ConfigureServices(this WebApplicationBuilder builder) 
        {
            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            //add caching to our project
            builder.Services.AddMemoryCache();
        }
    }
}
