using Domain.Services;
using Domain.Model;
using WebAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTodo", policy =>
    {
        policy.AllowAnyOrigin()    
              .AllowAnyMethod()    
              .AllowAnyHeader();  
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //Falta configurar de manera correcta        
    app.UseHttpLogging();
}

// Apply the CORS policy
app.UseCors("PermitirTodo");


app.UseHttpsRedirection();
   
MateriaRouter.Map(app);

PlanRouter.Map(app);

ComisionRouter.Map(app);

PersonaRouter.Map(app);

EspecialidadRouter.Map(app);

UsuarioRouter.Map(app);

CursoRouter.Map(app);

AlumnoInscripccionRouter.Map(app);

DocenteCursoRouter.Map(app);

app.Run();
