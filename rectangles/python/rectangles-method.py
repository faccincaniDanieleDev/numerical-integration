#Function to evaluate f(x) = x^2 + 3
def f(x: float) -> float:
    return x * x + 3

#Rectangle method - approximates the integral of f(x) in [a, b] using n rectangles
def rectangle_method(a: float, b: float, n: float) -> float:
    #Width of each rectangle
    h: float = (b - a)/n
    S: float = 0
    
    for i in range(int(n)):
        #Left endpoint of each rectangle
        x: float = a + i * h
        
        #Add rectangle area to sum
        S+=f(x)
        
    return h * S


def main() -> None:
    a: float
    b: float
    n: float
    
    while True:
        try:
            a = float(input("Enter a value of a: "))
            break
        
        except ValueError:
            print("Invalid input. Enter a valid number: ")
            
    
    while True:
        try:
            b = float(input("Enter a value of b: "))
            break
        
        except ValueError:
            print("Invalid input. Enter a valid number: ")
            
    
    while True:
        try:
            n = float(input("Enter a value of n: "))
            break
        
        except ValueError:
            print("Invalid input. Enter a valid number: ")
            
    
    #calculate and print the area
    area: float = rectangle_method(a,b,n)
    print(f"The approximate area is: {area:.4f}")
    
    
if __name__ == "__main__":
    main()