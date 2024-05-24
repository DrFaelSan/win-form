using Autofac;
using win_crud.Configuration;
using win_crud.Extensions;

namespace win_crud;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        var builder = new ContainerBuilder();

        builder.RegisterServices();

        builder.RegisterSqlServerOptions("conection_string");

        var container = builder.Build();

        ApplicationConfiguration.Initialize(container);

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }
}