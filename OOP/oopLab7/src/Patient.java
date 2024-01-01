public class Patient {

    private int patientID;
    private String name;
    private static int counter;


    public Patient(String name){
        this.patientID = ++counter;
        this.name = name;
    }

    public String getName(){
        return name;
    }

    public int getPatientID(){
        return patientID;
    }


    @Override
    public String toString() {
        return name + " " + patientID;
    }
}
