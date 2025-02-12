/* Max Sum of a Pair With Equal Sum of Digits */


using System;

public class Solution
{
    private static readonly int[] RANGE_OF_VALUES = { 1, (int)Math.Pow(10, 9) };
    private static readonly int NO_TWO_ELEMENTS_WITH_SAME_SUM_OF_DIGITS_FOUND = -1;
    private static readonly int HAS_NO_ELEMENT = 0;

    public int MaximumSum(int[] input)
    {
        int sizeSumOfDigitsToValues = 1 + CalculateSumOfDigits(RANGE_OF_VALUES[1] - 1);
        int[] sumOfDigitsToValues = new int[sizeSumOfDigitsToValues];

        int maxSumOfPairWithEqualSumOfDigits = NO_TWO_ELEMENTS_WITH_SAME_SUM_OF_DIGITS_FOUND;
        foreach (int value in input) {
            int sumOfDigits = CalculateSumOfDigits(value);
            if (sumOfDigitsToValues[sumOfDigits] == HAS_NO_ELEMENT) {
                sumOfDigitsToValues[sumOfDigits] = value;
                continue;
            }
            maxSumOfPairWithEqualSumOfDigits = Math.Max(maxSumOfPairWithEqualSumOfDigits, sumOfDigitsToValues[sumOfDigits] + value);
            sumOfDigitsToValues[sumOfDigits] = Math.Max(sumOfDigitsToValues[sumOfDigits], value);
        }
        return maxSumOfPairWithEqualSumOfDigits;
    }    

    private int CalculateSumOfDigits(int value)
    {
        int sumOfDigits = 0;
        while (value > 0)
        {
            sumOfDigits += value % 10;
            value /= 10;
        }
        return sumOfDigits;
    }
}
