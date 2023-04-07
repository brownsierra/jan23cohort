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
<title>Save Travels</title>
</head>
<body>
	<header>
		<h1 class="blueheader">Save Travels</h1>
	</header>
    <main>
    	<table>
    		<tr>
    			<th>Expenses</th>
    			<th>Vendor</th>
    			<th>Amount</th>
    			<th>Actions</th>
    		</tr>
    		<c:forEach var="expense" items="${allExpenses}">
				<tr>
					<td><a href="/expenses/${expense.id}"><c:out value="${expense.name}"></c:out></a></td>
					<td><c:out value="${expense.vendor}"></c:out></td>
					<td><c:out value="${expense.amount}"></c:out></td>
					<td><a href="/expenses/edit/${expense.id}" class="btn btn-primary">edit</a></td>
					<td><a href="expenses/${expense.id}/delete" class="btn btn-danger">Delete</a></td>
				</tr>
			</c:forEach>
    	</table>
    	<div class="expenseForm">
    		<h2>Add an expense</h2>
    		<form:form action="/makeExpense" method="post" modelAttribute="expenseForm" >
				<section>
					<label for="name">Expense Name:</label>
					<input type="text" name="name" />
					<form:errors path="name" class="text-warning"/>
				</section>
				<section>
					<label for="vendor">Vendor:</label>
					<input type="text" name="vendor" />
					<form:errors path="vendor" class="text-warning"/>
				</section>
				<section>
					<label for="amount">Amount:</label>
					<input type="number" step="0.01" name="amount" />
					<form:errors path="amount" class="text-warning"/>
				</section>
				<section>
					<label for="description">Description:</label>
					<textarea name="description" id=""></textarea>
					<form:errors path="description" class="text-warning"/>
				</section>
				<button>Submit</button>
			</form:form>
    	</div>
    </main>
    <footer>
    
    </footer>
</body>
</html>