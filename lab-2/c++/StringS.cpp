#include "StringS.h"

using namespace std;

StringManipulator::StringManipulator() : text("") {}

StringManipulator::StringManipulator(const string& str) : text(str) {}

StringManipulator::StringManipulator(const StringManipulator& other) : text(other.text) {}

StringManipulator::~StringManipulator() {}

int StringManipulator::calculateLength() const {
    return text.length();
}

void StringManipulator::shiftRight() {
    if (!text.empty()) {
        char lastChar = text.back();
        text.pop_back();
        text.insert(text.begin(), lastChar);
    }
}

string StringManipulator::getText() const {
    return text;
}

StringManipulator& StringManipulator::operator=(const StringManipulator& other) {
    if (this != &other) {
        text = other.text;
    }
    return *this;
}