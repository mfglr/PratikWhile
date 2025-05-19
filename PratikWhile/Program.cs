// Ekrana 10 defa "Kendime inanıyorum, ben bu yazılım işini hallederim!" yaz.
int i = 0;
while(i < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}


//1 ile 20 arasındaki sayıları konsol ekranına yazdır
i = 1;
while(i <= 20)
{
    Console.WriteLine(i);
    i++;
}


//1 ile 20 arasındaki çift sayıları konsol ekranına yazdır
i = 1;
while(i <= 20)
{
    if(i %  2 == 0)
        Console.WriteLine(i);
    i++;
}


//50 ile 150 arasındaki sayıların toplamını ekrana yazdır
i = 50;
int sum = 0;
while(i <= 150)
{
    sum += i;
    i++;
}
Console.WriteLine("Toplam : " + sum);


//1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdır
int sumOdd = 0, sumEven = 0;
i = 1;
while(i <= 120)
{
    if (i % 2 == 0)
        sumEven += i;
    else
        sumOdd += i;
    i++;
}
Console.WriteLine("Çift Toplam : " + sumEven);
Console.WriteLine("Tek Toplam : " + sumOdd);

