namespace FronttoBacktask;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();


        var app = builder.Build();

        app.UseStaticFiles();

        app.MapControllerRoute(

            name: "Default",
            pattern: "{Controller=Home}/{Action=Index}/{id?}"


            );

        app.Run();
    }
}
