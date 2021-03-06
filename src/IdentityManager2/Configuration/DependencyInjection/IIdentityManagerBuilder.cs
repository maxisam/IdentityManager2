﻿using System;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityManager2.Configuration
{
    public interface IIdentityManagerBuilder
    {
        IServiceCollection Services { get; }
    }

    public class IdentityManagerBuilder : IIdentityManagerBuilder
    {
        public IdentityManagerBuilder(IServiceCollection services)
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
        }

        public IServiceCollection Services { get; }
    }
}