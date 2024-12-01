// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// bu tek satırdan oluşan bir yorum 

// çok satırlı yorum örneği /**/ kullanımı
/*
for (int i = 0; i < 10; i++) // kişileri listelemek için
{
    if (true) // yaşı 20'den büyük olanları seçmek için
    {
        while (true)
        {
            
        }
    }
}
*/

/*
Burası çok satırlı bir açıklama, paragraf gibi de düşünülebilir
yorum alanıdır. 
Açıklama 1
açıklama 2
Açıklama 3
*/

// Değişken mantığı
/*
int x = 53.6;

(5*x-55)/1950
(5*x-35)/150
(5*x+155)/650
(5*x-2055)/950
*/

// dilekçeler ya da evraklardaki boş bırakılan doldurduğumuz kişisel bilgi alanları gibi düşünülebilir
/*
string ad = "ümit";
string tcno = "1122";

ad isimli tcno TC kimlik numaralı
*/

// hatalı değişkenler
// string 1ad = "ümit";
// int %yas = 20;
// string %sehir = "izmir";

// hatasız değişkenler
string isim = "ümit";
int yas = 39;
int _kilo = 60;
Console.WriteLine(isim);

// değişken isimi birden fazla kelimeden oluşuyorsa tüm kelimeler bitişik ve ilk kelime hariç diğer kelimelerin ilk harfi büyük yazılabilir
/*
kisiAdi
kisiSoyadi
kisiNo
kisiAldigiDersler
*/

// var kullanımı
int yas1;
var isim1 = "Zeynep"; // var ile değişken değerini yazmalıyız.
var isim2 = 30;
isim2 = 25;

// var hatalı kullanımı
// var kilo2;

// sizeof komutu (değer türürnün boyunu öğrenmek için)
Console.WriteLine(sizeof(int)); // 4
Console.WriteLine(sizeof(byte)); // 1
Console.WriteLine(sizeof(long)); // 8

// tür dönüşümleri
// örtülü dönüşüm
int sayi1 = 36;
long sayi2 = sayi1;
Console.WriteLine(sayi1);
Console.WriteLine(sayi2);

// açık dönüşüm
double sayi3 = 1.75;
int sayi4 = (int)sayi3;
Console.WriteLine(sayi3);
Console.WriteLine(sayi4);

Console.WriteLine("Program sonu");
