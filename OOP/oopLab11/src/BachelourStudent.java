public class BachelourStudent extends Student implements ProjectScoreBehaviour{


    public BachelourStudent(int id, float mid, float fin, int numOfConf) {
        super(id, mid, fin, numOfConf);
    }

    @Override
    public float projectScore() {
        return ProjectScoreBehaviour.super.projectScore();
    }

    @Override
    float computeTotalScore() {
        return 0;
    }
}
