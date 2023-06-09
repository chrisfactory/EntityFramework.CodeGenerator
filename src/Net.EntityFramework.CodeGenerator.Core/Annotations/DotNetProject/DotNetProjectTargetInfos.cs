﻿using Microsoft.EntityFrameworkCore.Update.Internal;

namespace Microsoft.Extensions.DependencyInjection
{
    public interface IDotNetProjectTargetInfos
    {
        string? RootPath { get; }

        string MapExtensionsPatternPath { get; }
        string DbServicePatternPath { get; }
        string DbContextExtensionsPatternPath { get; }
    }
    public class DotNetProjectOptions : IDotNetProjectTargetInfos
    {
        public const string AnnotationKey = $"sqlg.{nameof(DotNetProjectOptions)}";

        public string? RootPath { get; set; }
        /// <summary>
        /// {FileName};{Schema};{SchemaExt};{TableName}
        /// </summary>
        public string MapExtensionsPatternPath { get; set; } = @"MapExtensions\{FileName}.cs";
        public string DbContextExtensionsPatternPath { get; set; } = @"DbContextExtensions\{FileName}.cs";
        public string DbServicePatternPath { get; set; } = @"DbService\{name}\{FileName}.cs";

    }
}
