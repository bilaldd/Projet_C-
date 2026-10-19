using System.Globalization;

namespace Base_projet.Utils;

public class DateTimeUtils
{
    public static DateTime Birthdate { get; private set; }

    public static DateTime ConvertToDateTime(String date)
    {
        if (DateTime.TryParseExact(date,"dd/mm/YYYY",
                CultureInfo.InvariantCulture, 
                DateTimeStyles.None, out DateTime BirthDate))
        
        {  
            return DateTime.SpecifyKind(Birthdate, DateTimeKind.Utc);
        }

        else
        {
            Console.WriteLine($"La date {date} est mal renseignée");
            return DateTime.Now;
        }

    }
}