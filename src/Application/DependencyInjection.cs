using System.Reflection;
using FluentValidation;
using MediatR;
using FYRO.Application.Behaviours;
using FYRO.Application.Abstractions;
using FYRO.Application;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IFYROApplicationBuilder AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

        return new FYROApplicationBuilder(services);
    }
}
