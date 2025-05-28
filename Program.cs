using Projeto_Web_LHPets.Classes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto LH Pets! ");



app.UseStaticFiles();

Banco banco = new Banco();

app.MapGet("/listaClientes", (HttpContext context) =>
{
    context.Response.WriteAsync(banco.GetListaString());
});

app.Run();
