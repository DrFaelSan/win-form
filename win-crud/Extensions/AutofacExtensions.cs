﻿using Autofac;
using win_crud.Model.Context;
using win_crud.Repository.Interfaces;
using win_crud.Repository;
using Microsoft.EntityFrameworkCore;

namespace win_crud.Extensions;

public static class AutofacExtensions
{
    public static ContainerBuilder RegisterServices(this ContainerBuilder builder)
    {
        builder.RegisterType<SQLServerContext>().InstancePerLifetimeScope();
        builder.RegisterType<AddressRepository>().As<IAddressRepository>().InstancePerLifetimeScope();
        builder.RegisterType<PersonRepository>().As<IPersonRepository>().InstancePerLifetimeScope();

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
