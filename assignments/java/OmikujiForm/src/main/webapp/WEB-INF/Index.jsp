<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<!-- for forms -->
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<%@ taglib prefix = "fmt" uri = "http://java.sun.com/jsp/jstl/fmt" %>
<!-- for validation -->
<%@ page isErrorPage="true" %>
<!DOCTYPE html>
<html>
<head>
<!-- for Bootstrap CSS -->
<link rel="stylesheet" href="/webjars/bootstrap/css/bootstrap.min.css" />
<!-- YOUR own local CSS -->
<link rel="stylesheet" type="text/css" href="/css/style.css">
<!-- For any Bootstrap that uses JS -->
<script src="/webjars/bootstrap/js/bootstrap.min.js"></script>
<meta charset="UTF-8">
<title>O Form</title>
</head>
<body id="indexbody">
	<header>
		<h1>Send a Goofy Message!</h1>
	</header>
	<main>
		<form action="/updateSession" method="post">
			<section>
				<label>Pick any number from 5 to 25</label>
				<input id="counter" type="number" name="number">	
			</section>
			<section>
				<label>Enter the name of any city.</label>
				<input type="text" name="city">	
			</section>			
			<section>
				<label>Enter the name of any real person</label>
				<input type="text" name="person">	
			</section>
			<section>
				<label>Enter professional endeavor or hobby:</label>
				<input type="text" name="hobby">	
			</section>
			<section>
				<label>Enter any type of living thing.</label>
				<input type="text" name="livingThing">	
			</section>
			<section>
				<label>Say something nice to someone:</label>
				<textarea name="nice"></textarea>	
			</section>
			<span>Send and show a friend</span>
			<button>Send</button>				
		</form>
	</main>
</body>
</html>