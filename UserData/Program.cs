// See https://aka.ms/new-console-template for more information
//programm küsib kasutaja sünniaastat
//programm arvutab kasutaja vanust
//programm kuvab kasutaja vanust konsoolis
Console.WriteLine("Palun, sisesta oma sünniaasta:");
int yearofbirth = Convert.ToInt32(Console.ReadLine());
int userage = 2021 - yearofbirth;
//Console.WriteLine("oled " + userage + " aastat vana");
//string interpolation 
Console.WriteLine($"Oled {userage} aastat vana");