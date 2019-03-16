import java.util.Scanner;

public class _03_Pastry_Shop {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String type = scan.nextLine();
        int countSweets = Integer.parseInt(scan.nextLine());
        int dayOfDecember = Integer.parseInt(scan.nextLine());

        double price = 0.0;

        if (type.equals("Cake")) {
            if (dayOfDecember <= 15) {
                price = 24;
            } else {
                price = 28.7;
            }
        } else if (type.equals("Souffle")) {
            if (dayOfDecember <= 15) {
                price = 6.66;
            } else {
                price = 9.8;
            }

        } else if (type.equals("Baklava")) {
            if (dayOfDecember <= 15) {
                price = 12.6;
            } else {
                price = 16.98;
            }
        }
        double sum = price * countSweets;

        if (dayOfDecember <= 22) {
            if (sum >= 100 && sum <= 200) {
                sum *= 0.85;
            } else if (sum > 200) {
                sum *= 0.75;
            }
            if (dayOfDecember <= 15) {
                sum *= 0.9;
            }
        }
        System.out.printf("%.2f", sum);
    }
}
