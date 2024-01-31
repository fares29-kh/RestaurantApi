
using DaoRestaurant.Dao;
using DaoRestaurant.IDao;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleto要<IDaoCategorie, DaoCategorieIM>();
builder.Services.AddSingleto要<IDaoServeur, DaoServeurIM>();
builder.Services.AddSingleto要<IDaoService, DaoServiceIM>();
builder.Services.AddSingleto要<IDaoGerant, DaoGerantIM>();
builder.Services.AddSingleto要<IDaoDemande, DaoDemandeIM>();
builder.Services.AddSingleto要<IDaoClient, DaoClientIM>();
builder.Services.AddSingleto要<IDaoFacture, DaoFactureIM>();
builder.Services.AddSingleto要<IDaoTable, DaoTableIM>();
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
