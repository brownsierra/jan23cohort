package com.codingdojo.com.bankaccount;

public class TestBankAccount {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		BankAccount sierra = new BankAccount(250.50, 700.32, 1111111);
		BankAccount brianna = new BankAccount(4000.23, 900.80, 222222);
		BankAccount dana = new BankAccount(654.43, 9374.90, 333333);
		BankAccount ubin = new BankAccount(242.23, 43355.32, 4444444);
		BankAccount katie = new BankAccount(535.87, 937.38, 555555);
		BankAccount lizette = new BankAccount(6435.97, 1242.43, 666666);
		
//		System.out.println(sierra.getSavingsBalance());
		sierra.depositMoney("Savings", 5000);
//		System.out.println(sierra.getSavingsBalance());
		
//		System.out.println(katie.getCheckingBalance());
		katie.depositMoney("Checking", 7500.45);
//		System.out.println(katie.getCheckingBalance());
		
		
//		System.out.println(dana.getCheckingBalance());
		dana.withdrawFunds(500.50);
//		System.out.println(dana.getCheckingBalance());
		
		ubin.totalAmountCAndS();
		
		
	}

}
