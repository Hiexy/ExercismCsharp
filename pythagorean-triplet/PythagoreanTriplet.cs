using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        int midPoint, l, r, c;
        for(int i = 1; i < sum / 3; ++i) {
            l = i + 1;
            r = sum / 2;
            while (l <= r) {
                midPoint = (int) (l + r) / 2; 
                c = sum - (i + midPoint);
                if(i*i + midPoint * midPoint == c*c){
                    yield return (i, midPoint, c);
                    break;
                }

                else if(i*i + midPoint * midPoint > c*c)
                    r = midPoint - 1;

                else if(i*i + midPoint * midPoint < c*c)
                    l = midPoint + 1;
            }
        }
    }
}
