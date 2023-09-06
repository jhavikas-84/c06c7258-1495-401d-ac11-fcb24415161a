# c06c7258-1495-401d-ac11-fcb24415161a

## Problem
Develop a function that takes one string input of any number of integers separated by a single whitespace. The function then outputs the longest increasing subsequence (increased by any number) present in that sequence. If more than 1 sequence exists with the longest length, output the earliest one. You may develop supporting functions as many as you find reasonable.


> Application Execution

*Clone or download the application,  make sure you have the `.net 7.0` installed in your system*
*Please run the `Program` file in the Kmart.ConsoleApp, you can change the input value by using the `inputString` variable*
*Alternatively you can run the Test Cases in the `Kmart.UnitTest` project*

![image](https://github.com/jhavikas-84/c06c7258-1495-401d-ac11-fcb24415161a/assets/144097762/2c8540d2-dc5d-4a21-953d-0a900602c96f)


`Solution Structure`

![image](https://github.com/jhavikas-84/c06c7258-1495-401d-ac11-fcb24415161a/assets/144097762/7377cf6c-aa72-4f58-9b68-b23d8c8c7e14)

### Kmart.Core
_This is the library project which contains the core business logic in service interface and implementation_

### Kmart.ConsoleApp
_This is a basic console application for quick testing, simply provide the actual string input to the variable *inputString* to get the expected outcome which will be printed on the console_

### Kmart.UnitTest
_This is a xUnit test application that is testing the given scenarios and also for  `FormatException` thrown for an invalid input_ 

*Below is the screenshot of 12 test cases*

![image](https://github.com/jhavikas-84/c06c7258-1495-401d-ac11-fcb24415161a/assets/144097762/b1c80645-4d7e-471b-957e-9cbc0b7963d6)


