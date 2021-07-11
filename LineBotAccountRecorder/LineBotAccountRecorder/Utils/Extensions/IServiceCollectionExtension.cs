﻿using System;
using LineBotAccountRecorder.Dal.UnitOfWork;
using LineBotAccountRecorder.Domain.Services.AccountRecords;
using LineBotAccountRecorder.Domain.Services.Settle;
using Microsoft.Extensions.DependencyInjection;

namespace LineBotAccountRecorder.Utils.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<AccountRecordService, AccountRecordService>();
            services.AddScoped<SettleService, SettleService>();

            return services;
        }
    }
}
