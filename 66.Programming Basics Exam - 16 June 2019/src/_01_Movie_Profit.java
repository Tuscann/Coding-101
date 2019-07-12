import java.util.Scanner;

public class _01_Movie_Profit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String movieName = scanner.nextLine();
        int countDays = Integer.parseInt(scanner.nextLine());
        int countBileti = Integer.parseInt(scanner.nextLine());
        double priceBilet = Double.parseDouble(scanner.nextLine());
        int cinema = Integer.parseInt(scanner.nextLine());

        double profit = (countBileti * priceBilet * countDays) * (1 - cinema / 100.00);

        System.out.printf("The profit from the movie %s is %.2f lv.", movieName, profit);
    }
}
