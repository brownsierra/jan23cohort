package com.codingdojo.com.zookeeper;

import org.springframework.boot.SpringApplication;

public class GorillaTest {
	public static void main(String[] args) {
		
		Gorilla bubbles = new Gorilla();
		
		bubbles.throwSomething("a branch");
		bubbles.throwSomething("a shoe");
		bubbles.throwSomething("a comb");
		
		bubbles.eatBananas();
		bubbles.eatBananas();
		
		bubbles.climb();
		
	SpringApplication.run(ZookeeperApplication.class, args);
	}
}
