import java.util.Scanner;

public class _04_Tourist_Shop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double budjet = Double.parseDouble(scanner.nextLine());
        int countProducts = 0;
        double totalPrice = 0.0;

        while (true) {
            String product = scanner.nextLine();
            if (product.equals("Stop")) {
                System.out.printf("You bought %d products for %.2f leva.", countProducts, totalPrice);
                break;
            }

            double price = Double.parseDouble(scanner.nextLine());
            countProducts++;
            if (countProducts % 3 == 0) {
                price /= 2;
            }

            if (budjet - price < 0) {
                System.out.println("You don't have enough money!");
                System.out.printf("You need %.2f leva!", (budjet - price) * (-1));
                break;
            }
            budjet -= price;
            totalPrice += price;
        }
    }
}
