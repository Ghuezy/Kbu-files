public enum Branch {
    MATH("information regards math"),
    PHYSICS("information regards physics"),
    CS("information regards cs"),
    ENG("information regards eng");

    private final String info;

    Branch(String info) {
        this.info = info;
    }

    public String getInfo() {
        return info;
    }
}
