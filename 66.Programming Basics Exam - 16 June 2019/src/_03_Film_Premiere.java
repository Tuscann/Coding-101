import java.util.Scanner;

public class _03_Film_Premiere {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String movieName = scanner.nextLine();
        String drink = scanner.nextLine();
        int counTickets = Integer.parseInt(scanner.nextLine());

        double price = 0.0;

        if (movieName.equals("John Wick")) {
            if (drink.equals("Drink")) {
                price = 12;

            } else if (drink.equals("Popcorn")) {
                price = 15;

            } else if (drink.equals("Menu")) {
                price = 19;
            }
        } else if (movieName.equals("Star Wars")) {
            if (drink.equals("Drink")) {
                price = 18;

            } else if (drink.equals("Popcorn")) {
                price = 25;

            } else if (drink.equals("Menu")) {
                price = 30;
            }
            if (counTickets >= 4) {
                price *= 0.7;
            }
        } else if (movieName.equals("Jumanji")) {
            if (drink.equals("Drink")) {
                price = 9;

            } else if (drink.equals("Popcorn")) {
                price = 11;

            } else if (drink.equals("Menu")) {
                price = 14;
            }
            if (counTickets == 2) {
                price *= 0.85;
            }
        }
        System.out.printf("Your bill is %.2f leva.\n", counTickets * price);
    }
}
