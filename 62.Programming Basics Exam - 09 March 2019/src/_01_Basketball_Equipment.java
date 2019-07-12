import java.util.Scanner;

public class _01_Basketball_Equipment {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int moneyPerYear = Integer.parseInt(scanner.nextLine());

        double priceBaskatSneakers = moneyPerYear * 0.6;
        double priceBaskatTshirt = priceBaskatSneakers * 0.8;
        double priceBaskatBall = priceBaskatTshirt * 0.25;
        double priceBasketAccesories = priceBaskatBall * 0.2;

        double endPrice = moneyPerYear + priceBaskatSneakers + priceBaskatTshirt + priceBaskatBall + priceBasketAccesories;

        System.out.printf("%.2f", endPrice);
    }
}
