public class Circle extends Shape2D{

    public Circle(double radius){
        this.radius = radius;
    }

    public double getArea(){
        return PI * radius * radius;
    }
}
