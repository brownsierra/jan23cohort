class MC : Enemy {
    public MC(string Name) : base(Name) {
    Health = 80;
    base.AttackList.Add(new Attack("Fireball",25));
    base.AttackList.Add(new Attack("Lightning Bolt",20));
    base.AttackList.Add(new Attack("Staff Strike",10));
}
public void Heal(Enemy Target) {
    Target.Health += 40;
    Console.WriteLine($"{Name} has healed {Target.Name}!! Their new health is {Target.Health}!!");
}
}