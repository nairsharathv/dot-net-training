using System.Globalization;

namespace Assignment6;

public static class  MonthName
{
     public static string GetFullName(int month)
    {
        return CultureInfo.CurrentCulture.
            DateTimeFormat.GetMonthName
            (month);
    }
}
