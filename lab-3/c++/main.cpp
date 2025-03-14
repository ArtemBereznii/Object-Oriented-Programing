#include "Vector.h"
#include <iostream>
#include <cmath>

int main() {
    const double PI = 3.14159265358979323846;

    Vector2D Z1; 
    Vector2D Z2(3.0, 0.0); 
    Vector2D Z3(Z2);

    std::cout << "Initial vectors:" << std::endl;
    std::cout << "Z1: "; Z1.print();
    std::cout << "Z2: "; Z2.print();
    std::cout << "Z3: "; Z3.print();

    Z3 = Z3 * 2;
    std::cout << "\nAfter scaling Z3 by 2:" << std::endl;
    std::cout << "Z3: "; Z3.print();

    Z3.rotate(PI / 2);
    std::cout << "\nAfter rotating Z3 by 90 degrees:" << std::endl;
    std::cout << "Z3: "; Z3.print();

    Z1 = Z2 + Z3;
    std::cout << "\nAfter adding Z2 and Z3 (result in Z1):" << std::endl;
    std::cout << "Z1: "; Z1.print();

    return 0;
}