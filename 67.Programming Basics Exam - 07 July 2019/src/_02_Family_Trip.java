import java.util.Scanner;

public class _02_Family_Trip {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double budget = Double.parseDouble(scanner.nextLine());
        int night = Integer.parseInt(scanner.nextLine());
        double priceNight = Double.parseDouble(scanner.nextLine());
        int prozent = Integer.parseInt(scanner.nextLine());

        if (night > 7) {
            priceNight *= 0.95;
        }

        double sum = night * priceNight + (prozent / 100.0) * budget;
        if (budget >= sum) {
            System.out.printf("Ivanovi will be left with %.2f leva after vacation.", budget - sum);
        } else {
            System.out.printf("%.2f leva needed.", sum - budget);
        }
    }
}
