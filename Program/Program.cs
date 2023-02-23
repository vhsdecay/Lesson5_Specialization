// Контрольное задание
// Программа

// Написать программу которая из емеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] SplitElments(string nonsplit) // Преобразование строки в массив
{
    string[] splitting = nonsplit.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
    return splitting;
}

string SreachElement(string [] array) // Поиск и заполнение строки требуемым значением
{
    string elementSort = "";
    foreach (var element in array)
    {
        if (element.Length <= 3)
        {
            elementSort += element + " ";
        }
    }
    return elementSort;
}