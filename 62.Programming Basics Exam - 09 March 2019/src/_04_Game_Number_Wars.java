import java.util.Scanner;

public class _04_Game_Number_Wars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String firstPlayerName = scanner.nextLine();
        String secoundPlayerName = scanner.nextLine();

        int counterPointsFirst = 0;
        int counterPointsSecound = 0;

        boolean iswar = false;

        while (true) {
            String firstPleayerCard = scanner.nextLine();
            if (firstPleayerCard.equals("End of game")) {
                System.out.printf("%s has %d points%n", firstPlayerName, counterPointsFirst);
                System.out.printf("%s has %d points%n", secoundPlayerName, counterPointsSecound);
                break;
            }
            String secoundPleayerCard = scanner.nextLine();

            int numberFirst = Integer.parseInt(firstPleayerCard);
            int numberSecound = Integer.parseInt(secoundPleayerCard);

            if (numberFirst > numberSecound) {
                if (iswar) {
                    System.out.printf("%s is winner with %d points", firstPlayerName, counterPointsFirst);
                break;
                }
                counterPointsFirst += (numberFirst - numberSecound);
            } else if (numberSecound > numberFirst) {
                if (iswar) {
                    System.out.printf("%s is winner with %d points", secoundPlayerName, counterPointsSecound);
                break;
                }
                counterPointsSecound += (numberSecound - numberFirst);
            } else {
                iswar = true;
                System.out.println("Number wars!");
            }
        }
    }
}
