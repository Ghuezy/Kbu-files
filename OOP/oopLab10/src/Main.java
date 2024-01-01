
public class Main {
    public static void main(String[] args) {

        System.out.println();

        Circle circle = new Circle(3.0);
        System.out.println(circle.getArea());
        System.out.println(circle.toString());
        System.out.println();

        Square square = new Square(5.0);
        System.out.println(square.getArea());
        System.out.println(square.toString());
        System.out.println();

        Rectangle rectangle = new Rectangle(5.0,2.0);
        System.out.println(rectangle.getArea());
        System.out.println(rectangle.toString());
        System.out.println();

        Cylinder cylinder = new Cylinder(5.0,3.0);
        System.out.println(cylinder.getArea());
        System.out.println(cylinder.getVolume());
        System.out.println(cylinder.toString());
        System.out.println();

        Sphere sphere = new Sphere(5.0, 2.0);
        System.out.println(sphere.getArea());
        System.out.println(sphere.getVolume());
        System.out.println(sphere.toString());
        System.out.println();

        Pyramid pyramid = new Pyramid(5.0,2.0,3.0);
        System.out.println(pyramid.getArea());
        System.out.println(pyramid.getVolume());
        System.out.println(pyramid.toString());
        System.out.println();

        Cone cone = new Cone(5.0,2.0);
        System.out.println(cone.getArea());
        System.out.println(cone.getVolume());
        System.out.println(cone.toString());
    }
}