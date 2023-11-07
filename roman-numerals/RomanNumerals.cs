using System;

public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        string[] m = {"", "M", "MM", "MMM"};
        string[] c = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
        string[] x = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
        string[] i = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};

        string thousands = m[value / 1000];
        string hundreds = c[(value / 100) % 10];
        string tenths = x[(value / 10) % 10];
        string ones = i[value % 10];

        return $"{thousands}{hundreds}{tenths}{ones}";
    }
}
