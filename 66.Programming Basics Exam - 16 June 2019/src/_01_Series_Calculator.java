import java.util.Scanner;

public class _01_Series_Calculator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String serial = scanner.nextLine();
        int seasons = Integer.parseInt(scanner.nextLine());
        int countEpisode = Integer.parseInt(scanner.nextLine());
        double episodeTimeWithAdvertisement  = Double.parseDouble(scanner.nextLine());

        double time = episodeTimeWithAdvertisement  * 1.2 * countEpisode * seasons + (seasons * 10);

        System.out.printf("Total time needed to watch the %s series is %d minutes.", serial, (int)Math.floor(time));
    }
}
