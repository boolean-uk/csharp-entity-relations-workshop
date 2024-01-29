using blogapi.Data;
using blogapi.Endpoints;
using blogapi.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("Blog"));
builder.Services.AddScoped<IPostsRepository, PostsRepository>();
builder.Services.AddScoped<IAuthorsRepository, AuthorsRepository>();

var app = builder.Build();

// ensure db context is created with seeded data
using (var dbContext = new DataContext(new DbContextOptions<DataContext>()))
{
    dbContext.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigurePostsApi();
app.ConfigureAuthorsApi();

app.Run();