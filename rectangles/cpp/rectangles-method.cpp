#include <iostream>
#include <iomanip>
using namespace std;


// Function to evaluate f(x) = x^2 + 3
double f(double x)
{
    return x * x + 3;
}

// Rectangle method - approximates the integral of f(x) in [a, b] using n rectangles
double rectangle_method(double a, double b, double n)
{
    // Width of each rectangle
    double h = (b - a)/n;
    double S = 0;
    double area;

    for(int i = 0; i < n; i++)
    {
        // Left endpoint of each rectangle
        double x = a + i * h;

        // Add rectangle area to sum
        S+=f(x);
    }

    area = h * S;
    return area;
}


int main()
{
    double a = 0;
    double b = 0;
    double n = 0;

    //User input
    cout << "Enter a value of a: ";
    while (!(cin >> a))
    {
        cin.clear();
        cin.ignore();
        cout << "Invalid input. Enter a valid number: ";
    }

    cout << "Enter a value of b: ";
    while (!(cin >> b))
    {
        cin.clear();
        cin.ignore();
        cout << "Invalid input. Enter a valid number: ";
    }

    cout << "Enter a value of n: ";
    while (!(cin >> n))
    {
        cin.clear();
        cin.ignore();
        cout << "Invalid input. Enter a valid number: ";
    }

    // Calculate and print the area
    double area = rectangle_method(a,b,n);
    cout << "The approximate area is: " << fixed << setprecision(4) << area << endl;

    return 0;
}