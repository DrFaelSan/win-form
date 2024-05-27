using Autofac;
using Microsoft.EntityFrameworkCore;
using win_crud.Configuration;
using win_crud.Extensions;
using win_crud.Model.Context;
using win_crud.Services.Interfaces;

namespace win_crud;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        var builder = new ContainerBuilder();

        builder.RegisterRepositorysAndContext();
        builder.RegisterValidators();
        builder.RegisterServices();

        builder.RegisterSqlServerOptions(Environment.GetEnvironmentVariable("DB_STRING") ?? "");

        var container = builder.Build();

        using (var scope = container.BeginLifetimeScope())
        {
            try
            {
                var dbContext = scope.Resolve<SQLServerContext>();
                dbContext.Database.Migrate();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Não foi possível se conectar ao banco de dados, verifique a variável de ambiente DB_STRING.", 
                                $"Erro ao conectar com banco de dados", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                MessageBox.Show($"Error: \n\n{ex.Message}",
                                $"Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        ApplicationConfiguration.Initialize(container);

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new FormMain(
           ApplicationConfiguration.GetService<IAddressService>(),
           ApplicationConfiguration.GetService<IPersonService>()
        ));
    }
}