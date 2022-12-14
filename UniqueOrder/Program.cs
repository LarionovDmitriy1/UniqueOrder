using UniqueOrder;
//Задание:

//Реализуйте функцию unique_in_order, которая принимает в
//качестве аргумента последовательность и возвращает список элементов без
//каких-либо элементов с одинаковым значением рядом друг с другом и сохраняет 
//исходный порядок элементов.

//Например:

//Уникальный порядок("AAAABBBCCDAABBB") == { 'A', 'B', 'C', 'D', 'A', 'B'}
//Уникальный порядок("ABBCcAD") == { 'A', 'B', 'C', 'c', 'A', 'D'}
//Уникальный порядок([1,2,2,3,3]) == { 1,2,3}

Console.WriteLine("Введите буквы или цифры");
var result = SearchForAUniqueOrder.UniqueInOrder(Console.ReadLine());
foreach (var item in result)
{
    Console.WriteLine($"{item} ");
}

