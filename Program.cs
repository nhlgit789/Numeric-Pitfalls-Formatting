using System;

int a = 5, b = 2;
Console.WriteLine(a / b); // 2 (int division truncates)
Console.WriteLine(a / (double)b); // 2.5 (promote to double)
double avg = (5 + 2 + 3) / 3.0;
Console.WriteLine($"{avg:F2}"); // 3.33
