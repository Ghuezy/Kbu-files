public class Cone extends Shape3D{

    public Cone(double height, double radius){
        this.height = height;
        this.radius = radius;
    }

    @Override
    public double getVolume() {
        return (1.0/3.0) * PI * radius * radius * height;
    }

    @Override
    public double getArea() {
        double baseArea = PI * radius * radius;
        double lateralArea = 0.5 * PI * radius * height;
        return lateralArea + baseArea;
    }
}
