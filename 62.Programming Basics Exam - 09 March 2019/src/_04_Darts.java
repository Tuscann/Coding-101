import java.util.Scanner;

public class _04_Darts {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String name = scan.nextLine();
        int startPoints = 301;
        int counterNotMissedFires = 0;
        int missedShots = 0;

        while (true) {
            String text = scan.nextLine();

            if (text.equals("Retire")) {
                System.out.printf("%s retired after %d unsuccessful shots.", name, missedShots);
                break;
            }
            int points = Integer.parseInt(scan.nextLine());

            switch (text) {
                case "Triple":
                    if (startPoints - (points * 3) >= 0) {
                        startPoints -= (points * 3);
                        counterNotMissedFires++;
                    } else {
                        missedShots++;
                    }
                    break;
                case "Double":
                    if (startPoints - (points * 2) >= 0) {
                        startPoints -= (points * 2);
                        counterNotMissedFires++;
                    } else {
                        missedShots++;
                    }
                    break;
                case "Single":
                    if (startPoints - points >= 0) {
                        startPoints -= points;
                        counterNotMissedFires++;
                    } else {
                        missedShots++;
                    }
                    break;
            }
            if (startPoints == 0) {
                break;
            }
        }
        if (startPoints == 0) {
            System.out.printf("%s won the leg with %d shots.", name, counterNotMissedFires);
        }
    }
}