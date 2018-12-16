import java.util.Scanner;

public class _05_Wedding_Presents {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int totalGuests = Integer.parseInt(scan.nextLine());
        int giftCount = Integer.parseInt(scan.nextLine());

        double countA = 0.0;
        double countB = 0.0;
        double countV = 0.0;
        double countG = 0.0;


        for (int i = 0; i < giftCount; i++) {
            String current = scan.nextLine();
            if (current.equals("A")) {
                countA++;
            } else if (current.equals("B")) {
                countB++;
            } else if (current.equals("V")) {
                countV++;
            } else if (current.equals("G")) {
                countG++;
            }
        }
        System.out.printf("%.2f%%\n", countA / giftCount * 100);
        System.out.printf("%.2f%%\n", countB / giftCount * 100);
        System.out.printf("%.2f%%\n", countV / giftCount * 100);
        System.out.printf("%.2f%%\n", countG / giftCount * 100);
        System.out.printf("%.2f%%",(double) giftCount / totalGuests * 100);
    }
}
