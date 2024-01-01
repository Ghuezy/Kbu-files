public class Song {
    String title;
    double lenInSec;
    Album onAlbum;

    public Song(String title, double lenInSec, Album onAlbum){
        this.title = title;
        this.lenInSec = lenInSec;
        this.onAlbum = onAlbum;
    }

    public boolean onSameAlbum( Song song2){
        return this.onAlbum == song2.onAlbum;
    }
}
