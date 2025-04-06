#include "Segment.h"
#include <cmath>

Segment::Segment(double x1, double y1, double x2, double y2)
    : Line(x1, y1, x2, y2) {
}

double Segment::calculateAngleWithOY() const {
    double dx = x2 - x1;
    double dy = y2 - y1;
    return atan2(dx, dy) * 180 / M_PI; // Переведення в градуси
}