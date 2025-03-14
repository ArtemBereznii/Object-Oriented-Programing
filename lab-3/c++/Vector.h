#ifndef VECTOR_H
#define VECTOR_H

#include <iostream>
#include <cmath>

class Vector2D {
private:
    double length;
    double angle; 

public:
    Vector2D();
    Vector2D(double l, double a);
    Vector2D(const Vector2D& other); 

    void rotate(double angle);
    double getLength() const; 
    double getAngle() const;

    Vector2D operator+(const Vector2D& other) const;
    Vector2D operator*(double scalar) const;

    void print() const;
};

#endif