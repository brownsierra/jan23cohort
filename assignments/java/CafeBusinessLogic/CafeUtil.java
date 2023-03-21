// package Greetings.jan23cohort.assignments.java.CafeBusinessLogic;
import java.util.ArrayList;

public class CafeUtil {

    public int getStreakGoal(int numWeeks) {
        int sum = 0;
        for(int i = 1; i <= numWeeks; i++) {
            sum += i;
        }
        return sum;
    }

    public double getOrderTotal(double[] prices) {
        int sumOfPrices = 0;
        for(double price: prices) {
            sumOfPrices += price;
        }
        return sumOfPrices;
    }

    void displayMenu(ArrayList<String> menuItems) {
        for(String item: menuItems) {
            System.out.println(menuItems.indexOf(item) + " "+ item);
        }
    }

    
    public void addCustomer(ArrayList<String> customers) {
        System.out.println("Please print your name:");
        String userName = System.console().readLine();
        System.out.printf("Hello %s!", userName);
        System.out.printf("\nThere are %s people in front of you\n", customers.size());
        customers.add(userName);
        System.out.println(customers);
    }

} 
