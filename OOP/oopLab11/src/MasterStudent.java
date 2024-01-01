public class MasterStudent extends Student implements ConforenceScoreBehaviour{

    int numOfConf;
    public MasterStudent(int id, float mid, float fin, int numOfConf) {
        super(id, mid, fin, numOfConf);
    }

    @Override
    float computeTotalScore(){
        return 0;
    }

    @Override
    public float conferenceScore(){
        return 1;
    }
}
