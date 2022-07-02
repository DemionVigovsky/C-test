/*Console.WriteLine("Введите число дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 1){
    Console.WriteLine("Понедельник");
}
if(number == 2){
    Console.WriteLine("Вторник");
}
if(number == 3){
    Console.WriteLine("Среда");
}
if(number == 4){
    Console.WriteLine("Четверг");
}
if(number == 5){
    Console.WriteLine("Пятница");
}
if(number == 6){
    Console.WriteLine("Суббота");
}
if(number == 7){
    Console.WriteLine("Воскресенье");
}
if(number > 7|| number < 1){
    Console.WriteLine("Ошибка");
}
*/

Console.WriteLine("Введите число дня недели");
int? input = Convert.ToInt32(Console.ReadLine());

    switch (input)
    {
        case 1:
            Console.WriteLine("Понедельник");
            break;
        case 2:
            Console.WriteLine("Вторинк");
            break;
        case 3:
            Console.WriteLine("Среда");
            break;
        case 4:
            Console.WriteLine("Четверг");
            break;
        case 5:
            Console.WriteLine("Пятница");
            break;
        case 6:
            Console.WriteLine("Суббота");
            break;
        case 7:
            Console.WriteLine("Воскресенье");
            break;
        default:
            Console.WriteLine("Ошибка");
            break;
    }