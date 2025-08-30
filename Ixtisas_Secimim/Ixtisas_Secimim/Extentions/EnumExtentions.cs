using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Ixtisas_Secimim.Extentions
{
    public static class EnumExtentions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var displayAttribute = enumValue.GetType()
                                            .GetField(enumValue.ToString())
                                            .GetCustomAttributes(typeof(DisplayAttribute), false)
                                            .FirstOrDefault() as DisplayAttribute;

            return displayAttribute?.Name ?? enumValue.ToString();
        }
    }
}
