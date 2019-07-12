import java.util.Scanner;

public class _01_Oscars_ceremony {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int rentForHall = Integer.parseInt(scanner.nextLine());

        double statuesPrice = rentForHall * 0.7;
        double cateringPrice = statuesPrice * 0.85;
        double soundPrice = cateringPrice / 2.0;
        double total = rentForHall + statuesPrice + cateringPrice + soundPrice;

        System.out.printf("%.2f", total);
    }
}
