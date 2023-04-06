package com.codingdojo.burgertracker1.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.codingdojo.burgertracker1.models.Burger;
import com.codingdojo.burgertracker1.repositories.BurgerRepo;

@Service
public class BurgerServ {

	//Gets from repo exports to controller
	
	@Autowired
	private BurgerRepo burgerRepo;
//Read	
	public List<Burger> getAll(){
		return burgerRepo.findAll();
	}
	
	public Burger getOne(Long id) {
		return burgerRepo.findById(id).orElse(null);
	}
//Create
	public Burger createBurger(Burger b) {
		return burgerRepo.save(b);
	}
//Update
	public Burger updateBurger(Burger b) {
		return burgerRepo.save(b);
	}
//Delete
	public void deleteOne(Long id) {
		burgerRepo.deleteById(id);
	}
}
