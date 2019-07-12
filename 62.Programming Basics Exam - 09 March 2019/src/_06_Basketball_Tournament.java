import java.sql.SQLOutput;
import java.util.Scanner;

public class _06_Basketball_Tournament {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int desiWins = 0;
        int desiLosses = 0;

        while (true) {
            String nameTournament = scan.nextLine();
            if (nameTournament.equals("End of tournaments")) {
                break;
            }
            int counterMatches = Integer.parseInt(scan.nextLine());

            for (int i = 1; i <= counterMatches; i++) {
                int first = Integer.parseInt(scan.nextLine());
                int secound = Integer.parseInt(scan.nextLine());

                if (first > secound) {
                    System.out.printf("Game %d of tournament %s: win with %d points.\n", i, nameTournament, first - secound);
                    desiWins++;
                } else {
                    System.out.printf("Game %d of tournament %s: lost with %d points.\n", i, nameTournament, secound - first);
                    desiLosses++;
                }
            }
        }

        double percentWin = desiWins * 1.0 / (desiWins + desiLosses) * 100;
        double percentLost = desiLosses * 1.0 / (desiWins + desiLosses) * 100;

        System.out.printf("%.2f%% matches win\n", percentWin);
        System.out.printf("%.2f%% matches lost\n", percentLost);
    }
}
