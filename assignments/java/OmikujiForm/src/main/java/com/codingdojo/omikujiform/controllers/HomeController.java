package com.codingdojo.omikujiform.controllers;

import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller

public class HomeController {

	@RequestMapping("/omikuji")
	public String index() {
		return "Index.jsp";
	}
	
	@PostMapping("/updateSession")
	public String updateSession(
			@RequestParam(value="number") Integer number,
			@RequestParam(value="city") String city,
			@RequestParam(value="person") String person,
			@RequestParam(value="hobby") String hobby,
			@RequestParam(value="livingThing") String livingThing,
			@RequestParam(value="nice") String nice,
			Model model,
			HttpSession session) {
		session.setAttribute("number", number);
		session.setAttribute("city", city);
		session.setAttribute("person", person);
		session.setAttribute("hobby", hobby);
		session.setAttribute("livingThing", livingThing);
		session.setAttribute("nice", nice);
		return "redirect:/omikuji/show";
	}
	@RequestMapping("/omikuji/show")
	public String show(HttpSession session) {
		return "BlueBoxPage.jsp";
	}
}
