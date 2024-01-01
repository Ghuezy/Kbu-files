public abstract class Shape2D {
    protected final double PI = 3.141519;
    protected double height;
    protected double radius;
    protected double width;

    public Shape2D(double height, double width){
        this.height = height;
        this.width = width;
    }

    public Shape2D(double radius){
        this.radius = radius;
    }

    public Shape2D() {}

    public abstract double getArea();

    @Override
    public String toString() {
        return "Shape2D{" +
                ", height=" + height +
                ", radius=" + radius +
                ", width=" + width +
                '}';
    }
}
