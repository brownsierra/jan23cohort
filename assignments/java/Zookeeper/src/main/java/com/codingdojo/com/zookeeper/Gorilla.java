package com.codingdojo.com.zookeeper;

public class Gorilla extends Mammal{

	
	
	//*****CONSTRUCTOR*****//
	public Gorilla() {
		
	}
	
	
	//*****METHODS*****//
	public void throwSomething(String something) {
		System.out.printf("\nThe gorilla has thrown %s!", something);
		super.setEnergyLevel(super.getEnergyLevel() - 5);
	}
	
	public void eatBananas() {
		System.out.println("\nThe gorilla ate yummy banana!");
		super.setEnergyLevel(super.getEnergyLevel() + 10);
	}
	
	public void climb() {
		System.out.println("\nThe gorilla has climbed a tree!");
		super.setEnergyLevel(super.getEnergyLevel() - 10);
	}
	
	//****GETTERS & SETTERS****/
}
