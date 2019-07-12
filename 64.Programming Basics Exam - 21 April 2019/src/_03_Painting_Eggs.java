import java.util.Scanner;

public class _03_Painting_Eggs {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String sizeEgg = scanner.nextLine();
        String colorEgg = scanner.nextLine();
        int partidi = Integer.parseInt(scanner.nextLine());

        int priceEgg = 0;
        if (sizeEgg.equals("Large")) {
            if (colorEgg.equals("Red")) {
                priceEgg = 16;
            } else if (colorEgg.equals("Green")) {
                priceEgg = 12;
            } else if (colorEgg.equals("Yellow")) {
                priceEgg = 9;
            }
        } else if (sizeEgg.equals("Medium")) {
            if (colorEgg.equals("Red")) {
                priceEgg = 13;
            } else if (colorEgg.equals("Green")) {
                priceEgg = 9;
            } else if (colorEgg.equals("Yellow")) {
                priceEgg = 7;
            }
        } else if (sizeEgg.equals("Small")) {
            if (colorEgg.equals("Red")) {
                priceEgg = 9;
            } else if (colorEgg.equals("Green")) {
                priceEgg = 8;
            } else if (colorEgg.equals("Yellow")) {
                priceEgg = 5;
            }
        }

        System.out.printf("%.2f leva.", (priceEgg * partidi) * 0.65);


    }
}
