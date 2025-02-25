#ifndef STRINGS_H
#define STRINGS_H

#include <string>
using namespace std;

class StringManipulator {
private:
    string text;

public:
    StringManipulator();
    StringManipulator(const string& str);
    StringManipulator(const StringManipulator& other);
    ~StringManipulator();
    int calculateLength() const;
    void shiftRight();
    string getText() const;
    StringManipulator& operator=(const StringManipulator& other);
};

#endif