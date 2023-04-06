package com.codingdojo.burgertracker1.controllers;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import com.codingdojo.burgertracker1.models.Burger;
import com.codingdojo.burgertracker1.services.BurgerServ;

@Controller
public class HomeController {

	//Gets from service exports to the browser
	
	@Autowired
	private BurgerServ burgerServ;

	//GetMapping - Landing Page(/)
	@RequestMapping("/")
	public String index(@ModelAttribute("burger") Burger burger, Model model) {
		model.addAttribute("allBurgers", burgerServ.getAll());
		return "index.jsp";
	}
	
	@PostMapping("/makeBurger")
	public String createBurger(@Valid @ModelAttribute("burgerForm") Burger newBurger, BindingResult result, Model model) {
		if(result.hasErrors()) {
			return "index.jsp";
		}
		else {
			burgerServ.createBurger(newBurger);
			return "redirect:/";
		}
	}
	
	@GetMapping("/burger/{id}/edit")
	public String editBurger(@PathVariable("id") Long id, @ModelAttribute("burgerEditForm") Burger b, Model model) {
		
		model.addAttribute("b", burgerServ.getOne(id));
		
		return "editBurger.jsp";
	}
	
	@PutMapping("/burger/{id}/update")
	public String updateBurger(@PathVariable("id") Long id, @Valid @ModelAttribute("burgerEditForm") Burger b, BindingResult result, Model model) {
		
		if(result.hasErrors()) {
			model.addAttribute("b", burgerServ.getOne(id));
			return "editBurger.jsp";
		} else {
			burgerServ.updateBurger(b);
			return "redirect:/";
		}
	}
}

