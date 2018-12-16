import java.util.Scanner;

public class _03_Energy_Booster {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String fruit = scan.nextLine();
        String setSize = scan.nextLine();
        int countSets = scan.nextInt();

        double price = 0;

        if (setSize.equals("small")) {
            if (fruit.equals("Watermelon")) {
                price = 56;
            } else if (fruit.equals("Mango")) {
                price = 36.66;
            } else if (fruit.equals("Pineapple")) {
                price = 42.1;
            } else if (fruit.equals("Raspberry")) {
                price = 20;
            }
            price *= 2;

        } else if (setSize.equals("big")) {
            if (fruit.equals("Watermelon")) {
                price = 28.7;
            } else if (fruit.equals("Mango")) {
                price = 19.6;
            } else if (fruit.equals("Pineapple")) {
                price = 24.8;
            } else if (fruit.equals("Raspberry")) {
                price = 15.2;
            }
            price *= 5;
        }
        double afterPrice = countSets * price;
        if (afterPrice >= 400 && afterPrice <= 1000) {
            afterPrice *= 0.85;
        } else if (afterPrice > 1000) {
            afterPrice *= 0.5;
        }
        System.out.printf("%.2f lv.",afterPrice);

    }
}
