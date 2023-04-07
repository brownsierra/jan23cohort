package com.codingdojo.savetravels.repositories;

import java.util.List;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import com.codingdojo.savetravels.models.Expense;


@Repository
public interface ExpenseRepo extends CrudRepository<Expense, Long> {

	//Gets from Model exports to service
	
	List<Expense> findAll();
}
