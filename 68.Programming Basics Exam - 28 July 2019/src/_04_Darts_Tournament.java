import java.util.Scanner;

public class _04_Darts_Tournament {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int countPoints = Integer.parseInt(scan.nextLine());
        int counterRounds = 0;
        while (true) {
            String sector = scan.nextLine();
            counterRounds += 1;
            if (sector.equals("bullseye")) {
                System.out.printf("Congratulations! You won the game with a bullseye in %d moves!", counterRounds);
                break;
            }
            double currentPoints = Double.parseDouble(scan.nextLine());

            if (sector.equals("double ring")) {
                currentPoints *= 2;
            } else if (sector.equals("triple ring")) {
                currentPoints *= 3;
            }
            countPoints -= currentPoints;

            if (countPoints == 0) {
                System.out.printf("Congratulations! You won the game in %d moves!", counterRounds);
                break;
            } else if (countPoints < 0) {
                System.out.printf("Sorry, you lost. Score difference: %d.", countPoints * -1);
                break;
            }
        }
    }
}