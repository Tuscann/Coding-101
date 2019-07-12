import java.util.Scanner;

public class _05_Movie_Ratings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Integer count = Integer.parseInt(scanner.nextLine());

        double highest = 0;
        String highestName = "";
        double lowest = 10;
        String lowestName = "";
        double sum = 0;

        for (int i = 0; i < count; i++) {
            String movieName = scanner.nextLine();
            double movieRaitings = Double.parseDouble(scanner.nextLine());

            sum += movieRaitings;

            if (movieRaitings >= highest) {
                highest = movieRaitings;
                highestName = movieName;
            }
            if (movieRaitings <= lowest) {
                lowest = movieRaitings;
                lowestName = movieName;
            }
        }
        System.out.printf("%s is with highest rating: %.1f\n", highestName, highest);
        System.out.printf("%s is with lowest rating: %.1f\n", lowestName, lowest);
        System.out.printf("Average rating: %.1f", sum / count);
    }
}