import java.util.Scanner;

public class _01_Lemonade_Stand {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double kilogramsLemonade = Double.parseDouble(scan.nextLine());
        double kilogramsSugar = Double.parseDouble(scan.nextLine());
        double litersWater = Double.parseDouble(scan.nextLine());

        double lemonade = kilogramsLemonade * 980 + litersWater * 1000 + 0.3 * kilogramsSugar;

        double cupsLemonade = Math.floor(lemonade / 150);

        System.out.printf("All cups sold: %.0f\n", cupsLemonade);
        System.out.printf("Money earned: %.2f\n", cupsLemonade * 1.2);
    }
}
