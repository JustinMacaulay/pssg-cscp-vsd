﻿//using Database;
using Manager;
using Microsoft.Extensions.DependencyInjection;
using Resources;
using Shared.Database;
using Utilities;
using Xunit.Abstractions;

namespace Gov.Cscp.VictimServices.Public;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddHandlers(this IServiceCollection services)
    {
        services.AddTransient<ICasPaymentRepository, CasPaymentRepository>();

        //services.AddTransient<ContractHandlers>();
        //services.AddTransient<IContractRepository, ContractRepository>();

        services.AddTransient<IConfigurationRepository, ConfigurationRepository>();
        services.AddTransient<IConfigurationService, ConfigurationService>();

        services.AddTransient<CurrencyHandlers>();
        services.AddTransient<ICurrencyRepository, CurrencyRepository>();

        //services.AddTransient<InvoiceHandlers>();
        services.AddTransient<IInvoiceRepository, InvoiceRepository>();

        //services.AddTransient<InvoiceLineDetailHandlers>();
        //services.AddTransient<IInvoiceLineDetailRepository, InvoiceLineDetailRepository>();

        //services.AddTransient<PaymentHandlers>();
        services.AddTransient<IPaymentRepository, PaymentRepository>();

        services.AddTransient<IEntitlementRepository, EntitlementRepository>();

        services.AddTransient<IPaymentScheduleRepository, PaymentScheduleRepository>();
        services.AddTransient<IPaymentScheduleService, PaymentScheduleService>();

        services.AddTransient<ITeamRepository, TeamRepository>();

        services.AddTransient<IProvinceRepository, ProvinceRepository>();

        services.AddTransient<IIncomeSupportParameterRepository, IncomeSupportParameterRepository>();

        services.AddTransient<IMessageRequests, MessageRequests>();

        return services;
    }

    public static IServiceCollection AddAutoMapperMappings(this IServiceCollection services)
    {
        // NOTE global and shared mapper should be first, since it has the prefix configurations and shared mappings
        var mapperTypes = new[] {
            typeof(GlobalMapper), typeof(SharedMapper), typeof(TeamMapper), typeof(PaymentScheduleMapper), typeof(EntitlementMapper), typeof(IncomeSupportParameterMapper), 
            typeof(CurrencyMapper), typeof(PaymentMapper), typeof(AccountMapper), //typeof(ProgramMapper), typeof(ContractRepositoryMapper),
            typeof(InvoiceMapper), typeof(InvoiceLineDetailMapper), //typeof(ScheduleGRepositoryMapper)
        };
        services.AddAutoMapper(cfg => cfg.ShouldUseConstructor = constructor => constructor.IsPublic, mapperTypes);
        return services;
    }
}
