namespace Design.IS7.Infrastructure.Mappers
{
    public static class MappingHelper
    {
        public static Type GetDefaultValue<Type>()
        {
#pragma warning disable CS8603 // Possible null reference return.
            return default;
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}