
using DaoRestaurant.Dao;
using DaoRestaurant.IDao;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleto�n<IDaoCategorie, DaoCategorieIM>();
builder.Services.AddSingleto�n<IDaoServeur, DaoServeurIM>();
builder.Services.AddSingleto�n<IDaoService, DaoServiceIM>();
builder.Services.AddSingleto�n<IDaoGerant, DaoGerantIM>();
builder.Services.AddSingleto�n<IDaoDemande, DaoDemandeIM>();
builder.Services.AddSingleto�n<IDaoClient, DaoClientIM>();
builder.Services.AddSingleto�n<IDaoFacture, DaoFactureIM>();
builder.Services.AddSingleto�n<IDaoTable, DaoTableIM>();
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
