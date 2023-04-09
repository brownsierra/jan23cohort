package com.caresoft.clinicapp;

import java.util.ArrayList;
import java.util.Date;

public class AdminUser extends User implements HIPAACompliantUser,HIPAACompliantAdmin {

    private Integer employeeID;
    private String role;
    private ArrayList<String> securityIncidents = new ArrayList<String>();
    
    //*****CONSTRUCTOR****//
    public AdminUser(int id, String role) {
    	this.employeeID = id;
    	this.role = role;
 
    }
    
    
	//*****METHODS****//
	@Override
	public boolean assignPin(int pin) {
		// TODO Auto-generated method stub
		int lengthOfPin = String.valueOf(pin).length();
		if(lengthOfPin==6) {
			this.pin = pin;
			return true;
		}else {
			
			return false;
		}
		
	}
	
	@Override
	public boolean accessAuthorized(Integer confirmedAuthID) {
		// TODO Auto-generated method stub
		
		if(this.id != confirmedAuthID) {
			this.authIncident();
			return false;
		}else {
			return true;
			
		}
	}
	
    // TO DO: Implement a constructor that takes an ID and a role

    
    public void newIncident(String notes) {
        String report = String.format(
            "Datetime Submitted: %s \n,  Reported By ID: %s\n Notes: %s \n", 
            new Date(), this.id, notes
        );
        securityIncidents.add(report);
    }
    public void authIncident() {
        String report = String.format(
            "Datetime Submitted: %s \n,  ID: %s\n Notes: %s \n", 
            new Date(), this.id, "AUTHORIZATION ATTEMPT FAILED FOR THIS USER"
        );
        securityIncidents.add(report);
    }
	@Override
	public ArrayList<String> reportSecurityIncidents() {
		// TODO Auto-generated method stub
		return this.securityIncidents;
	}
}
