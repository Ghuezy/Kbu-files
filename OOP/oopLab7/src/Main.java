
public class Main {
    public static void main(String[] args) {


        //PATIENTS
        Patient p1 = new Patient("John Smith");
        Patient p2 = new Patient("Mary Smith");
        Patient p3 = new Patient("John Snow");
        Patient p4 = new Patient("Cathryn Smith");

        Patient[] patients = {p1,p2,p3,p4};

        for (Patient patient : patients){
            String patientInfo = patient.toString();
            System.out.println(patientInfo);
        }

        System.out.println();
        //SONGS AND ALBUM

        Album highwayToHell = new Album("AC/DC","Rock");
        Album mutter = new Album("Rammstein","Metal");

        Song s1 = new Song("Highway to Hell", 3.28, highwayToHell);
        Song s2 = new Song("Sonne", 4.32, mutter);



        System.out.println(highwayToHell.hasRockMusic());
        System.out.println(s1.onSameAlbum(s2));
    }
}