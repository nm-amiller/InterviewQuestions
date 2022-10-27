namespace interview_questions;

public static class Questions
{
    // Create a function that iterates through a list of numbers from 1 to n
    // If the number is divisible by 2, return "Fizz"
    // If the number is divisible by 3, return "Buzz"
    // If the number is divisible by both, return "FizzBuzz"
    // If the number is divisible by neither, return the number as a string
    public static IEnumerable<string> FizzBuzz(int n)
    {
        return Enumerable.Empty<string>();
    }

    // Given a list of integers and a target number
    // Return the indices of the two numbers that sum to the target number as an array
    // You can assume there is only exactly one solution that sums to the target
    // You should not use the same element twice
    // Example: ([1, 2, 3], 5)
    // Output: [1,2]
    public static int[] TwoSums(int[] numbers, int target)
    {
        return Array.Empty<int>();
    }

    // Given a string of Roman Numerals, convert it to an integer
    // The string could contain these symbols:
    // I -> 1
    // V -> 5
    // X -> 10
    // L -> 50
    // C -> 100
    // D -> 500
    // M -> 1000
    // Example: "XIV"
    // Output: 14 
    public static int RomanNumeralToInt(string input)
    {
        return 0;
    }

    // You are given a set of integers from 1 to n that contains a duplicated number...
    // Return an array containing: the number that was duplicated and the missing number
    // Example: [1,2,2,4]
    // Output: [2,3]
    public static int[] FindErrors(int[] numbers)
    {
        return Array.Empty<int>();
    }
}
