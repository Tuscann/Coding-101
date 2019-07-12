import java.util.Scanner;

public class _02_Easter_Party {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int countGuest = Integer.parseInt(scanner.nextLine());
        double priceKuvert = Double.parseDouble(scanner.nextLine());
        double budjet = Double.parseDouble(scanner.nextLine());

        if (countGuest >= 10 && countGuest <= 15) {
            priceKuvert *= 0.85;
        } else if (countGuest >= 16 && countGuest <= 20) {
            priceKuvert *= 0.8;
        } else if (countGuest >= 21) {
            priceKuvert *= 0.75;
        }
        double sum = countGuest * priceKuvert + (budjet * 0.1);

        if (sum >= budjet) {
            System.out.printf("No party! %.2f leva needed.", sum - budjet);
        } else {
            System.out.printf("It is party time! %.2f leva left.", budjet - sum);
        }


    }
}
