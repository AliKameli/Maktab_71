using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

public static class EnumExtensions
{
    public static string GetDisplayName(Enum enumValue)
    {
        return enumValue.GetType().GetMember(enumValue.ToString())[0].GetCustomAttribute<DisplayAttribute>().GetName();
    }
    public static void PrintEnum(Enum @enum)
    {
        foreach (var enumValue in Enum.GetNames(@enum.GetType()))
        {
            Console.WriteLine(enumValue.ToString());
        }
    }

}
