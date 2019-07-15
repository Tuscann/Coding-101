import java.util.Scanner;

public class _05_Football_Tournament {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String nameTeam = scanner.nextLine();
        int countMatches = Integer.parseInt(scanner.nextLine());

        if (countMatches == 0) {
            System.out.printf("%s hasn't played any games during this season.", nameTeam);
        } else {
            int countWins = 0;
            int countDraws = 0;

            for (int i = 0; i < countMatches; i++) {
                String current = scanner.nextLine();
                if (current.equals("W")) {
                    countWins++;
                } else if (current.equals("D")) {
                    countDraws++;
                }
            }
            int total = countWins * 3 + countDraws;

            System.out.printf("%s has won %d points during this season.\n", nameTeam, total);
            System.out.println("Total stats:");
            System.out.printf("## W: %d\n", countWins);
            System.out.printf("## D: %d\n", countDraws);
            System.out.printf("## L: %d\n", countMatches - countWins - countDraws);
            System.out.printf("Win rate: %.2f%%", countWins * 1.0 / countMatches * 100.00);
        }
    }
}