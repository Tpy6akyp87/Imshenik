using Learn;

//Game game = new Game("Diablo","Blizzard", 25);
//Rpg rpg = new Rpg("Didi","Blili", 23);
var games = new Game[] {new Rpg("Dia","Blizozo",31) , new Arpg("Hots", "Blizozo", 2)};
foreach (var game in games)
{
    game.Preparation();
}