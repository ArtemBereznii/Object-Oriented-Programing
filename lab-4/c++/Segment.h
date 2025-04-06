#ifndef SEGMENT_H
#define SEGMENT_H

#include "Line.h"

class Segment : public Line {
public:
    Segment(double x1, double y1, double x2, double y2);
    double calculateAngleWithOY() const;
};

#endif