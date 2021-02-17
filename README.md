# Raindrops

## Objective

Write a function that takes as its input a number `n` and converts it to a string, the contents of which depend on the number's factors of `n`:
- If `n` has a factor of 3, return `Pling`
- If `n` has a factor of 5, return `Plang`
- If `n` has a factor of 7, return `Plong`
- If `n` does not have any of the above as a factor, return `n`'s digits

## Examples

1. 28 has the factors 1, 2, 4, **7**, **14**, and **28**
    - 7, 14, and 28 are factors of 7
    - 28 returns `Plong`
2. 30 has the factors 1, 2, **3**, **5**, **6**, **10**, **15**, and **30**
    - 3, 6, 15, and 30 are factors of 3
    - 5, 10, 15, and 30 are factors of 5
    - 30 returns `Pling` and `Plang`
    - These results merge together to return `PlingPlang`
3. 34 has the factors 1, 2, 17, and 34
    - These values are not a factor of either 3, 5, or 7
    - 34 returns itself as `34`

## Testing

```C#
[TestFixture]
public class RaindropTests
{
    private readonly Raindrops _sut = new Raindrops();

    [TestCase(-34)]
    [TestCase(-8)]
    [TestCase(-1)]
    [TestCase(1)]
    [TestCase(8)]
    [TestCase(34)]
    public void PlingPlangPlong_NumberDoesNotHaveAFactorOf3Or5Or7_ReturnsNumber(int number)
    {
        var result = _sut.PlingPlangPlong(number);

        Assert.That(result, Is.EqualTo(number.ToString()));
    }
```

The typical structure of the unit tests used in this application is seen in the C# code block above. All tests are contained within the `RaindropTests` class where each test is accompanied by several `[TestCase]` attributes. These attributes parameterise the tests so that multiple values can be tested against within a single test method.

The naming of the test methods take the form of a [convention encouraged by Microsoft](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices#naming-your-tests) where it is split into 3 distinct sections:
1. The name of the method being tested
2. The scenario under which the method is being tested
3. The expected behaviour of the method when the scenario is invoked

This convention has the advantage of easily mapping itself onto the more user-friendly Gherkin syntax that is found within Behaviour-Driven Development (BDD) tests. Using the name of the test method within the code block above, the corresponding Gherkin would roughly correspond to:
1. `GIVEN` the `PlingPlangPlong` method
2. `WHEN` the `<input>` does not have a factor of 3
3. `AND` the `<input>` does not have a factor of 5
4. `AND` the `<input>` does not have a factor of 7
3. `THEN` the method should return `<input>`

Within the `RaindropTests` class, the Arrange-Act-Assert (AAA) pattern has been employed to standardise the readability and structure of the tests. The system under test (SUT) consists of a `Raindrops` class which simply holds a single `PlingPlangPlong` method and nothing more. As the SUT does not have a mutable state, the initial Arrange section has been delegated to the class level field `_sut` to allow for it to seamlessly be shared across all test methods without the need for repeated declarations.
