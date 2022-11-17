using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TheTourMinsaitVersaoFinal.Data;
using TheTourMinsaitVersaoFinal.Repositorios;
using TheTourMinsaitVersaoFinal.Repositorios.Interfaces;

namespace TheTourMinsaitVersaoFinal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionStringMysql = builder.Configuration.GetConnectionString("conexaoMySQL");
            builder.Services.AddDbContext<Contexto>(Options => Options.UseMySql(connectionStringMysql,
                ServerVersion.Parse("8.0.31-mysql")));
            

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


           
            builder.Services.AddScoped<IPasseioRepositorio, PasseioRepositorio>();
            builder.Services.AddScoped<IBairroRepositorio, BairroRepositorio>();
            builder.Services.AddScoped<IPontoTuristicoRepositorio, PontoTuristicoRepositorio>();
            builder.Services.AddScoped<IPraiaRepositorio, PraiaRepositorio>();
            builder.Services.AddScoped<IRestauranteRepositorio, RestauranteRepositorio>();
            builder.Services.AddScoped<IRestauranteRepositorio, RestauranteRepositorio>();
            builder.Services.AddScoped<IVidaNoturnaRepositorio, VidaNoturnaRepositorio>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}