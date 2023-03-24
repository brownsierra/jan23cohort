package com.codingdojo.com.zookeeper;

public class BatTest {

	public static void main(String[] args) {
		Bat bat = new Bat();
		
		System.out.println(bat.energyLevel);
		bat.attackTown("Fake Town");
		System.out.println(bat.energyLevel);
		bat.attackTown("Tale Town");
		System.out.println(bat.energyLevel);
		bat.attackTown("False Town");

		bat.eatHumans("Fake Person");
		System.out.println(bat.energyLevel);
		bat.eatHumans("Bob Builder");
		System.out.println(bat.energyLevel);
		bat.eatHumans("Not Real");
		System.out.println(bat.energyLevel);
		
		
		System.out.println(bat.energyLevel);
		bat.fly();
		System.out.println(bat.energyLevel);
		bat.fly();
		System.out.println(bat.energyLevel);
	}
}
