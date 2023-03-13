//Create a loop that prints all values from 1-255.
for (int i = 1; i <=255; i++) {
	Console.WriteLine(i);
}


int y = 1;
while(y <=255)
{
	Console.WriteLine(y);
	y++;
}


// //Create a new loop that generates 5 random numbers between 10 and 20.
Random num = new Random();
for (int s = 1; s <=5; s++) {
	Console.WriteLine(num.Next(10,21));
    }

int k = 1;
while (k <=5) {
    Console.WriteLine(num.Next(10,21));
    k++;
}

// //Modify the previous loop to add the random values together and print the sum after the loop finishes.
Random numtwo = new Random();
int sum = 0;
for (int b = 1; b <=5; b++) {
	sum = sum + numtwo.Next(10,21);
}
	Console.WriteLine(sum);

int c = 1;
while (c <=5) {
    sum = sum + numtwo.Next(10,21);
    c++;
}
    Console.WriteLine(sum);


// // Create a new loop that prints all values from 1 to 100 that are divisible by 3 OR 5, but NOT both.
for (int d = 1; d<=100; d++) {
	if (d % 3 == 0 && d % 5 == 0) {
		continue;
}
    else if (d % 5 == 0 || d % 3 ==0) {
        Console.WriteLine(d);
    }
}



// // Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5.
for (int d = 1; d<=100; d++) {
            if (d % 3 == 0 && d % 5 == 0) {
                continue;
        }
            else if (d % 3 == 0 && d % 5 != 0) {
        Console.WriteLine("Fizz");
    }
    else if (d % 5 == 0 && d % 3 != 0) {
        Console.WriteLine("Buzz");       
    }
}

int h = 1;
while (h <= 100) {
    if (h % 3 == 0 && h % 5 != 0) {
	    Console.WriteLine("Fizz");
}
    else if (h % 5 == 0) {
        Console.WriteLine("Buzz");
    }
    h++;
}



// // // Modify the previous loop once more to now also print "FizzBuzz" for numbers that are multiples of both 3 and 5.
for (int d = 1; d<=100; d++) {
            if (d % 3 == 0 && d % 5 == 0) {
                Console.WriteLine("FizzBuzz");
        }
            else if (d % 3 == 0 && d % 5 != 0) {
        Console.WriteLine("Fizz");
    }
    else if (d % 5 == 0 && d % 3 != 0) {
        Console.WriteLine("Buzz");       
    }
}

