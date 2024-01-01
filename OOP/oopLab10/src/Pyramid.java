public class Pyramid extends Shape3D{

    public Pyramid(double depth, double height, double width){
        this.depth = depth;
        this.height = height;
        this.width = width;
    }

    @Override
    public double getVolume() {
        return (double) 1 / 3 * height * width * depth;
    }

    @Override
    public double getArea() {
        return (height * width) + (double) 1 / 2 * (2 * (height + width));
    }
}
