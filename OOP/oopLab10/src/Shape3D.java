public abstract class Shape3D extends Shape2D{
    protected double depth;

    public Shape3D(){}
    public Shape3D(double depth, double height, double width){
        this.depth = depth;
        this.height = height;
        this.width = width;
    }

    public Shape3D(double height, double radius){
        this.height = height;
        this.radius = radius;
    }

    public abstract double getVolume();

    @Override
    public String toString() {
        return "Shape3D{" +
                "depth=" + depth +
                ", height=" + height +
                ", radius=" + radius +
                ", width=" + width +
                '}';
    }
}
