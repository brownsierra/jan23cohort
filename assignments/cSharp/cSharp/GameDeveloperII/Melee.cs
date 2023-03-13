class Melee : Enemy {
    public Melee(string Name) : base(Name) {
    Health = 120;
    base.AttackList.Add(new Attack("Punch",20));
    base.AttackList.Add(new Attack("Kick",15));
    base.AttackList.Add(new Attack("Tackle",25));
}
public void Rage(Enemy target)
{
    Attack randomAttack = base.RandomAttack();
    randomAttack.DamageAmount += 10;
    base.PerformAttack(target, randomAttack);
    randomAttack.DamageAmount -= 10;
    Console.WriteLine($"{Name} has raged!! This attack has dealt 10 extra damage on {target}!");
}
}
