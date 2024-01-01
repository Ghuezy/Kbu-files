public class Cylinder extends Shape3D{

    public Cylinder(double height, double radius){
        this.height = height;
        this.radius = radius;
    }

    public double getVolume(){
        return PI * radius * radius * height;
    }

    public double getArea(){
        return 2 * PI * radius * height + 2 * PI * radius * radius;
    }
}
