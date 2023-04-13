namespace wwwroot;

public class Program
{
    public static void Main(string[] args)
    { 
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Projeto Web - LH Pets versão 1");
        
        app.UseStaticFiles();
        RouteHandlerBuilder routeHandlerBuilder = app.MapGet ("/index",(HttpContext contexto)=> {
            contexto.Response.Redirect("index.html", false);

        });

        app.Run();
    }
}
