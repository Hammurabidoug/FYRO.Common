using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FYRO.Application.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace FYRO.Application;

internal class FYROApplicationBuilder : IFYROApplicationBuilder
{
    public FYROApplicationBuilder (IServiceCollection services)
    {
        this.Services = services;
    }

    public IServiceCollection Services { get; private set; }
}
