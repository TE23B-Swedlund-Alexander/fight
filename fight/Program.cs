Random rnd = new Random();
int dålig = 50;
int bra = 50;
int punch = 0;
int punch2 = 0;
int round = 0;
Console.WriteLine("start fight");
Console.ReadLine();
while (dålig > 0 & bra > 0)
{
    round++;
    Console.WriteLine($"round{round}");
    Console.WriteLine();
    punch = rnd.Next(1, 10);
    punch2 = rnd.Next(1, 10);
    Console.WriteLine("you punch child");
    dålig -= punch;
    Console.WriteLine($"child hp = {dålig}");
    Console.WriteLine();
    Console.WriteLine("child punch you");
    bra -= punch2;
    Console.WriteLine($"your hp = {bra}");
    Console.ReadLine();
}
if(dålig > bra){
Console.WriteLine("you lose");
}
if(dålig == bra){
 Console.WriteLine("tie");   
}
if(dålig < bra){
Console.WriteLine("you win");
}
Console.ReadLine();