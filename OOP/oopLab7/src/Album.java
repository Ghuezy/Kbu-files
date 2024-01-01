public class Album {
    String artistName;
    String genre;

    public Album(String artistName, String genre){
        this.artistName = artistName;
        this.genre = genre;
    }

    public boolean hasRockMusic(){
        return this.genre.equalsIgnoreCase("Rock");
    }
}
