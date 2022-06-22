//Задание 3
//Пользователь вводит строку с клавиатуры. Необходи-
//мо зашифровать данную строку используя шифр Цезаря. 
//Шифр Цезаря — это вид шифра подстановки, в ко-
//тором каждый символ в открытом тексте заменяется 
//символом, находящимся на некотором постоянном числе 
//позиций левее или правее него в алфавите. Например,
//в шифре со сдвигом вправо на 3, A была бы заменена на 
//D, B станет E, и так далее.


Console.WriteLine("Input string");
string str = Console.ReadLine();
Console.WriteLine("Еhe string needs to be decoded or encoded: 1 - decoded, 2 - encoded");
int flag = int.Parse(Console.ReadLine());
if (flag > 2 && flag < 1)
{
    Console.WriteLine("Errore, only 1 or 2");
    return;
}
Console.WriteLine("Input offset");
int d = int.Parse(Console.ReadLine()); // Смещение
Console.WriteLine("Input Direction Code (+ - to right, - - to to left)");
string z = Console.ReadLine();
char[] m = str.ToCharArray(); // Превращаем строку в массив символов.
for (int i = 0; i < m.Length; i++)
{
    if (z == "+" && flag == 1 || z == "-" && flag == 2)
    {
        m[i] = (char)((int)m[i] + d);
    }
    else if (z == "-" && flag == 1 || z == "+" && flag == 2)
    {
        m[i] = (char)((int)m[i] - d);
    }
    else
    {
        Console.WriteLine("Errore, only + or -");
        break;
    }
}
Console.WriteLine(m);
