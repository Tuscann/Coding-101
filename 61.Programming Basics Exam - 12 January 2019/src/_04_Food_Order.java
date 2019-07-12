import java.sql.SQLOutput;
import java.util.Scanner;

public class _04_Food_Order {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double budjet = Double.parseDouble(scan.nextLine());
        double spend = budjet;

        int counterOrders = 0;
        double deliveryPrice = 2.5;

        budjet -= deliveryPrice;

        while (true) {
            String nameOfProduct = scan.nextLine();

            if (nameOfProduct.equals("Order")) {
                System.out.printf("You ordered %d items!\n", counterOrders);
                System.out.printf("Total: %.2f\n", spend-budjet);
                break;
            }
            double quantity = Double.parseDouble(scan.nextLine());
            if (budjet - quantity >= 0.0) {
                budjet -= quantity;
                counterOrders++;
            } else {
                System.out.println("You will exceed the budget if you order this!");
            }
        }
    }
}
