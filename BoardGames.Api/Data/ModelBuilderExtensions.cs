using System;
using Humanizer;
using Microsoft.EntityFrameworkCore;

namespace BoardGames.Api.Data
{
    public static class ModelBuilderExtensions
    {
        public static void AddDefaultNotNullableConvention(this ModelBuilder builder)
        {
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                // Skip Identity tables
                if (entityType.Relational().TableName.StartsWith("AspNet")) continue;

                foreach (var property in entityType.GetProperties())
                {
                    property.IsNullable = Nullable.GetUnderlyingType(property.ClrType) != null;
                }
            }
        }

        public static void AddPostgreSqlConventions(this ModelBuilder builder)
        {
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                // Make singular snake-cased table names, without AspNet prefix
                entityType.Relational().TableName =
                    entityType.Relational().TableName
                        .Replace("AspNet", string.Empty)
                        .Singularize(false)
                        .Underscore();

                foreach (var property in entityType.GetProperties())
                {
                    // Make snake-cased column names
                    property.Relational().ColumnName = property.Relational().ColumnName.Underscore();

                    // Make strings of type "text" by default
                    // https://stackoverflow.com/questions/4848964/postgresql-difference-between-text-and-varchar-character-varying
                    if (property.ClrType == typeof(string))
                    {
                        property.Relational().ColumnType = "text";
                    } //else if (property.ClrType == typeof(DateTime))
                    //{
                    //    property.Relational().ColumnType = "timestamp with time zone";
                    //}

                    // Make foreign keys lower-cased by default
                    foreach (var foreignKey in entityType.FindForeignKeys(property))
                    {
                        foreignKey.Relational().Name = foreignKey.Relational().Name.ToLowerInvariant();
                    }
                }

                // Make index names lower-cased by default
                foreach (var index in entityType.GetIndexes())
                {
                    index.Relational().Name = index.Relational().Name.ToLowerInvariant();
                }

                // Make primary and foreign keys lower-cased by default
                foreach (var key in entityType.GetKeys())
                {
                    key.Relational().Name = key.Relational().Name.ToLowerInvariant();
                }
            }
        }
    }
}
