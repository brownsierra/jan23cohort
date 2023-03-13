class RangedFighter : Enemy {
    public int Distance;
    public RangedFighter(string Name) : base(Name) {
        Distance = 5;
        base.AttackList.Add(new Attack ("Shoot an Arrow",20));
        base.AttackList.Add(new Attack ("Throw a Knife",15));
        
    }
    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if(Distance < 10) {
            base.PerformAttack(Target, ChosenAttack);
        }
    }
    public void Dash() {
        Distance = 20;
        Console.WriteLine($"{Name} has performed a dash!! Setting their distance to 20!");
    }
}