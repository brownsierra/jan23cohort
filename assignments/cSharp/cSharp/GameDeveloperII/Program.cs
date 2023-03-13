Melee JuiceMan = new Melee("JuiceMan");
RangedFighter HotPocketMan = new RangedFighter("HotPocketMan");
MC CheeseBurgerMan = new MC("CheeseBurgerMan");

JuiceMan.PerformAttack(HotPocketMan, JuiceMan.AttackList[1]);
HotPocketMan.PerformAttack(JuiceMan, HotPocketMan.AttackList[0]);
JuiceMan.Rage(CheeseBurgerMan);
HotPocketMan.Dash();
HotPocketMan.PerformAttack(CheeseBurgerMan, HotPocketMan.AttackList[0]);
CheeseBurgerMan.PerformAttack(JuiceMan, HotPocketMan.AttackList[0]);
CheeseBurgerMan.Heal(HotPocketMan);
CheeseBurgerMan.Heal(CheeseBurgerMan);