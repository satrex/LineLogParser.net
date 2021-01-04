using System;
using  System.Linq;
using System.Collections.Generic;
using System.IO;

public class LineLogParser
{
    public static DateTime? ParseDate(string dateString)
    {
        DateTime.TryParseExact(dateString, "yyyy.MM.dd",null, System.Globalization.DateTimeStyles.None, out DateTime date);
        return date;
    }
    public static DateTime? ParseTime(string timeString)
    {
        DateTime.TryParse(timeString, out DateTime time);
        return time;
    }

    public static string ParseLineLog(string[] lineLogs)
    {
        List<string> lines = new List<string>();
        DateTime day = new DateTime();
        DateTime time = new DateTime();
        string username = string.Empty;

        foreach (var line in lineLogs){
            var words = line.Split(" ");
            if(words.Count() == 0 ) { continue; }

            var linedate = ParseDate(words[0]);
            var linetime = ParseTime(words[0]);

            if(linedate)
            {
                day = linedate;
            }
            else if (linetime)
            {
                time = linetime;
                username = words[1];


            }
            else 
            {

            }




        }


    }
}