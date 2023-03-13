    public class Enemy {
    public string Name;
    public int Health;
    public List<Attack> AttackList;

    public Enemy(string name) {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }
    public Attack RandomAttack() {
    Random rand = new Random();
    int i = rand.Next(AttackList.Count);
    Console.WriteLine(AttackList[i].Name);
    return AttackList[i];
    }
    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        Target.Health -= ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }
    }