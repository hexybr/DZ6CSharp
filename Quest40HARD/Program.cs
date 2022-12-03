//На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника. 
//Если да, то вывести всю информацию по нему:
// площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.
 Console.WriteLine("Введите первое число: ");// Введение числа элементов массива
 int one = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите второе число: ");
 int two = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Введите третье число: ");
 int three = int.Parse(Console.ReadLine()!);

 if (one< two+three&& two< one+three&& three< one+two)
 {
 double perimetr = 0; double area = 0; double firstcorner = 0; double secondcorner = 0;
 double thirdcorner = 0; string type = "треугольник";

 }


// void Triangle()
// {
//    double per = one+two+three;


// }