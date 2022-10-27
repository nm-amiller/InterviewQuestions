namespace interview_questions;

public static class Answers
{
    public static IEnumerable<string> FizzBuzz(int n)
    {
        for (var i = 1; i <= n; i++)
        {
            var divisibleByTwo = i % 2 == 0;
            var divisibleByThree = i % 3 == 0;

            if (divisibleByTwo && divisibleByThree)
                yield return "FizzBuzz";

            if (divisibleByTwo)
                yield return "Fizz";

            if (divisibleByThree)
                yield return "Buzz";

            yield return i.ToString();
        }
    }

    public static int[] TwoSums(int[] numbers, int target)
    {
        var seen = new Dictionary<int, int>();
        for (var i = 0; i < numbers.Length; i++)
        {
            var current = numbers[i];
            if (seen.TryGetValue(current, out var value))
                return new[] { i, value };
            else
                seen.Add(target - current, i);
        }
        throw new Exception("Never Get Here!");
    }

    public static int RomanNumeralToInt(string input)
    {
        var aggregator = 0;
        var previous = 0;

        foreach (var character in input.Reverse())
        {
            var current = character switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => throw new Exception("Unsupported Roman Numeral")
            };

            if (current >= previous)
                aggregator += current;
            else
                aggregator -= current;

            previous = current;
        }

        return aggregator;
    }

    public static int[] FindErrors(int[] numbers)
    {
        var expectedTotal = Enumerable.Range(1, numbers.Length).Sum();
        var seen = new HashSet<int>();
        var aggregator = 0;
        var duplicate = 0;

        foreach (var val in numbers)
        {
            if (seen.Contains(val))
            {
                duplicate = val;
            }
            else
            {
                seen.Add(val);
                aggregator += val;
            }
        }

        return new[] { (expectedTotal - aggregator), duplicate };
    }
}
