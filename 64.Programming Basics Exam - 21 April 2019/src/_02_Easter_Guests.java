import java.util.Scanner;

public class _02_Easter_Guests {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int guestCount = Integer.parseInt(scanner.nextLine());
        int budjet = Integer.parseInt(scanner.nextLine());

        int countEasterBread = guestCount / 3;
        if (guestCount % 3 != 0) {
            countEasterBread++;
        }

        int egssFor10 = guestCount * 2;

        double price = countEasterBread * 4 + egssFor10 * 0.45;

        if (price <= budjet) {
            System.out.printf("Lyubo bought %d Easter bread and %d eggs.\n", countEasterBread, egssFor10);
            System.out.printf("He has %.2f lv. left.", budjet - price);
        } else {
            System.out.println("Lyubo doesn't have enough money.");
            System.out.printf("He needs %.2f lv. more.", price - budjet);
        }
    }
}
