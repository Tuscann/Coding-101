import java.util.Scanner;

public class _02_Shopping {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double budjet = Double.parseDouble(scanner.nextLine());
        int videoCards = Integer.parseInt(scanner.nextLine());
        int prossesors = Integer.parseInt(scanner.nextLine());
        int ram = Integer.parseInt(scanner.nextLine());

        double priceVideoCards = videoCards * 250;
        double priceProssors = prossesors * (priceVideoCards * 0.35);
        double priceRam = ram * (0.1 * priceVideoCards);
        double sum = priceVideoCards + priceProssors + priceRam;

        if (prossesors < videoCards) {
            sum *= 0.85;
        }

        if (budjet >= sum) {
            System.out.printf("You have %.2f leva left!", budjet - sum);
        } else {
            System.out.printf("Not enough money! You need %.2f leva more!", sum - budjet);
        }
    }
}
