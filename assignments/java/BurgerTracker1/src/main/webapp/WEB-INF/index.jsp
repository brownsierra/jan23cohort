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
<title>Burger Tracker</title>
</head>
<body>
	<header>
		<h1>Burger Tracker</h1>
	</header>
	<main>
		<table>
			<tr>
				<th>Burger Name</th>
				<th>Restaurant Name</th>
				<th>Rating(out of 5)</th>
				<th>Action</th>
			</tr>
			<c:forEach var="burger" items="${allBurgers}">
				<tr>
					<td><c:out value="${burger.burgerName}"></c:out></td>
					<td><c:out value="${burger.restaurantName}"></c:out></td>
					<td><c:out value="${burger.rating}"></c:out></td>
					<td><a href="/burger/${burger.id}/edit">edit</a></td>
				</tr>
			</c:forEach>
		</table>
		<div id="bottomofmain">
			<h2>Add a burger:</h2>
			<h5>Notes must not be blank</h5>
			<form:form action="/makeBurger" method="post" modelAttribute="burgerForm">
				<section>
					<label for="burgerName">Burger Name</label>
					<input type="text" name="burgerName" />
					<form:errors path="burgerName" class="text-warning"/>
				</section>
				<section>
					<label for="restaurantName">Restaurant Name</label>
					<input type="text" name="restaurantName" />
					<form:errors path="restaurantName" class="text-warning"/>
				</section>
				<section>
					<label for="rating">Rating</label>
					<input type="number" name="rating" />
					<form:errors path="rating" class="text-warning"/>
				</section>
				<section>
					<label for="note">Notes</label>
					<input type="text" name="note" value="${burger.note}"/>
					<form:errors path="note" class="text-warning"/>
				</section>
				<button>Submit</button>
			</form:form>
		</div>
	</main>
</body>
</html>