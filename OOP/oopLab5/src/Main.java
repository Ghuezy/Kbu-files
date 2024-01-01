import java.util.Arrays;

public class Main {
    public static void main(String[] args) {

        //CIRCLES

        Circle c1 = new Circle(5.0);
        Circle c2 = new Circle(10.0);
        Circle c3 = new Circle(15.0);

        Circle[] circles = {c1, c2, c3};

        for (Circle circle : circles ){
            System.out.println(circle.computeArea());
        }

        System.out.println();

        //TEACHERS

        Teacher t1 = new Teacher(1, Branch.MATH);
        Teacher t2 = new Teacher(2, Branch.PHYSICS);
        Teacher t3 = new Teacher(3, Branch.CS);
        Teacher t4 = new Teacher(4, Branch.ENG);

        Teacher[] teachers = {t1, t2, t3, t4};

        for (Teacher teacher : teachers){
            System.out.println(teacher.branch + " >> " + teacher.branch.getInfo());
        }
    }
}