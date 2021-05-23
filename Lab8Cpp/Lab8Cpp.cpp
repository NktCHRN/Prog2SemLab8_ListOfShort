#include "ConsoleProjectLib.h"

using namespace std;

int main()
{
    ProgramInfo();
    cout << endl;
    ListOfShort *list = new ListOfShort();
    ListMenu(list);
    delete list;
}