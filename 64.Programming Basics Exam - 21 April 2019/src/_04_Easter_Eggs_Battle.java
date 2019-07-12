import java.util.Scanner;

public class _04_Easter_Eggs_Battle {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int countEggsFirst = Integer.parseInt(scanner.nextLine());
        int countEggsSecond = Integer.parseInt(scanner.nextLine());

        while (true) {
            String winner = scanner.nextLine();
            if (winner.equals("End of battle")) {
                break;
            }

            if (winner.equals("one")) {
                countEggsSecond -= 1;
            } else if (winner.equals("two")) {
                countEggsFirst -= 1;
            }
            if (countEggsFirst == 0 || countEggsSecond == 0) {
                break;
            }
        }
        if (countEggsFirst == 0) {
            System.out.printf("Player one is out of eggs. Player two has %d eggs left.", countEggsSecond);
        } else if (countEggsSecond == 0) {
            System.out.printf("Player two is out of eggs. Player one has %d eggs left.", countEggsFirst);
        } else {
            System.out.printf("Player one has %d eggs left.\n", countEggsFirst);
            System.out.printf("Player two has %d eggs left.\n", countEggsSecond);
        }
    }
}
