// See https://aka.ms/new-console-template for more information
//programm küsib kasutaja vanust
//programm kontrollib kas kasutaja on vanem kui 13 või on 13 aastat vana
//kui kasutaja on 13 aastat vana või vanem, võib instagrammi kasutada 
//kui kasutaja on noorem kui 13, siis liiga noor
Console.WriteLine("Palun, Sisesta oma vanus");
int userAge = Convert.ToInt32(Console.ReadLine());
if (userAge > 13)
    Console.WriteLine("oled piisavalt vana instagrami jaoks");
else if (userAge < 13)
    Console.WriteLine("oled liiga noor instagrami jaoks");
else 
    Console.WriteLine("oledki 13, palju õnne! Loo endale juba instagrami konto!!");
Console.WriteLine("Kena Päeva!");