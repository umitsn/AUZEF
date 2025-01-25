// matıksal operatörler

//! değil operatörü (tersini alan)
Console.WriteLine("! değil operatörü");
Console.WriteLine(!true);
Console.WriteLine(!false);
bool b1 = true;
Console.WriteLine(!b1);
Console.WriteLine(!(!b1));
Console.WriteLine(!(!false));

// ve = AND (&) operatörü
Console.WriteLine("& operatörü");
bool b2 = true;
bool b3 = false;
Console.WriteLine(b2 & b3);

Console.WriteLine(true & true);
Console.WriteLine(true & false);
Console.WriteLine(false & true);
Console.WriteLine(false & false);


// veya = OR (|) operatörü
Console.WriteLine("veya | operatörü");
bool b4 = true;
bool b5 = false;
Console.WriteLine(b4 | b5);

Console.WriteLine(true | true);
Console.WriteLine(true | false);
Console.WriteLine(false | true);
Console.WriteLine(false | false);

// && operatörü
Console.WriteLine("&& operatörü");
Console.WriteLine(true && true);
Console.WriteLine(true && false);
Console.WriteLine(false && true);
Console.WriteLine(false && false);


// || Operatörü
Console.WriteLine("|| operatörü");
Console.WriteLine(true || true);
Console.WriteLine(true || false);
Console.WriteLine(false || true);
Console.WriteLine(false || false);


// == operatörü
Console.WriteLine("eşit mi, == operatörü");

int a = 5;
int b = 6;
Console.WriteLine(a == b);
Console.WriteLine(a < b);
Console.WriteLine(true == true);
Console.WriteLine(a == 5);
Console.WriteLine(a != 7);

Console.WriteLine("umit" == "Umit");
Console.WriteLine("umit" == "umit");
string ad = "umit";
Console.WriteLine(ad == "ŞEN");
