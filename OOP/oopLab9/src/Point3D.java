public class Point3D extends Point2D{
    private int z = 0;

    public Point3D() {}

    public Point3D(int x, int y,int z) {
        this.z = z;
    }

    public int getZ() {
        return z;
    }

    public void setZ(int z) {
        this.z = z;
    }

    @Override
    public String toString() {
        return "Point2D{" +
                "x=" + getX() +
                ", y=" + getY() +
                ", z=" + z +
                '}';
    }
}
