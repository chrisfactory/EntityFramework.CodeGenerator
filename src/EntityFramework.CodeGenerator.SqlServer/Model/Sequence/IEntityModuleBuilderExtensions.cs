﻿using EntityFramework.CodeGenerator.Core;
using EntityFramework.CodeGenerator.SqlServer;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class IEntityModuleBuilderExtensions
    {
        public static IModelModuleBuilder Sequences(this IModelModuleBuilder module)
        {
            module.Services.TryAddTransient<ISequencesModuleIntentBuilder, SequencesModuleIntentBuilder>();

            module.Services.AddSingleton(p =>
            {
                var builder = p.GetRequiredService<ISequencesModuleIntentBuilder>();
                return builder.Build();
            });
            return module;
        }
    }
}
