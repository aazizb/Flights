using NLog;

using WebApi.Extensions;

var builder = WebApplication.CreateSlimBuilder(args);
{
    LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

    builder.Services.AddWebApi(builder.Configuration);

    builder.Services.AddControllers()
        .AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly);

}

var app = builder.Build();
{
    app.UseCors("CorsPolicy");
    app.Run();

}

