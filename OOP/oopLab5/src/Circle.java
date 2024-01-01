public class Circle {
    private final double PI = 3.141519;
    private double radius;

    public Circle(Double radius){
        this.radius = radius;
    }

    public double computeArea(){
        return PI * radius * radius ;
    }
}
