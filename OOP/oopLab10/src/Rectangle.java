public class Rectangle extends Shape2D{
    public Rectangle(double height, double width){
        this.height = height;
        this.width = width;
    }

    public double getArea(){
        return height * width;
    }
}
