#include <iostream>
#include "StringS.h"

int main() {
    using namespace std;

    string input;
    cout << "������ �����: ";
    getline(cin, input);

    StringManipulator sm(input);

    cout << "���������� �����: " << sm.getText() << endl;
    cout << "������� �����: " << sm.calculateLength() << endl;

    sm.shiftRight();
    cout << "����� ���� ����� ��������: " << sm.getText() << endl;

    return 0;
}