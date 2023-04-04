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
<title>Joke</title>
</head>
<body>
	<header>
		<h1>Here's Your Joke</h1>
	</header>
	<main>
		<p>
			In <c:out value="${ number }"/> years, we hope you may live in <c:out value="${ city }"></c:out> with <c:out value="${ person }"></c:out> as your roommate, selling <c:out value="${ hobby }"></c:out> for a living. The next time you see a <c:out value="${ livingThing }"></c:out>, laugh out loud. Also, this is a joke, so <c:out value="${ nice }"/>.
		</p>
		<a href="/omikuji">Go back</a>
	</main>
</body>
</html>
</html>