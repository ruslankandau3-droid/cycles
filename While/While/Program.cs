//Console.WriteLine("joonista sulle kolmnurga");
//int kolmnurgaSuurus = int.Parse(Console.ReadLine());

//int i = 1; 
//while (i <= kolmnurgaSuurus)
//{
//    Console.WriteLine();
//    int j = 1;
//    while (j <= i)
//    {
//        Console.Write("█▒");
//        j++;
//    }
//    i++;
//}

Console.WriteLine("tere tulemast mobifox parandusautomaati! Kuidas saan aidata");
Console.WriteLine("0 - headaega\n1 - tahan telefoni parandada");
Console.WriteLine("palun tee valik, kirjutades vastav arv:");
int valik = int.Parse(Console.ReadLine());
while (valik < 0 && valik > 1)
{
    Console.WriteLine("Palun tee oma valik, kirjutades vastav arv");
    int valik1 = int.Parse(Console.ReadLine());
}
if (valik == 0)
{
    Console.WriteLine("Headaega, tulge teinekord jälle!");
}
else
{
    Console.WriteLine("palun sisesta oma telefoni mudel, mida parandada soovid:");
    Console.WriteLine("1-iFõõn\n2-xiaomjäu\n3-nihuawei\n4-Samsung");
    Console.WriteLine("palun tee valik, kirjutades vastav arv:");
    int telefonimudel = 0;
    telefonimudel = int.Parse(Console.ReadLine());
    while (telefonimudel < 1 && telefonimudel > 4)
    {
        telefonimudel = int.Parse(Console.ReadLine());
    }
    switch (telefonimudel)
    {
        case 1:
            Console.WriteLine("Aitäh, oma iFööni saad tagasi 1 ndala pärast");
            break;
        case 2:
            Console.WriteLine("Aitäh, sinu xiaomjäu on valmis 2 kuu pärast");
            break;
        case 3:
            Console.WriteLine("kahjuks me nihuawed ei teeninda");
            break;
        case 4:
            Console.WriteLine("Sinu Samsung on valmis 2 päeva pärast");
            break;
        default:
            Console.WriteLine("Ei tunne sellist telefonitootjat");
            break;
    }
}
