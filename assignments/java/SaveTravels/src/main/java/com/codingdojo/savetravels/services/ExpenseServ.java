package com.codingdojo.savetravels.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.codingdojo.savetravels.models.Expense;
import com.codingdojo.savetravels.repositories.ExpenseRepo;

@Service
public class ExpenseServ {
	@Autowired
	private ExpenseRepo expenseRepo;
	
    // ==========================
    //         METHODS
    // ==========================
	
//	Read
	public List<Expense> getAll() {
		return expenseRepo.findAll();
	}
	
	public Expense getOne(Long id) {
		return expenseRepo.findById(id).orElse(null);
	}
	
//	Create
	public Expense createExpense(Expense e) {
		return expenseRepo.save(e);
	}
	
//	Update
	public Expense updateExpense(Expense e) {
		return expenseRepo.save(e);
	}
	
//	Delete
	public void deleteOne(Long id) {
		expenseRepo.deleteById(id);
	}
}
