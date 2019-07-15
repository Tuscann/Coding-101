import java.util.Scanner;

public class _05_PC_Game_Shop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int soldGames = Integer.parseInt(scanner.nextLine());

        int countHearthstone = 0;
        int countFornite = 0;
        int countOverwatch = 0;
        int countOthers = 0;

        for (int i = 0; i < soldGames; i++) {
            String currentMovie = scanner.nextLine();

            switch (currentMovie) {
                case "Hearthstone":
                    countHearthstone++;
                    break;
                case "Fornite":
                    countFornite++;
                    break;
                case "Overwatch":
                    countOverwatch++;
                    break;
                default:
                    countOthers++;
                    break;
            }
        }
        System.out.printf("Hearthstone - %.2f%%\n", countHearthstone * 1.0 / soldGames * 100);
        System.out.printf("Fornite - %.2f%%\n", countFornite * 1.0 / soldGames * 100);
        System.out.printf("Overwatch - %.2f%%\n", countOverwatch * 1.0 / soldGames * 100);
        System.out.printf("Others - %.2f%%\n", countOthers * 1.0 / soldGames * 100);
    }
}
