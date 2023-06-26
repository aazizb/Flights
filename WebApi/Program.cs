using NLog;

using WebApi.Extensions;

var builder = WebApplication.CreateSlimBuilder(args);
{
    LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
    builder.Services.AddWebApi();

}


var app = builder.Build();
{

    app.UseCors("CorsPolicy");
    app.Run();

}

