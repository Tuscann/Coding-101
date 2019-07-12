import java.util.Scanner;

public class _05_Tennis_Ranklist {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int countTournament = Integer.parseInt(scan.nextLine());
        int pointsInRanglists = Integer.parseInt(scan.nextLine());

        double counterWinTournament = 0;
        int sumPoints = 0;

        for (int i = 0; i < countTournament; i++) {
            String stagetournament = scan.nextLine();

            if (stagetournament.equals("W")) {
                sumPoints += 2000;
                counterWinTournament++;
            } else if (stagetournament.equals("F")) {
                sumPoints += 1200;
            } else if (stagetournament.equals("SF")) {
                sumPoints += 720;
            }
        }
        System.out.println("Final points: " + (sumPoints + pointsInRanglists));
        System.out.printf("Average points: %.0f\n", Math.floor(sumPoints / countTournament));
        System.out.printf("%.2f", (counterWinTournament / countTournament) * 100);
        System.out.println("%");
    }
}
