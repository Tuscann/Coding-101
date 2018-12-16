import java.util.Scanner;

public class _04_Bachelor_Party {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int moneyForGuest = Integer.parseInt(scan.nextLine());

        int total = 0;
        int totalGuests = 0;

        while (true) {
            String curent = scan.nextLine();
            if (curent.equals("The restaurant is full")) {
                break;
            }
            int groupNumber = Integer.parseInt(curent);
            totalGuests += groupNumber;

            if (groupNumber >= 5) {
                total += groupNumber * 70;
            } else {
                total += groupNumber * 100;
            }
        }
        if (total >= moneyForGuest) {
            System.out.print("You have " + totalGuests + " guests and " + (total - moneyForGuest) + " leva left.");
        } else {
            System.out.print("You have " + totalGuests + " guests and " + total + " leva income, but no singer.");
        }
    }
}
