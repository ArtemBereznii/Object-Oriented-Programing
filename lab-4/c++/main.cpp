#include <iostream>
#include "Segment.h"

int main() {
    Segment segment(0, 0, 3, 4);

    std::cout << "Coordinates: (" << segment.getX1() << ", " << segment.getY1()
        << ") to (" << segment.getX2() << ", " << segment.getY2() << ")\n";
    std::cout << "Length: " << segment.calculateLength() << "\n";
    std::cout << "Angle with OY axis: " << segment.calculateAngleWithOY() << " degrees\n";

    return 0;
}