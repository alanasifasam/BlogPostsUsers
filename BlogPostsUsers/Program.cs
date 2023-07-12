using BlogPostsUsers.Application.Services;
using BlogPostsUsers.Domain.Interfaces;
using BlogPostsUsers.Infrastructure.DBContext;
using BlogPostsUsers.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Context
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ContextDb>(options =>
{
    options.UseSqlServer(connectionString);
});


//Services
builder.Services.AddScoped<IDadosService, DadosService>();
builder.Services.AddScoped<IDadosRepository, DadosRepository>(); 



builder.Services.AddHttpClient();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
