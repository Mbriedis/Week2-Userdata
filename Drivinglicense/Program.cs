// See https://aka.ms/new-console-template for more information
//Programm küsib Kasutaja sünniaastat
//Programm arvutab kasutaja vanust
//kui kasutaja on noorem kui 18, siis programm kuvab konsoolis "oled liiga noor, et juhilube saada"
//kui kasutaja on vähemalt 18 aastat vana, siis programm kuvab konsoolis "oled piisavalt vana et juhilube saada"
Console.WriteLine("Palun, sisesta oma sünniaasta:");
int yearofbirth = Convert.ToInt32(Console.ReadLine());
int userage = 2021 - yearofbirth;
if (userage > 18)
    Console.WriteLine("oled piisavalt vana et juhilube saada");
else if (userage < 18)
    Console.WriteLine("oled liiga noor, vana et juhilube saada");
else
    Console.WriteLine("oledki 18, palju õnne! Hakka juhilube tegema!!!");
Console.WriteLine("Kena Päeva!");