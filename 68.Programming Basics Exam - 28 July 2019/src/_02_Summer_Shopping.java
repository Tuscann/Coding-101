import java.util.Scanner;

public class _02_Summer_Shopping {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double budget = Double.parseDouble(scan.nextLine());
        double beachBlanket = Double.parseDouble(scan.nextLine());
        int discount = Integer.parseInt(scan.nextLine());

        double pricebeachChadar = 2.0 / 3 * beachBlanket;
        double priceFlipFlops = pricebeachChadar * 0.75;
        double priceBeachBag = (beachBlanket + priceFlipFlops) / 3;

        double price = beachBlanket + pricebeachChadar + priceFlipFlops + priceBeachBag;
        price *= 1 - (discount / 100.0);

        if (price <= budget) {
            System.out.printf("Annie's sum is %.2f lv. She has %.2f lv. left.", price, budget - price);
        } else {
            System.out.printf("Annie's sum is %.2f lv. She needs %.2f lv. more.", price, price - budget);
        }
    }
}
