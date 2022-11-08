// Горлачев средний уровень 
double q = 2;
double b = 1.8;
double e = 2.71828182846;
double t = 0;
t = Math.Pow(b, 3) + Math.Pow(Math.Exp(e), Math.Sqrt(q));
double x = Math.Pow(t, 3) + Math.Pow(b, 2);
double y = Math.Pow(Math.Atan(Math.Abs(x)), 2);
Console.WriteLine("Ответ y:"+y);
Console.WriteLine("Ответ x:"+x);
Console.WriteLine("Ответ t:"+t);