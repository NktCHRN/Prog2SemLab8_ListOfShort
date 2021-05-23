#include "ConsoleProjectLib.h"

using namespace std;

void ProgramInfo() {
    cout << "Lab N8. Nikita Chernikov, IS-02" << endl;
    cout << "Researching of building and using datastructures" << endl;
    cout << "Variant 15" << endl;
}

void ListMenu(ListOfShort* list) {
    PrintHelp(list);
    cout << "What do you want to do?" << endl;
    short choice;
    const short minPoint = 1;
    const short maxPoint = 5;
    do
    {
        cout << "\nEnter the number " << minPoint << " - " << maxPoint << ": " << endl;
        cin >> choice;
        if (cin.fail() || choice < minPoint || choice > maxPoint)
        {
            cin.clear();
            cin.ignore(std::numeric_limits<streamsize>::max(), '\n');
            cout << "Error: you entered not a number or number was smaller than " << minPoint << " or bigger than " << maxPoint << "." << endl;
            cout << "Help - " << maxPoint - 1 << endl;
            choice = minPoint - 1;
        }
        switch (choice)
        {
        case 1:
            system("cls");
            ProgramInfo();
            cout << endl;
            short number;
            cout << "Enter the short number you want to add:" << endl;
            cin >> number;
            while (cin.fail())
            {
                cin.clear();
                cin.ignore(std::numeric_limits<streamsize>::max(), '\n');
                cout << "Enter the short number you want to add once more:" << endl;
                cin >> number;
            }
            list->AddLast(number);
            cout << "List of shorts current state:" << endl;
            for (int i = 0; i < list->GetLength(); i++)
                cout << (*list)[i] << " ";
            cout << "\nPress ENTER to continue" << endl;
            cin.ignore(std::numeric_limits<streamsize>::max(), '\n');
            cin.get();
            break;
        case 2:
            system("cls");
            ProgramInfo();
            cout << endl;
            cout << "List of shorts current state:" << endl;
            for (int i = 0; i < list->GetLength(); i++)
                cout << (*list)[i] << " ";
            cout << "\nThere are " << list->CountMultiplesOfSeven() << " multiples of 7 in the list." << endl;
            cout << "\nPress ENTER to continue" << endl;
            cin.ignore(std::numeric_limits<streamsize>::max(), '\n');
            cin.get();
            break;
        case 3:
            system("cls");
            ProgramInfo();
            cout << endl;
            cout << "List of shorts before replacement:" << endl;
            for (int i = 0; i < list->GetLength(); i++)
                cout << (*list)[i] << " ";
            cout << "\nAverage: " << fixed << setprecision(3) << list->GetAverage() << endl;
            list->ChangeMoreThanAverageToZero();
            cout << "List of shorts current state:" << endl;
            for (int i = 0; i < list->GetLength(); i++)
                cout << (*list)[i] << " ";
            cout << "\nPress ENTER to continue" << endl;
            cin.ignore(std::numeric_limits<streamsize>::max(), '\n');
            cin.get();
            break;
        }
        if (choice >= minPoint && choice < maxPoint)
        {
            PrintHelp(list);
            cout <<"What do you want to do?" << endl;
        }
    } while (choice != maxPoint);
}

void PrintHelp(ListOfShort* list) {
    system("cls");
    ProgramInfo();
    cout << endl;
    cout << "List of shorts current state:" << endl;
    for (int i = 0; i < list->GetLength(); i++)
        cout << (*list)[i] << " ";
    cout << "\n" << endl;
    cout << "Menu:" << endl;
    cout << "1. Add number to the end" << endl;
    cout << "2. Count the quantity of the multiples of 7" << endl;
    cout << "3. Replace all numbers " << endl;
    cout << "4. Print help" << endl;
    cout << "5. Quit" << endl;
}