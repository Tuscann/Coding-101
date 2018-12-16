import java.util.Scanner;

public class _02_Wedding_Party {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int guest = Integer.parseInt(scan.nextLine());
        int budjet = Integer.parseInt(scan.nextLine());

        double kuvert = guest * 20;

        if (kuvert <= budjet) {
            double leftMoney = budjet - kuvert;
            double bannnMoney = 0.4 * leftMoney;
            double giftMoney = leftMoney - bannnMoney;

            System.out.printf("Yes! %.0f lv are for fireworks and %.0f lv are for donation.", bannnMoney, giftMoney);
        } else {
            System.out.printf("They won't have enough money to pay the covert. They will need %.0f lv more.", kuvert - budjet);
        }
    }
}
