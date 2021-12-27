// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//programm küsib kasutaja vanust
//programm arvutab kasutaja sünniaastat
//proramm kuvab kasutaja sünniaastat konsoolis
//"oled sündinud aastal {yearofbirth}
Console.WriteLine("Palun, sisesta oma vanus:");
int userage = Convert.ToInt32(Console.ReadLine());
int yearofbirth = 2021 - userage;
Console.WriteLine($"Oled sündinud {yearofbirth} aastal");