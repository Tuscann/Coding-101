import java.util.Scanner;

public class _06_Baking_Competition {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int countPleayer = Integer.parseInt(scan.nextLine());
        int totalCountSweets = 0;
        double charity = 0;

        for (int i = 0; i < countPleayer; i++) {
            String namePleyear = scan.nextLine();

            int countCookies = 0;
            int countCakes = 0;
            int countWaffles = 0;
            while (true) {
                String typeSweet = scan.nextLine();
                if (typeSweet.equals("Stop baking!")) {
                    break;
                }

                int countSweets = Integer.parseInt(scan.nextLine());

                if (typeSweet.equals("cookies")) {
                    countCookies += countSweets;
                    charity += countSweets * 1.5;
                } else if (typeSweet.equals("cakes")) {
                    countCakes += countSweets;
                    charity += countSweets * 7.8;
                } else if (typeSweet.equals("waffles")) {
                    countWaffles += countSweets;
                    charity += countSweets * 2.3;
                }
            }
            totalCountSweets += countCakes + countCookies + countWaffles;

            System.out.printf("%s baked %d cookies, %d cakes and %d waffles.\n", namePleyear, countCookies, countCakes, countWaffles);
        }
        System.out.printf("All bakery sold: %d\n", totalCountSweets);
        System.out.printf("Total sum for charity: %.2f lv.", charity);
    }
}
