import java.util.Scanner;

public class _06_High_Jump {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int desireHight = Integer.parseInt(scanner.nextLine());
        int startheight = desireHight - 30;

        int counterJumpsFails = 0;
        int countAtemps = 0;

        while (true) {
            int currentHight = Integer.parseInt(scanner.nextLine());

            countAtemps++;
            if (currentHight > startheight) {
                startheight += 5;
                counterJumpsFails = 0;
            } else {
                counterJumpsFails++;
                if (counterJumpsFails == 3) {
                    System.out.println("Tihomir failed at " + startheight + "cm after " + countAtemps + " jumps.");
                    break;
                }
            }
            if (startheight > desireHight) {
                System.out.println("Tihomir succeeded, he jumped over " + desireHight + "cm after " + countAtemps + " jumps.");
                break;
            }
        }
    }
}