import java.util.Scanner;

public class _06_Easter_Competition {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int countBread = Integer.parseInt(scanner.nextLine());

        int maxScore = 0;
        String maxName = "";

        for (int i = 0; i < countBread; i++) {

            String nameBaker = scanner.nextLine();
            int currentScore = 0;

            while (true) {
                String scoreBread = scanner.nextLine();
                if (scoreBread.equals("Stop")) {
                    break;
                }
                int score = Integer.parseInt(scoreBread);
                currentScore += score;
            }
            System.out.printf("%s has %d points.\n", nameBaker, currentScore);
            if (maxScore < currentScore) {
                maxScore = currentScore;
                maxName = nameBaker;
                System.out.printf("%s is the new number 1!\n", nameBaker);
            }
        }
        System.out.printf("%s won competition with %d points!", maxName, maxScore);
    }
}
