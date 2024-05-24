using Autofac;

namespace win_crud.Configuration;

public static class ApplicationConfiguration
{
    private static IContainer _container;

    public static void Initialize(IContainer container)
        =>  _container = container;
    
    public static TService GetService<TService>()
        =>  _container.Resolve<TService>();
}