using ASP06.MinimalApi.Models.Services;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);

//DI container service registration
builder.Services.AddScoped<IBookService, BookService>();

var app = builder.Build();

// request pipline

app.Use(async (context, next) =>
{
    var stopWatch = new Stopwatch();
    stopWatch.Start();
    context.Response.OnStarting(() =>
    {
       context.Response.Headers.Append("X-requestlapsedtimeinms",stopWatch.ElapsedMilliseconds.ToString());
        return Task.CompletedTask;
    });
  await next(context);
});
app.MapGet("/",() => "Hello world!");
app.MapGet("/books", async (IBookService service) => Results.Ok(await service.GetAll()));
app.Run();
