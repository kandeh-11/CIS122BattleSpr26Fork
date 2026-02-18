public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Thunder Dome!");

        var arena = new Arena();

        int secret = new Random().Next(1000, 9999);
        var bob1 = new GlitterWarrior(secret);
        arena.RegisterGladiator(bob1, secret);

        secret = new Random().Next(1000, 9999);
        var bob2 = new GlitterWarrior2(secret);
        arena.RegisterGladiator(bob2, secret);

        secret = new Random().Next(1000, 9999);
        var bob3 = new GlitterWarrior3(secret);
        arena.RegisterGladiator(bob3, secret);

        secret = new Random().Next(1000, 9999);
        var bob4 = new TacticalFighter(secret);
        arena.RegisterGladiator(bob4, secret);

        Console.WriteLine("Ready to Fight!");
        Console.WriteLine("3");
        Console.WriteLine("2");
        Console.WriteLine("1");

        arena.StartBattle();

    }
}