import java.util.Scanner;

public class _03_Movie_Destination {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double budjet = Double.parseDouble(scanner.nextLine());
        String destination = scanner.nextLine();
        String season = scanner.nextLine();
        int days = Integer.parseInt(scanner.nextLine());

        int price = 0;

        if (destination.equals("Dubai")) {
            if (season.equals("Summer")) {
                price = 40000;
            } else if (season.equals("Winter")) {
                price = 45000;
            }
        } else if (destination.equals("Sofia")) {
            if (season.equals("Summer")) {
                price = 12500;
            } else if (season.equals("Winter")) {
                price = 17000;
            }
        } else if (destination.equals("London")) {
            if (season.equals("Summer")) {
                price = 20250;
            } else if (season.equals("Winter")) {
                price = 24000;
            }
        }
        double sum = price * days;
        if (destination.equals("Dubai")) {
            sum *= 0.7;
        }
        if (destination.equals("Sofia")) {
            sum *= 1.25;
        }
        if (sum > budjet) {
            System.out.printf("The director needs %.2f leva more!", sum - budjet);
        } else {
            System.out.printf("The budget for the movie is enough! We have %.2f leva left!", budjet - sum);
        }
    }
}
