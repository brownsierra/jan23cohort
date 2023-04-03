package com.codingdojo.daikichiroutes2.controllers;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class DaikichiController {

	@RequestMapping("/daikichi")
	public String daikichi() {
		return "Welcome";
	}
	
	@RequestMapping("daikichi/today")
	public String today() {
		return "I pray you receive a blessing today!";
	}
	
	@RequestMapping("daikichi/tomorrow")
	public String tomorrow() {
		return "I pray a new opportunity arises tomorrow!";
	}
}