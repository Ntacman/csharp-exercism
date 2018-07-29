using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        var divis_100 = (year % 100 == 0) ? true : false;
        var divis_400 = (year % 400 == 0) ? true : false;
        if (year % 4 == 0 && !divis_100) {
          return true;
        }
        else if(year % 4 == 0 && divis_100 && divis_400) {
          return true;
        }
        else {
          return false;
        }
    }
}
