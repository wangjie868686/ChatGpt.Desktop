﻿using ChatGpt.Shared;
using ChatGpt.Shared.Interop;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// 注册ChatGpt核心界面
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IMasaBlazorBuilder AddChatGpt(this IServiceCollection services)
    {
        var masa = services.AddMasaBlazor();
        services.AddScoped<StorageJsInterop>();
        services.AddScoped<ChatGptJsInterop>();
        services.AddScoped<ApiClient>();

        return masa;
    }
}