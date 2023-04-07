package com.codingdojo.savetravels.controllers;

import javax.servlet.http.HttpSession;
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

import com.codingdojo.bookclub.models.Book;
import com.codingdojo.savetravels.models.Expense;
import com.codingdojo.savetravels.services.ExpenseServ;

@Controller
public class HomeController {
	
	@Autowired
	private ExpenseServ expenseServ;
	
	@GetMapping("/")
	public String index() {
		
		return "redirect:/expenses";
	}
	
	@GetMapping("/expenses")
	public String expensesPage(@ModelAttribute("expense") Expense expense, Model model) {
		model.addAttribute("allExpenses", expenseServ.getAll());
		return "index.jsp";
	}
	
	@PostMapping("/makeExpense")
	public String createExpense(@Valid @ModelAttribute("expenseForm") Expense newExpense, BindingResult result, Model model) {
		if(result.hasErrors()) {
			return "index.jsp";
		}
		else {
			expenseServ.createExpense(newExpense);
			return "redirect:/expenses";
		}
	}
	
	@GetMapping("/expenses/edit/{id}")
	public String editExpense(@PathVariable("id") Long id, @ModelAttribute("expenseEditForm") Expense e, Model model) {
		
		model.addAttribute("e", expenseServ.getOne(id));
		
		return "editExpense.jsp";
	}
	
	@PutMapping("/expenses/update/{id}")
	public String updateExpense( @PathVariable("id") Long id, @Valid @ModelAttribute("expenseEditForm") Expense e, BindingResult result, Model model) {
		
		if(result.hasErrors()) {
			model.addAttribute("e", expenseServ.getOne(id));
			return "editExpense.jsp";
		} else {
			expenseServ.updateExpense(e);
			return "redirect:/expenses";
		}
	}
	
	@GetMapping("/expenses/{id}")
	public String viewBook(HttpSession session, @PathVariable("id") Long id, @ModelAttribute("expense") Expense expense, Model model) {
		model.addAttribute("theExpense", expenseServ.getOne(id));
		return "viewExpense.jsp";
		
	}
	
	@GetMapping("expenses/{id}/delete")
	public String deleteExpense(@PathVariable("id") Long id) {
		expenseServ.deleteOne(id);
		return "redirect:/expenses";
	}
}
