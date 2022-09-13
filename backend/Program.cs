using System.Text.Json.Serialization;
using backend.Helpers;
using backend.Interfaces;
using backend.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

{
    var services = builder.Services;

    services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
    services.AddCors();

    services.AddDbContext<DataContext>(options =>
    {
        string mysqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");
        options.UseMySql(mysqlConnection, ServerVersion.AutoDetect(mysqlConnection));

    });

    services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

    services.AddScoped<IUserService, UserService>();

    
    
}

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DataContext>();
    context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

{
    app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

    app.UseMiddleware<ErrorHandlerMiddleware>();

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run("http://localhost:4000");


