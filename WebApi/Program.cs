using WebApi.Extensions;

var builder = WebApplication.CreateSlimBuilder(args);
{
    builder.Services.AddWebApi();

}


var app = builder.Build();
{

    app.UseCors("CorsPolicy");
    app.Run();

}

