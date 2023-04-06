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
<title>Insert title here</title>
</head>
<body>
	<header>
		<h1>Edit Burger</h1>
		<a id="goback" href="/"><h5>Go back</h5></a>
	</header>
	<main>
		<form:form action="/burger/${b.id}/update" method="post" modelAttribute="burgerEditForm">
			<input type="hidden" name="_method" value="put"/>
			<section>
				<label for="burgerName">Burger Name</label>
				<input type="text" name="burgerName" value="${ b.burgerName }"/>
				<form:errors path="burgerName" class="text-warning"/>
			</section>
			<section>
				<label for="restaurantName">Restaurant Name</label>
				<input type="text" name="restaurantName" value="${ b.restaurantName }"/>
				<form:errors path="restaurantName" class="text-warning"/>
			</section>
			<section>
				<label for="rating">Rating</label>
				<input type="number" name="rating" value="${ b.rating }"/>
				<form:errors path="rating" class="text-warning"/>
			</section>
			<section>
				<label for="note">Notes</label>
				<input type="text" name="note" value="${ b.note }"/>
				<form:errors path="note" class="text-warning"/>
			</section>
			<button>Submit</button>
		</form:form>
	</main>
</body>
</html>