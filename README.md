# Raindrops

## Objective

Write a function that takes as its input a number `n` and converts it to a string, the contents of which depend on the numbers factors of `n`:
- If `n` has a factor of 3, output `Pling`
- If `n` has a factor of 5, output `Plang`
- If `n` has a factor of 7, output `Plong`
- If `n` does not have any of the above as a factor simply return the numbers digits

## Examples

1. 28 has the factors 1, 2, 4, **7**, **14** and **28**
    - 7, 14, and 28 are all factors of 7
    - 28 outputs `Plong`
2. 30 has the factors 1, 2, **3**, **5**, **6**, **10**, **15** and **30**
    - 3, 6, 15, and 30 are factors of 3
    - 5, 10, 15, 30 are factors of 5
    - 30 outputs `Pling` and `Plang`
    - These results merge together to return `PlingPlang`
3. 34 has the factors 1, 2, 17, and 34
    - These factors are not of either 3, 5, or 7
    - 34 outputs itself as `34`

## Testing

<image src="images/example-test.png" width="100%" height="100%">

The typical structure of the unit tests used in this application is seen above.
Each test is accompanied by several `[TestCase]` attributes which parameterises the tests to allow for multiple values to be tested against within a single test.

The naming of the test methods take the form of a convention encouraged by [Microsoft](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices) where it is split into 3 distinct parts:
1. The name of the method being tested
2. The scenario under which it's being tested
3. The expected behaviour when the scenario is invoked

This convention has the advantage of mapping easily onto the more user-friendly Gherkin syntax that is found with Behaviour-Driven Development (BDD) tests. Using the same example test above, the corresponding Gherkin syntax would roughly equate to:
1. `GIVEN` the `PlingPlangPlong` method
2. `WHEN` the `<input>` has a factor of 3
3. `THEN` the method should return Pling

Within the test, the Arrange-Act-Assert (AAA) pattern has been employed to standardise the readability and structure of the tests. The system under test (SUT) consists of a class which holds the single 'PlingPlangPlong' method that is being tested in all of the test methods. As the SUT does not have a state, the initial Arrange section has been delegated to the class level field `_sut` that is shared between all test methods. The Act and Assert sections follow standard convention where data is processed in the Act section, and this data asserted against in the following Assert section.
