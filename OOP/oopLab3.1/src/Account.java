import java.util.Scanner;
public class Account {
    private double balance;
    private String  accountName;


    Account(String name, double balance){
        this.accountName = name;
        this.balance = balance;
    }

    public void Add(double amount){balance += amount;}

    public double getBalance(){
        return balance;
    }

    public void setOwnerName(String name){ accountName = name; }

    public String getOwnerName(){ return accountName; }

    public void withdraw(double amount){
        final int accPass = 1234;

        Scanner scanner = new Scanner(System.in);
        System.out.print("Please enter password : ");
        int pass = scanner.nextInt();
        int tries = 0;

        while (tries < 3){

            if (accPass == pass){
                if (amount > balance){
                    System.out.println("Not enough money in account");
                } else {
                    balance -= amount;
                }
                break;
            } else {
                System.out.print("Wrong password. Try again : ");
                pass = scanner.nextInt();
                tries++;
            }

        }
        if (tries == 3){
            System.out.println("Your account is blocked.");
        }
    }
}
