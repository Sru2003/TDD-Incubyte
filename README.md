# String Calculator

This project is a simple string calculator implemented in C# using Test-Driven Development (TDD). The calculator can handle basic addition of numbers provided in a string format, manage custom delimiters, and throw exceptions for negative numbers.

---

## Features

- **Addition of numbers in a string**
  - Supports addition of numbers separated by commas or newlines.
- **Custom delimiters**
  - Handles user-defined delimiters.
- **Negative number handling**
  - Throws an exception for negative numbers.
- **Invocation count tracking**
  - Tracks how many times the `Add` method is called.

---

## Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Srus2003/StringCalculator.git
   ```
2. **Navigate to the project directory:**
   ```bash
   cd StringCalculator
   ```
3. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

---

## Usage

To use the String Calculator, create an instance of the `StringCalculator` class and call the `Add` method with a string of numbers.

---

## Exception Handling

> **NegativeNumberException:** Thrown when the input contains negative numbers.

---

## Tests

The project includes unit tests using the xUnit framework.

### Running Tests

```bash
dotnet test
```

### Test Cases

1. **Empty String:** Returns 0.
2. **Single Number:** Returns the number.
3. **Two Numbers:** Returns their sum.
4. **Multiple Numbers:** Handles multiple numbers separated by commas.
5. **Newline Separator:** Supports newline as a separator.
6. **Custom Delimiters:** Handles custom delimiters defined at the start of the string.
7. **Negative Numbers:** Throws an exception with the message listing all negative numbers.
8. **Invocation Count:** Tracks the number of times the `Add` method is called.

---



### Process Flow

1. **Input Parsing:**
   - Accept input string (e.g., `"1,2,3"`, `"//;\n1;2"`).
   - Replace custom delimiters with commas.
   - Replace newlines with commas.

2. **Sum Calculation:**
   - Split string by commas.
   - Convert each substring to an integer.
   - Sum the integers.

3. **Exception Handling:**
   - If negative numbers are found, throw `NegativeNumberException`.

4. **Invocation Tracking:**
   - Increment count each time `Add` is called.
   - Provide count via `GetCalledCount` method.

---


![String Calculator](https://via.placeholder.com/728x90.png)

---

## Labels

![Label](https://img.shields.io/badge/Status-Active-green)

---

## Task List

- [x] Implement basic addition
- [x] Handle custom delimiters
- [x] Implement negative number exception
- [x] Track invocation count
- [ ] Add more unit tests

---



---

## Emojis

- 🧮 **String Calculator**
- ✅ **Test-Driven Development**
- 🚀 **Easy to use**
- 🛠️ **Customizable**
- 🔍 **Thoroughly Tested**
