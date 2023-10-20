import java.util.Scanner;

public class Worker {
    String name;
    int socialSecurityNumber;
    float wage;
    int workingHours;

    void displayInfo(Worker worker){
        System.out.printf("%s%n%d%n", worker.name, worker.socialSecurityNumber);
    }

    void displaySalary(Worker worker){
        float salary = worker.wage * worker.workingHours;
        System.out.println(salary);
    }

    void getInfo(Worker worker){
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter a worker name : ");
        worker.name = scanner.nextLine();
        System.out.print("Enter worker's social security number : ");
        worker.socialSecurityNumber = scanner.nextInt();
        System.out.print("Enter worker's wage : ");
        worker.wage = scanner.nextFloat();
        System.out.print("How many hours the worker work : ");
        worker.workingHours = scanner.nextInt();
    }
}
