n1:
Console.WriteLine("1. 3-Reqemli Ededinizi Daxil Edin: ");
int num1 = Convert.ToInt32(Console.ReadLine()); 
if(!(num1>99 && num1 < 1000))
{
    Console.WriteLine("Daxil Etdiyiniz Eded 3-Reqemli Deyil!");
    goto n1;
}
n2:
Console.WriteLine("2. 3-Reqemli Ededinizi Daxil Edin: ");
int num2 = Convert.ToInt32(Console.ReadLine()); 
if (!(num2 > 99 && num2 < 1000))
{
    Console.WriteLine("Daxil Etdiyiniz Eded 3-Reqemli Deyil!");
    goto n2;
}

n3:
Console.WriteLine("1. 4-Reqemli Ededinizi Daxil Edin: ");
int num3 = Convert.ToInt32(Console.ReadLine()); 
if (!(num3 > 999 && num3 < 10000))
{
    Console.WriteLine("Daxil Etdiyiniz Eded 4-Reqemli Deyil!");
    goto n3;
}
n4:
Console.WriteLine("2. 4-Reqemli Ededinizi Daxil Edin: ");
int num4 = Convert.ToInt32(Console.ReadLine()); 
if (!(num4 > 999 && num4 < 10000))
{
    Console.WriteLine("Daxil Etdiyiniz Eded 4-Reqemli Deyil!");
    goto n4;
}
n5:
Console.WriteLine("1. 5-Reqemli Ededinizi Daxil Edin: ");
int num5 = Convert.ToInt32(Console.ReadLine()); 
if (!(num5 > 9999 && num5 < 100000))
{
    Console.WriteLine("Daxil Etdiyiniz Eded 5-Reqemli Deyil!");
    goto n5;
}
n6:
Console.WriteLine("2. 5-Reqemli Ededinizi Daxil Edin: ");
int num6 = Convert.ToInt32(Console.ReadLine());
if (!(num6 > 9999 && num6 < 100000))
{
    Console.WriteLine("Daxil Etdiyiniz Eded 5-Reqemli Deyil!");
    goto n6;
}
n7:
Console.WriteLine( "6-Reqemli Ededinizi Daxil Edin: ");
int num7 = Convert.ToInt32(Console.ReadLine());
if (!(num7 > 99999 && num7 < 1000000))
{
    Console.WriteLine("Daxil Etdiyiniz Eded 6-Reqemli Deyil!");
    goto n7;
}
Console.WriteLine("3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi: ");
int calculation_part_1 = (num1 + num2) + (num3 * num4);
Console.WriteLine("Neticeni gormek ucun her hansi bir duymeye bas...");
Console.ReadKey();
Console.WriteLine("Cavab: "+ calculation_part_1);

Console.WriteLine("Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini: ");
int calculation_part_2 = ((calculation_part_1 * 10)+7) + (num5 + num6);
Console.WriteLine("Neticeni gormek ucun her hansi bir duymeye bas...");
Console.ReadKey();
Console.WriteLine("Cavab: "+(calculation_part_2));

Console.WriteLine("Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini: ");
int calculation_part_3 = calculation_part_2 - (num1 * num2 * 10 + (1));
Console.WriteLine("Neticeni gormek ucun her hansi bir duymeye bas...");
Console.ReadKey();
Console.WriteLine("Cavab: "+calculation_part_3);

Console.WriteLine("Sonra alinan cavabin ustune gel 6 reqemli ededi: ");
int calculation_part_4 = calculation_part_3 + num7;
Console.WriteLine("Neticeni gormek ucun her hansi bir duymeye bas...");
Console.ReadKey();
Console.WriteLine("Cavab: "+calculation_part_4);

Console.WriteLine("Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.\r\n");
int calculation_part_5 = calculation_part_4 - (num1 + num2 + num3 + num4);
Console.WriteLine("Neticeni gormek ucun her hansi bir duymeye bas...");
Console.ReadKey();
Console.WriteLine("Cavab: "+calculation_part_5);

Console.WriteLine("Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap: ");
double calculation_part_6 = (((calculation_part_5 * 0.18) * 0.03) * 0.01);
Console.WriteLine("Neticeni gormek ucun her hansi bir duymeye bas...");
Console.ReadKey();
Console.WriteLine("Cavab: "+calculation_part_6);

Console.WriteLine("Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel: ");
double calculation_part_7_son = calculation_part_6 + (num5 + num6);
Console.WriteLine("Neticeni gormek ucun her hansi bir duymeye bas...");
Console.ReadKey();
Console.WriteLine("Cavab: "+ calculation_part_7_son);
