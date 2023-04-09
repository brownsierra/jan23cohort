package com.caresoft.clinicapp;

public class Physician extends User implements HIPAACompliantUser {

	 private ArrayList<String> patientNotes;
	
	//*****CONSTRUCTOR****//
	public Physician(Integer id) {
		this.id = id;
	}
	
	
	//*****METHODS****//
	
	 public void newPatientNotes(String notes, String patientName, Date date) {
	        String report = String.format(
	            "Datetime Submitted: %s \n", date);
	        report += String.format("Reported By ID: %s\n", this.id);
	        report += String.format("Patient Name: %s\n", patientName);
	        report += String.format("Notes: %s \n", notes);
	        this.patientNotes.add(report);
	    }
	@Override
	public boolean assignPin(int pin) {
		int lengthOfPin = String.valueOf(pin).length();
		if(lengthOfPin==4) {
			this.pin = pin;
			return true;
		}else {
			
			return false;
		}
	}

	@Override
	abstract boolean accessAuthorized(Integer confirmedAuthID) {
		if(confirmedAuthID == this.id) {
			return true;
		}
		else {
			return false;
		}
	}
	
	//****GETTERS AND SETTERS****//
	public ArrayList<String> getPatientNotes() {
		return patientNotes;
	}


	public void setPatientNotes(ArrayList<String> patientNotes) {
		this.patientNotes = patientNotes;
	}
}
