using Autofac;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using win_crud.Model;
using win_crud.Model.Context;
using win_crud.Repository;
using win_crud.Repository.Interfaces;
using win_crud.Services;
using win_crud.Services.Interfaces;
using win_crud.Validations;

namespace win_crud.Extensions;

public static class AutofacExtensions
{
    public static ContainerBuilder RegisterRepositorysAndContext(this ContainerBuilder builder)
    {
        builder.RegisterType<SQLServerContext>().InstancePerLifetimeScope();
        builder.RegisterType<AddressRepository>().As<IAddressRepository>().InstancePerLifetimeScope();
        builder.RegisterType<PersonRepository>().As<IPersonRepository>().InstancePerLifetimeScope();

        return builder;
    }

    public static ContainerBuilder RegisterValidators(this ContainerBuilder builder)
    {
        builder.RegisterType<PersonValidator>().As<IValidator<Person>>();
        builder.RegisterType<AddressValidator>().As< IValidator<Address>>();

        return builder;
    }

    public static ContainerBuilder RegisterServices(this ContainerBuilder builder)
    {
        builder.RegisterType<PersonService>().As<IPersonService>();
        builder.RegisterType<AddressService>().As<IAddressService>();

        return builder;
    }

    public static ContainerBuilder RegisterSqlServerOptions(this ContainerBuilder builder, string connectionString)
    {
        builder.Register(c =>
        {
            var options = new DbContextOptionsBuilder<SQLServerContext>().UseSqlServer();
            options.UseSqlServer(connectionString);
            return options.Options;
        }).SingleInstance();

        return builder;
    }
}
