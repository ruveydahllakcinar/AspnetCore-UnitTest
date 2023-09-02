
# What is Unit Test?

* It is the process of testing how the smallest parts of an application behave independently of each other.

## Advantages of Unit Tests

**Early Bug Detection:** Unit tests allow you to detect bugs in the code you write at the earliest stage. This prevents bugs from being found later in the production environment or by users. This speeds up the bug fixing process and reduces development costs.

**Improving Code Quality:** Unit tests help you improve the quality of your code. Each piece of your code is tested to meet expected behaviors. This helps you write more organized, readable and maintainable code.

**Documentation and Expression:** Unit tests serve as a source of documentation to understand your code. Each test clearly states how a piece of code should be used and what kind of results it should produce. This helps others understand your code more easily.

**Ease of Refactoring:** When you need to refactor your code, you can be sure that it still works correctly thanks to the existing tests. This allows you to make improvements or changes to your code with confidence.

**Ease of Teamwork:** When working as a team, each member can include unit tests of the code they are writing, ensuring that everyone's code works together. This makes coordination easier on large projects.

**Faster Development:** Test automation can speed up the development process. Because instead of manually testing every change of your code, you can test it quickly and reproducibly using automated tests.

## What are Test Types?

* An application has a test process consisting of 4 steps.

**Unit Tests:**  It is the stage where the smallest parts of an application are tested at the bottom step.

**Integration Tests:**  It is the process of testing how the components or modules in an application behave with each other.

**End to End Tests:** It is the process of testing how an application behaves from start to finish.

**Regression Tests:** Used to ensure that new changes made to an application do not affect the existing functionality. In other words, new features or fixes are tested to ensure that they do not break the proper functioning of existing features.

## Assert Methods
`assertEqual(a, b):` This method checks if two values are equal to each other. If the values are not equal, it throws an error.

`assertNotEqual(a, b):` This method checks if two values are not equal. If the values are equal, it throws an error.

`assertTrue(expr):` Checks if the given expression is true. If the expression is false, it generates an error.

`assertFalse(expr):` Checks if the given expression is false (False). If the expression is true, it generates an error.

`assertIs(a, b):` This method checks if a and b are the same object. If a and b are not the same object, it throws an error.

`assertIsNot(a, b):` This method checks if a and b are different objects. If a and b are the same object, it raises an error.

`assertRaises(exception, callable, *args, kwargs):` This method checks if the specified exception is caught when the specified function (callable) is called. If the exception is not caught, it raises an error.

`assertIn(a, b):` This method checks if a is contained in b. If a is not in b, it throws an error.

`assertNotIn(a, b):` This method checks if a is contained in b. If a is not in b, it throws an error.

`assertAlmostEqual(a, b, places=7):` This method checks if two numbers are approximately equal up to the specified number of decimal places.

`assertNotAlmostEqual(a, b, places=7):` This method checks that two numbers are not approximately equal up to the specified number of decimal places.

`assertIsInstance(a, b):` This method checks if a is an instance of class b.

`assertNotIsInstance(a, b):` This method checks if a is an instance of class b.

`StartsWith:` We set a criterion according to what you want the expected value to start with

`EndWith:` Determined according to what you want the expected value to end with

`Empty:` Checks whether the directory it receives as a parameter is empty or not. It returns true if the directory you defined in it is empty. If it is full, it returns false.
```csharp
  Assert.Empty(new List<string>() { "Ruveyda"}) ; This returns false
```
`NotEmpty:` Requests that the index inside is not empty. Returns true if the index is not empty and false if it is empty.
```csharp
 Assert.Empty(new List<string>() { "Ruveyda"}) ; This returns true
```
`InRange:` InRange is used to check if a value is within a certain range. This method verifies whether a value is between (or within) the minimum and maximum limits.

`Single:` Returns true if the array has one element and false if it has more than one element.
```csharp
  Assert.Single(new List<string>() { "Ruveyda"}) ; //returns true
    
  Assert.Single(new List<string>() { "Ruveyda", "Ayşe"}) ; //returns false
```
`IsType:` It is a method that checks the type of the variable it will take in. It is a generic method. Together with the generic, it performs a test to see if the type inside is correct.

```csharp
Assert.IsType<string>("Ruveyda")
```

IsAssignableFrom: Tests whether a type can reference a type. For example, it returns true if a type can reference a type and false if it cannot.
```csharp
Assert.IsAssignableFrom<IEnumarable<string>>(new List<string>());
```
Equal: It is the process of comparing two values with each other. When two values are compared, if they are the same, true is returned and if they are different, false is returned.

## Parameterization status of Test Methods

> `[Fact]:`

* The [Fact] attribute is the identifying property of a test method.

* It turns a method into a test method.

* It is not expected to take parameters, i.e. it is executed using a fixed input.

* It is typically used for simple and parameterless test cases.
```csharp
namespace XUnitTest.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            ////Arrange
            int a=5;
            int b=20;

            var calculator = new Calculator();

            //Act
            var total = calculator.add(a, b);

            //Assert
            Assert.Equal<int>(25,total);
        }
    }
}
```
> `[Theory]:`

* The [Theory] attribute is used to run a test method with different parameter sets.

* Multiple parameter sets can be provided and the test method is run for each one separately.

* Useful for tests covering different scenarios.

> `[InlineData]:`

* The [InlineData] attribute is used in combination with [Theory].

* It is used to define different parameter sets.

* It is used to determine which parameter sets to use for a [Theory] test.

* Each [InlineData] attribute is passed as a parameter to the test method specified by [Theory] in the same order.
```csharp
[Theory]
[InlineData(2,5,7)]
public void AddTest2(int a, int b, int expectedTotal)
{
  var calculator = new Calculator();
  var actualTotal = calculator.add(a.b);
  Assert.Equal(expectedTotal,actualTotal);
}
```
