# Raindrops

Sample testing application.

## Objective

Write a function that takes as its input a number (n) and converts it to a string, the contents of which depend on the numbers factors

- if the number has a factor of 3, output `Pling`
- if the number has a factor of 5, output `Plang`
- if the number has a factor of 7, output `Plong`
- if the number does not have any of the above as a factor simply return the numbers digits

## Examples

- 28's factors are 1, 2, 4, 7, 14 and 28: this would be a simple `Plong`
- 30's factors are 1, 2, 3, 5, 6, 10, 15, 30: this would be a `PlingPlang`
- 34 has four factors: 1, 2, 17, and 34: this would be `34`

## Testing

<image src="images/example-test.png" width="80%" height="80%">

The typical structure of the unit tests used in this application is seen above.
Each test is accompanied by several `[TestCase]` attributes which parameterises the tests to allow for multiple values to be tested against within a single test.

The naming convention of the test methods take the form of:
1. The method being tested
2. The condition(s) to test against
3. The expected output out of the test

This convention has the advantage of mapping onto the more user-friendly Gherkin syntax that is found with Behaviour-Driven Development(BDD). Using the example test above, the corresponding Gherkin syntax would roughly equate to:
1. `GIVEN` the `PlingPLangPlong` method
2. `WHEN` the <input> has a factor of 3
3. `THEN` the method should return pling

Within the test, the Arrange-Act-Assert(AAA) pattern has been employed to standardise the readability and structure of the tests. The system under test (SUT) consists of a class which holds the single 'PlingPlangPlong' method that is being tested in all of the test methods. As the SUT does not have a state, the initial Arrange section has been delegated to the class level field `_sut` that is shared between all test methods. The Act and Assert sections follow standard convention where data is processed in the Act section, and this data asserted against in the following Assert section.
