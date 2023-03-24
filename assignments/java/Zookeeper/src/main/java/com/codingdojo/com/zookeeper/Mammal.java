package com.codingdojo.com.zookeeper;

public class Mammal {
	protected int energyLevel;
	
	
	//*****CONSTRUCTOR*****//
	public Mammal() {
		this.energyLevel = 100;
	}
	
	
	
	//*****METHODS*****//
	public int displayEnergy() {
		System.out.printf("/nThe gorilla's energy level is %s", energyLevel);
		return energyLevel;
	}
	
	
	
	//****GETTERS & SETTERS****/
	public int getEnergyLevel() {
		return energyLevel;
	}



	public void setEnergyLevel(int energyLevel) {
		this.energyLevel = energyLevel;
	}
}
