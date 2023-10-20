import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Worker w1 = new Worker();
        Worker w2 = new Worker();
        Worker w3 = new Worker();

        //Worker 1
        w1.name = "Clark Kent";
        w1.socialSecurityNumber = 65213875;
        w1.wage = 1500.0f;
        w1.workingHours = 40;

        w1.displayInfo(w1);
        w1.displaySalary(w1);
        
        //Worker 2
        System.out.print("Enter a worker name : ");
        w2.name = scanner.nextLine();
        System.out.print("Enter worker's social security number : ");
        w2.socialSecurityNumber = scanner.nextInt();
        System.out.print("Enter worker's wage : ");
        w2.wage = scanner.nextFloat();
        System.out.print("How many hours the worker work : ");
        w2.workingHours = scanner.nextInt();

        w2.displayInfo(w2);
        w2.displaySalary(w2);

        //Worker 3
        w3.getInfo(w3);

        w3.displayInfo(w3);
        w3.displaySalary(w3);
    }
}