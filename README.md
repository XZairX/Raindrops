# Raindrops

Sample testing application.

## Objective

Write a function that takes as its input a number (n) and converts it to a string, the contents of which depend on the numbers factors

- if the number has a factor of 3, output ```Pling```
- if the number has a factor of 5, output ```Plang```
- if the number has a factor of 7, output ```Plong```
- if the number does not have any of the above as a factor simply return the numbers digits

## Examples

- 28's factors are 1, 2, 4, 7, 14 and 28: this would be a simple ```Plong```
- 30's factors are 1, 2, 3, 5, 6, 10, 15, 30: this would be a ```PlingPlang```
- 34 has four factors: 1, 2, 17, and 34: this would be ```34```

## Testing

<image src="images/example-test.png" width="80%" height="80%">

The typical structure of the unit tests used in this application is seen above.
Each test is accompanied by several ```[TestCase]``` attributes which parameterises the tests to allow for multiple values to be tested against.

The naming convention of methods take the form of:
1. Method being testing against
2. Condition to test
3. Expected output

Using the example above, this equates to:
1. ```GIVEN``` the ```PlingPLangPlong``` method
2. ```WHEN``` the argument number (input) does not have a factor of 3 or 5 or 7
3. ```THEN``` the method should return the argument number
