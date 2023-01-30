using static System.Console;

Clear(); 

Write("Введи N: ");
int N = Convert.ToInt16(ReadLine());
Write("Введи M: ");
int M = Convert.ToInt16(ReadLine());
WriteLine($"N={N}, M={M}");
if (M>N)
for (int i = N; i <= M; i++)
    Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Write($" {i}");