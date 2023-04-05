package com.codingdojo.com.bankaccount;

public class BankAccount {

	private double checkingBalance;
	private double savingsBalance;
	private static int numOfAccounts;
	private static double totalAmountEveryAcct;
	private long accountNumber;
	
	//*****CONSTRUCTOR*****//
	
	public BankAccount(double checkingBalance, double savingsBalance, long accountNumber) {
		this.checkingBalance = checkingBalance;
		this.savingsBalance = savingsBalance;
		this.accountNumber = accountNumber;
		numOfAccounts++;
	}
	
	//*****METHODS*****//
//	Create a method that will allow a user to deposit money into either the checking or saving, be sure to add to total amount stored.
	public double depositMoney(String acctType, double deposit) {
		if(acctType == "Checking") {
			checkingBalance+= deposit;
		}
		else if(acctType == "Savings") {
			savingsBalance+= deposit;
		}
		totalAmountEveryAcct+= deposit;
		return totalAmountEveryAcct;
	}
	
//	Create a method to withdraw money from one balance. Do not allow them to withdraw money if there are insufficient funds.
	public double withdrawFunds(double withdrawalAmount) {
		if(checkingBalance >= withdrawalAmount) {
			checkingBalance-= withdrawalAmount;
		}
		else {
			System.out.println("Insufficient funds");
		}
		return checkingBalance;
	}
	
//	Create a method to see the total money from the checking and saving.
	public double totalAmountCAndS() {
		System.out.printf("\nThe total amount of funds in Checking and Savings is: %s", totalAmountEveryAcct);
		return totalAmountEveryAcct;
	}

	//*****GETTERS AND SETTERS*****//

	public double getCheckingBalance() {
		return checkingBalance;
	}

	public double getSavingsBalance() {
		return savingsBalance;
	}

	
	
}
