using SessionOne.Middlewares;
using CoreLogic;
using externalServices;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddTransient<GuitarManager>();
builder.Services.AddTransient<UserService>();
builder.Services.AddSingleton<GuitarManager>();

// builder.Services.AddTransient<Guitar>();
// Crea una instancia por layer o project

// builder.Services.AddScoped<Guitar>();
// Crea una y reusa instancias por layer o project

// builder.services.AddSingleton<Guitar>();
// Crea una instancia global y unica mientras el servidor/app este vivo

var app = builder.Build();



// Configure the HTTP request pipeline.
app.UseGlobalExceptionHandler();
// app.UseExceptionHandler();
// app.UseHsts();
// app.UseHttpsRedirection();
// app.UseStaticFiles();
// app.UseRouting();
// app.UseCors("OnlyTruextendWebApps");
// app.UseAuthentication(); // user/pass
// app.UseAuthorization(); // roles
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();




// Application runs
app.Run();
