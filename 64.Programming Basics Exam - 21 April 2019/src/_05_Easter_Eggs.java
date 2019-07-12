import java.util.Scanner;

public class _05_Easter_Eggs {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int countColorEggs = Integer.parseInt(scanner.nextLine());

        int counterRedEggs = 0;
        int counterOrangeEggs = 0;
        int counterBlueEggs = 0;
        int counterGreenEggs = 0;
        int maxCounter = 0;
        String maxColor = "";

        for (int i = 0; i < countColorEggs; i++) {
            String current = scanner.nextLine();

            if (current.equals("red")) {
                counterRedEggs++;
                if (counterRedEggs > maxCounter) {
                    maxCounter = counterRedEggs;
                    maxColor = current;
                }

            } else if (current.equals("orange")) {
                counterOrangeEggs++;
                if (counterOrangeEggs > maxCounter) {
                    maxCounter = counterOrangeEggs;
                    maxColor = current;
                }
            } else if (current.equals("blue")) {
                counterBlueEggs++;
                if (counterBlueEggs > maxCounter) {
                    maxCounter = counterBlueEggs;
                    maxColor = current;
                }

            } else if (current.equals("green")) {
                counterGreenEggs++;
                if (counterGreenEggs > maxCounter) {
                    maxCounter = counterGreenEggs;
                    maxColor = current;
                }
            }
        }
        System.out.printf("Red eggs: %d\n", counterRedEggs);
        System.out.printf("Orange eggs: %d\n", counterOrangeEggs);
        System.out.printf("Blue eggs: %d\n", counterBlueEggs);
        System.out.printf("Green eggs: %d\n", counterGreenEggs);
        System.out.printf("Max eggs: %d -> %s\n", maxCounter,maxColor );
    }
}
