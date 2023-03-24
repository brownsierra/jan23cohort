package com.codingdojo.com.zookeeper;

public class Bat extends Mammal {

	//***CONSTRUCTOR***//
	public Bat() {
		this.energyLevel = 300;
	}
	
	//***METHODS***//
		public void fly() {
			System.out.printf("\nsillybatnoise, sillybatnoise, sillybatnoise");
			energyLevel -= 50;
		}
		
		public void eatHumans(String human) {
			energyLevel += 25;
		}
		
		public void attackTown(String town) {
			System.out.println("/nSound of a town on fire");
			energyLevel -= 100;
		}
	//***GETTERS AND SETTERS***//
}
