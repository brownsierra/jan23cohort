Enemy JuiceMan = new Enemy("JuiceMan");

Attack JuiceBlast = new Attack("JuiceBlast",15);
Attack JuiceSnatch = new Attack("JuiceSnatch",25);
Attack JuiceThrow = new Attack("JuiceThrow",5);

JuiceMan.AttackList.Add(JuiceBlast);
JuiceMan.AttackList.Add(JuiceSnatch);
JuiceMan.AttackList.Add(JuiceThrow);

JuiceMan.RandomAttack();