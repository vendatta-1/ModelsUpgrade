using ModelsUpgrade.Apstractions;
using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var entitiesType = assembly.GetTypes()
    .Where(entity => entity.IsClass && !entity.IsAbstract && entity.IsSubclassOf(typeof(Entity))).ToList();
foreach (var entityType in entitiesType)
{
    Console.WriteLine(entityType.Name);

}
var props = entitiesType.Where(x => x.Name == "PosSalesDetail").FirstOrDefault().GetProperties();
Console.WriteLine("\n\n\n\n\n\n\n\n\n");
foreach (var item in props)
{
    if (item.PropertyType.IsByRef || item.PropertyType.IsClass || item.PropertyType.IsTypeDefinition)
    {
        foreach (var entity in item.PropertyType.GetProperties())
        {
            Console.WriteLine($"\t\t{entity.Name}");
        }
    }
}
Console.WriteLine($"\n\n\n{entitiesType.Count()}");

//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    base.OnModelCreating(modelBuilder);

//    // Iterate over all the entity types in the model
//    foreach (var entityType in modelBuilder.Model.GetEntityTypes())
//    {
//        // Iterate over all properties for each entity
//        foreach (var property in entityType.GetProperties())
//        {
//            // Check if the property type is a numeric type (int, long, short, byte, decimal, double, float, and their nullable counterparts)
//            if (IsNumericType(property.ClrType))
//            {
//                // Set the default value for numeric properties (including nullable types)
//                property.SetDefaultValue(0);
//            }
//        }
//    }
//}

//// Helper method to check if a type is numeric (including nullable types)
//private bool IsNumericType(Type type)
//{
//    return type == typeof(int) || type == typeof(long) || type == typeof(short) || type == typeof(byte) ||
//           type == typeof(decimal) || type == typeof(double) || type == typeof(float) ||
//           type == typeof(int?) || type == typeof(long?) || type == typeof(short?) || type == typeof(byte?) ||
//           type == typeof(decimal?) || type == typeof(double?) || type == typeof(float?);
//}
