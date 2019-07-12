import java.util.Dictionary;
import java.util.Scanner;

public class _02_Godzilla_vs_Kong {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double budjet = Double.parseDouble(scanner.nextLine());
        int countStatistic = Integer.parseInt(scanner.nextLine());
        double priceCloathStatistic = Double.parseDouble(scanner.nextLine());

        double moneyDecor = budjet * 0.1;
        double moneyClothes = countStatistic * priceCloathStatistic;
        if (countStatistic > 150) {
            moneyClothes *= 0.9;
        }
        double moneyForFilm = moneyDecor + moneyClothes;

        if (moneyForFilm <= budjet) {
            System.out.println("Action!");
            System.out.printf("Wingard starts filming with %.2f leva left.", budjet - moneyForFilm);
        } else {
            System.out.println("Not enough money!");
            System.out.printf("Wingard needs %.2f leva more.", moneyForFilm - budjet);
        }
    }
}
