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
		<h1>Edit Expense</h1>
		<h3><a href="/expenses">Go Back</a></h3>		
	</header>
    <main class="expenseForm">
    	<form:form action="/expenses/update/${ e.id }" method="post" modelAttribute="editExpenseForm">
    		<input type="hidden" name="_method" value="put"/>
    		<section>
    			<label for="name">Expense Name:</label>
    			<input type="text" name="name" id="" value="${ e.name }"/>
    			<form:errors path="name" class="text-danger" />
    		</section>
    		<section>
    			<label for="vendor">Vendor:</label>
    			<input type="text" name="vendor" id="" value="${ e.vendor }" />
    			<form:errors path="vendor" class="text-danger" />
    		</section>
    		<section>
					<label for="amount">Amount:</label>
					<input type="number" step="0.01" name="amount" value="${e.amount }"/>
					<form:errors path="amount" class="text-warning"/>
				</section>
				<section>
	    			<label for="description">Description:</label>
	    			<textarea  name="description" id="">"${e.description}"</textarea>
	    			<form:errors path="description" class="text-danger" />
    			</section>
    		<section>
    			<input type="hidden" name="poster" value="${ user_id }" />
    		</section>
    		<button>Submit</button>
    	</form:form>
    </main>
    <footer>
    
    </footer>
</body>
</html>