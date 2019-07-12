import java.util.Scanner;

public class _03_Flower_Shop {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int chrysanthemums = Integer.parseInt(scan.nextLine());
        int rose = Integer.parseInt(scan.nextLine());
        int tulips = Integer.parseInt(scan.nextLine());
        String season = scan.nextLine();
        char isHoliday = scan.next().charAt(0);

        double priceChrysanthemums = 3.75;
        double priceRose = 4.5;
        double priceTulips = 4.15;

        double price = 0;

        if (season.equals("Spring") || season.equals("Summer")) {
            priceChrysanthemums = 2.0;
            priceRose = 4.1;
            priceTulips = 2.5;

            price = chrysanthemums * priceChrysanthemums + rose * priceRose + tulips * priceTulips;

            if (isHoliday == 'Y') {
                price *= 1.15;
            }
            if (season.equals("Spring") && tulips > 7) {
                price *= 0.95;
            }
            if (chrysanthemums + rose + tulips > 20) {
                price *= 0.8;
            }
            price += 2;
            System.out.printf("%.2f", price);


        } else if (season.equals("Autumn") || season.equals("Winter")) {

            price = chrysanthemums * priceChrysanthemums + rose * priceRose + tulips * priceTulips;

            if (isHoliday == 'Y') {
                price *= 1.15;
            }
            if (season.equals("Winter") && rose >= 10) {
                price *= 0.90;
            }
            if (chrysanthemums + rose + tulips > 20) {
                price *= 0.8;
            }
            price += 2;
            System.out.printf("%.2f", price);

        }


    }
}
