import java.util.Scanner;

public class _02_Maiden_Party {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double girlParty = scan.nextDouble();
        int loveMessages = scan.nextInt();
        int rosses = scan.nextInt();
        int keyHolders = scan.nextInt();
        int cartoons = scan.nextInt();
        int luckGifts = scan.nextInt();

        double sum = loveMessages * 0.6 + rosses * 7.2 + keyHolders * 3.6 + cartoons * 18.2 + luckGifts * 22;
        int countProducts = loveMessages + rosses + keyHolders + cartoons + luckGifts;
        double newSum = 0;

        if (countProducts >= 25) {
            newSum = (0.65 * sum) * 0.9;
        } else {
            newSum = sum * 0.9;
        }

        if (newSum > girlParty) {
            System.out.printf("Yes! %.2f lv left. ", newSum-girlParty);
        } else {
            System.out.printf("Not enough money! %.2f lv needed.", girlParty-newSum);
        }

    }
}
