// // Вид 1. Методы, которые ничего не принимают и ничего не возвращают.
// void Method1()
// {
//     Console.WriteLine("Автор: Вадим Талимончик"); // например, выводить авторство
// }
// // такой метод вызывается таким образм -
// // указать идентификатор этого метода и открывающиеся и закрывающиеся круглые скобки
// Method1();

// ============

// // Вид 2. Методы, которые могут принимать какие-то аргументы, но ничего не возвращают
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");
// ---------------
// void Method21(string msg, int count)
// // используется значение count, для того, чтобы показать
// // определённое колличество сообщений msg, которые будут
// //передоваться в данный метод
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method21("Текст", 4); // 4 - это сколько раз выводить сообщение
// // Method21(msg: "Текст", count: 4); // можно явно указывать какому
//                                      // аргументу какое значение принадлежит
// Method21(count: 4, msg: "новый текст");

// =================

// // Вид 3. Методы, которые ничего не принимают, но что-то возвращают

// // обязательно должны указать тип данных, значения которого ожидаем

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3(); // используя индефикатор переменной "year" через
//                       // оператор присваивания "=" положим нужное значение

// Console.WriteLine(year); // далее используем переменную "year", значение
//                          // которой вернул метод

// =================

// // Вид 4. Методы, которые что-то принимают и что-то возвращают.

// string Method4(int count, string text)
// {
//     int i = 0; // возьмём цикл
//     // string result = ""; // пустая строка
//     // по другому (чтобы не только сам понимал, что написано в коде) используется
//     string result = string.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "qwrt"); // создаём переменную для вызова метода и
//                                 // укажем сколько раз склеить указанный текст
// Console.WriteLine(res);

// ================

// // Цикл for

// string MethodF(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = MethodF(10, "Oo_");
// Console.WriteLine(res);

// =================

// Цикл в цикле
// Задача: вывод таблицы умножения на экран

// for(int i = 2; i <= 10; i++) // i = 2, т.к. таблица умножения начинается с 2
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}"); // интерполяция, способ когда в строку можно
//                                                    // вставить числовые значения прямо при выводу                                          
//     }
//     Console.WriteLine(); // вывод пустой сроки для разделения, в данном случае, прохождения цикла
// }


// ========= Работа с текстом ===========

// Задача.
// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие
// буквы “к” заменить большими “К”, а большие “С” заменить маленькими “с”.
// Текст:
// — Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо
// нашего милого Винценгероде, вы бы взяли приступом согласие прусского
// короля. Вы так красноречивы. Вы дадите мне чаю?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwert"
// //             012..  // строка в коде начинает нумироваться с нуля, например
// // s[3] -> r          // цифра в квадратных скобачках обозночает место символа в строке

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty; // инициализация пустой строки

//     int length = text.Length; // получение длины строки (показывает количество символов в строке)
//     for(int i = 0; i < length; i++) // циклом for пробегаемся от нулевого символа (i = 0) до
//                                     // конца строки (i < lendth)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);

// ==============

// Упорядочить массив

int[] arr ={ 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // заведём массив который будем отсортировывать

void PrintArray(int[] array) // метод вывода на экран массива
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition]; //
        array[minPosition] = temporary; // замена двух позиций местами
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);