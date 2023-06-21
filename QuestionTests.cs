namespace interview_questions;

[TestFixture]
public class QuestionTests
{
    [TestCase(10, ExpectedResult = "1, Fizz, 2, Buzz, 3, Fizz, 4, 5, FizzBuzz, Fizz, Buzz, 6, 7, Fizz, 8, Buzz, 9, Fizz, 10")]
    public string ShouldPerformFizzBuzz(int n) => string.Join(", ", Questions.FizzBuzz(n));

    [TestCase(new[] { 2, 7, 11, 13 }, 9, new[] { 0, 1 })]
    [TestCase(new[] { 1, 7, 11, 2 }, 3, new[] { 0, 3 })]
    public void ShouldFindSumIndexes(int[] numbers, int target, int[] er) => Assert.False(er.Except(Questions.TwoSums(numbers, target)).Any());

    [TestCase(new[] { 1, 2, 2, 4 }, new[] { 2, 3 })]
    [TestCase(new[] { 3, 2, 2 }, new[] { 2, 1 })]
    [TestCase(new[] { 1, 3, 3 }, new[] { 3, 2 })]
    public void ShouldFindErrorsInList(int[] numbers, int[] er) => Assert.False(er.Except(Questions.FindErrors(numbers)).Any());
}