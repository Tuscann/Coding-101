import java.util.Scanner;

public class _02_Movie_Day {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int timePhotos = Integer.parseInt(scanner.nextLine());
        int countSceni = Integer.parseInt(scanner.nextLine());
        int time = Integer.parseInt(scanner.nextLine());

        double sum = timePhotos * 0.15 + countSceni * time;

        if (sum > timePhotos) {
            System.out.printf("Time is up! To complete the movie you need %d minutes.", (int) sum - timePhotos);
        } else {
            System.out.printf("You managed to finish the movie on time! You have %d minutes left!", timePhotos - (int) sum);
        }
    }
}
