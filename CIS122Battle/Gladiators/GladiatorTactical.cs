using System.Xml.Linq;

public class TacticalFighter : Gladiator
{
    private List<string> attackers = new();

    public TacticalFighter(int secret) : base("Bob11", secret) { }

    public override Dictionary<string, int> Attack(List<Gladiator> opponents)
    {
        Dictionary<string, int> damageMap = new();
        Random random = new();

        // Target the weakest living opponent
        Gladiator target = null;

        foreach (var opponent in opponents)
        {
            if (opponent.Health > 0)
            {
                if (target == null || opponent.Health < target.Health)
                {
                    target = opponent;
                }
            }
        }

        if (target != null)
        {
            // Damage range keeps average under 10
            int damage = random.Next(4, 11);
            damageMap[target.Name] = damage;
        }

        return damageMap;
    }

    protected override int Defense()
    {
        // Average defense well under 8
        return new Random().Next(2, 7);
    }

    public override void TrackAttacker(string attackerName)
    {
        if (!attackers.Contains(attackerName))
        {
            attackers.Add(attackerName);
        }
    }

    public override string AttackAction(string opponentName, int damage)
    {
        return $"{Name} strategically strikes {opponentName} for {damage} damage.";
    }
}
