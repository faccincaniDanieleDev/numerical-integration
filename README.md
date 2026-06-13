# 📐 Numerical Integration

Implementation of numerical integration methods in C++, C# and Python.

---

## Methods

### Rectangle Method

The Rectangle Method approximates the definite integral of a function f(x) in a given interval [a, b]. It works by dividing the interval into n rectangles of equal width and summing their areas.

**Function used:** `f(x) = x² + 3`

---

## Project Structure
numerical-integration/

│

├── rectangles/

│   ├── cpp/

│   │   └── rectangles-method.cpp

│   ├── csharp/

│   │   ├── rectangles-method-c-sharp.csproj

│   │   └── Program.cs

│   └── python/

│       └── rectangles-method.py

│

├── README.md

├── .gitignore

└── LICENSE

---

## Requirements

- **C++**: g++ compiler
- **C#**: .NET SDK 6.0 or higher
- **Python**: Python 3.10 or higher

---

## How to Run

### C++
g++ rectangles-method.cpp -o rectangles-method

./rectangles-method

### C#
cd csharp

dotnet run

### Python
cd python

python rectangles-method.py

---

## Test Values

| Input | Result |
|---|---|
| a = 0, b = 2, n = 100 | 8.6268 |
| a = 0, b = 2, n = 1000 | 8.6627 |

Exact analytical result: **8.6667**

---

## Accuracy

The more rectangles (n) you use, the closer the result is to the exact value.

---

## Future Improvements

- Allow the user to input a custom function
- Allow the user to set a custom number of rectangles
- Implement other numerical integration methods (Trapezoidal, Simpson)

---

## What I Learned

- How to approximate definite integrals using the Rectangle Method
- How to implement the same algorithm across C++, C# and Python
- How increasing n improves approximation accuracy

---

## License

MIT License — see [LICENSE](LICENSE) for details.
