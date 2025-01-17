// son ek olarak ++
Console.WriteLine("son ek olarak ++ operatörü");
int n1 = 5;
Console.WriteLine(n1); // 5
Console.WriteLine(n1++);  // 5
Console.WriteLine(n1); // 6
Console.WriteLine(n1++); // 6
Console.WriteLine(n1); // 7

// ön ek olarak ++
Console.WriteLine("ön ek olarak ++ operatörü");
int n2 = 5;
Console.WriteLine(n2); // 5
Console.WriteLine(++n2);  // 6
Console.WriteLine(n2); // 6
Console.WriteLine(n2++); // 6
Console.WriteLine(n2); // 7

// son ek olarak --
Console.WriteLine("son ek olarak -- operatörü");
int n3 = 5;
Console.WriteLine(n3); // 5
Console.WriteLine(n3--);  // 5
Console.WriteLine(n3); // 4
Console.WriteLine(n3++); // 4
Console.WriteLine(n3); // 5


// ön ek olarak --
Console.WriteLine("ön ek olarak -- operatörü");
int n4 = 5;
Console.WriteLine(n4); // 5
Console.WriteLine(--n4);  // 4
Console.WriteLine(n4); // 4
Console.WriteLine(n4--); // 4
Console.WriteLine(n4); // 3

// pozitif negatif sayılarda işaret değiştiren -
Console.WriteLine("negatif pozitif işaret değiştiren - operatörü");
Console.WriteLine(-(-5));
Console.WriteLine(-(+5));
Console.WriteLine(-(5));

// + - * ve / işlemleri
Console.WriteLine("+ - * ve / işlemleri");
Console.WriteLine(3+4);
Console.WriteLine(3*4);
Console.WriteLine(3/2);
Console.WriteLine(8/3.0);
Console.WriteLine(100/5); // bölüm

// bölme işleminde kalan % operatörü
Console.WriteLine("kalan bulma % operatörü");
Console.WriteLine(10 % 3);
Console.WriteLine(100 % 5); // kalan
