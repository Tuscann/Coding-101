import java.util.Scanner;

public class _03_Cruise_Ship {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String typeCruise = scan.nextLine();
        String typeRoom = scan.nextLine();
        int night = Integer.parseInt(scan.nextLine());

        double price = 0;
        if (typeCruise.equals("Mediterranean")) {
            if (typeRoom.equals("standard cabin")) {
                price = 27.5;
            } else if (typeRoom.equals("cabin with balcony")) {
                price = 30.2;
            } else if (typeRoom.equals("apartment")) {
                price = 40.5;
            }
        } else if (typeCruise.equals("Adriatic")) {
            if (typeRoom.equals("standard cabin")) {
                price = 22.99;
            } else if (typeRoom.equals("cabin with balcony")) {
                price = 25;
            } else if (typeRoom.equals("apartment")) {
                price = 34.99;
            }
        } else if (typeCruise.equals("Aegean")) {
            if (typeRoom.equals("standard cabin")) {
                price = 23;
            } else if (typeRoom.equals("cabin with balcony")) {
                price = 26.6;
            } else if (typeRoom.equals("apartment")) {
                price = 39.8;
            }
        }
        double sum = price * night * 4;

        if (night > 7) {
            sum *= 0.75;
        }
        System.out.printf("Annie's holiday in the %s sea costs %.2f lv.", typeCruise, sum);
    }
}
