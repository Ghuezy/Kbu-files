
public class Main {
    public static void main(String[] args) {

        //CIRCLES
        Circle circle1 = new Circle(5.0);
        Circle circle2 = new Circle(10.0,"blue");
        Circle circle3 = new Circle();

        Circle[] circles = {circle1,circle2,circle3};

        for (Circle circle : circles){
            System.out.println(circle.getRadius());
            System.out.println(circle.getColor());
            System.out.println(circle.getArea());
            System.out.println(circle.toString());
            System.out.println();
        }

        //CYLINDERS
        Cylinder cylinder1 = new Cylinder(5.0);
        Cylinder cylinder2 = new Cylinder(10.0,5.0);
        Cylinder cylinder3 = new Cylinder(15.0, 15,"green");

        Cylinder[] cylinders = {cylinder1,cylinder2,cylinder3};

        for (Cylinder cylinder : cylinders){
            System.out.println(cylinder.getRadius());
            System.out.println(cylinder.getColor());
            System.out.println(cylinder.getHeight());
            System.out.println(cylinder.getVolume());
            System.out.println(cylinder.toString());
            System.out.println();
        }

        //POINT2D

        Point2D point2D1 = new Point2D();
        Point2D point2D2 = new Point2D(2,3);

        Point2D[] point2DS = {point2D1,point2D2};

        for (Point2D point2D : point2DS){
            System.out.println(point2D.getX());
            System.out.println(point2D.getY());
            System.out.println(point2D.toString());
            System.out.println();
        }

        //POINT3D
        Point3D point3D1 = new Point3D();
        Point3D point3D2 = new Point3D(2,4,5);

        Point3D[] point3DS = {point3D1,point3D2};

        for (Point3D point3D : point3DS){
            System.out.println(point3D.getX());
            System.out.println(point3D.getY());
            System.out.println(point3D.getZ());
            System.out.println(point3D.toString());
            System.out.println();
        }

    }
}