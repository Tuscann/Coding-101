import java.util.Scanner;

public class _05_Cruise_Games {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String namePlayer = scan.nextLine();
        int countGames = Integer.parseInt(scan.nextLine());

        int counterVolleyball = 0;
        int counterTennis = 0;
        int counterBadminton = 0;

        double pointsVolleyball = 0;
        double pointsTennis = 0;
        double pointsBadminton = 0;

        for (int i = 0; i < countGames; i++) {
            String nameOfGame = scan.nextLine();
            int points = Integer.parseInt(scan.nextLine());

            if (nameOfGame.equals("volleyball")) {
                counterVolleyball += 1;
                pointsVolleyball += points * 1.07;
            } else if (nameOfGame.equals("tennis")) {
                counterTennis += 1;
                pointsTennis += points * 1.05;
            } else if (nameOfGame.equals("badminton")) {
                counterBadminton += 1;
                pointsBadminton += points * 1.02;
            }
        }
        if (pointsVolleyball / counterVolleyball > 75 &&
                pointsTennis / counterTennis > 75 &&
                pointsBadminton / counterBadminton > 75) {
            System.out.printf("Congratulations, %s! You won the cruise games with %.0f points.", namePlayer, Math.floor(pointsVolleyball + pointsTennis + pointsBadminton));
        } else {
            System.out.printf("Sorry, %s, you lost. Your points are only %.0f.", namePlayer, Math.floor(pointsVolleyball + pointsTennis + pointsBadminton));
        }
    }
}
