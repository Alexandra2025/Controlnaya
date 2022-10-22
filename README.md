# Controlnaya

Описание решения задачи контрольной работы
Задача:
Написать программу, которая из введенного массива строк формирует массив из строк, длина которых меньше либо равна 3.

1.  Вывод строки - приглашения ввести элементы массива через пробел для пользователя(вводится строка).

2.  Считывается строка, введенная пользователем.

3.  Объявляется новый массив array1, в который помещается строка, деленная на элементы по пробелу при помощи метода Split(' ').

4.  Объявляется метод Stroka, который преобразует массив в строку с элементами длиной не больше 3 символов:
    а) объявляется пустая строка;
    б) цикл перебора элементов массива(проверяется на условие каждый элемент с [0] до [n]):

    - если элемент массива меньше 3 символов, то элемент добавляется в строку + пробел;
    - переход к следующему элементу.

    в) удаляется последний пробел при помоши метода Remove();
    г) возвращается новая строка с элементами длиной не больше 3 символов

5.  Обявляется строка stroka2, которой присваевается значение(stroka2) после применения к массиву arrey1 метода Stroka.

6.  Объявляется новый массив array2, в который помещается stroka2, деленная на элементы по пробелу при помощи метода Split(' ').

7.  Вывод квадратной скобки + кавычки: "[\"";

8.  Вывод массива arrey2, элементы которого разделены запятой и кавычками при помощи метода Join();

9.  Вывод квадратной скобки + кавычки: "\"]".
