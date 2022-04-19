/* 
cout
* standart output stream
* console
* 
* cin						cin >> data;
* standart input stream		cin >> data1 >> data2
* keyboard
* 
* <<					cout << data
* insertion operator	cout << "data : " << data1
* output streams
* 
* >>
* extraction operator
* input streams 
endl or \n
*/

#include <iostream>
using namespace std;
int main()
{
	int nm1;
	int nm2;

	cout << "Cake\nIs\nA\nLie\n";
	cout << "Enter 2 int with space : ";
	cin >> nm1 >> nm2;
	cout << "Your first number is " << nm1 << " second number is " << nm2 << endl;
}
