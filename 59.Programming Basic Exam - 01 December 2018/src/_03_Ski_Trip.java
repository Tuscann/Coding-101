import java.util.Scanner;

public class _03_Ski_Trip {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int days = Integer.parseInt(scan.nextLine());
        String typeOfRoom = scan.nextLine();
        String rating = scan.nextLine();

        double price = 0;
        double discount = 0;

        if (typeOfRoom.equals("room for one person")) {
            price = 18;
        } else if (typeOfRoom.equals("apartment")) {

            if (days - 1 < 10) {
                discount = 0.3;
            } else if (days - 1 >= 10 && days - 1 <= 15) {
                discount = 0.35;
            } else if (days - 1 > 15) {
                discount = 0.5;
            }
            price = 25;
        } else if (typeOfRoom.equals("president apartment")) {
            if (days - 1 < 10) {
                discount = 0.1;
            } else if (days - 1 >= 10 && days - 1 <= 15) {
                discount = 0.15;
            } else if (days - 1 > 15) {
                discount = 0.2;
            }
            price = 35;
        }
        double total = ((days - 1) * price) * (1 - discount);

        if (rating.equals("positive")) {
            total *= 1.25;
        } else if (rating.equals("negative")) {
            total *= 0.9;
        }

        System.out.printf("%.2f",total);


    }
}
