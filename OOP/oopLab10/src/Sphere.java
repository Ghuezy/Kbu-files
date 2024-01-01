public class Sphere extends Shape3D{

    public Sphere(double depth, double radius){
        this.depth = depth;
        this.radius = radius;
    }

    @Override
    public double getVolume() {
        return (double) 4 / 3 * PI * radius * radius * radius;
    }

    @Override
    public double getArea() {
        return 4 * PI * radius * radius;
    }
}
