int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if  (a > max) max = a;
if  (b > max) max = b;
if  (c > max) max = a;
if  (d > max) max = a;
if  (e > max) max = a;

Console.Write("Write = ");
Console.WriteLine(max);