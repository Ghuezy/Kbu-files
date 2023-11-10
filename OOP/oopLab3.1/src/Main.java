
public class Main {
    public static void main(String[] args) {
        Account a1 = new Account("john kennedy",500.0);

        System.out.println(a1.getOwnerName());
        a1.setOwnerName("ronald reagan");
        System.out.println(a1.getOwnerName());
        System.out.println(a1.getBalance());
        a1.Add(100.0);
        System.out.println(a1.getBalance());
        a1.withdraw(50);
        System.out.println(a1.getBalance());
    }
}