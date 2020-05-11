﻿using Microsoft.Extensions.Hosting;
using Serilog;

namespace NetModular.Lib.Logging.Serilog.GenericHost
{
    public static class WebHostBuilderExtensions
    {
        public static IHostBuilder UseLogging(this IHostBuilder builder)
        {
            builder.UseSerilog((hostingContext, loggerConfiguration) =>
            {
                loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration).Enrich.FromLogContext();
            });

            return builder;
        }
    }
}
