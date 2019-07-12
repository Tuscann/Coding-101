import java.util.Scanner;

public class _03_Oscars_week_in_cinema {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String movieName = scanner.nextLine();
        String typeSalary = scanner.nextLine();
        int countTickets = Integer.parseInt(scanner.nextLine());

        double price = 0;

        if (movieName.equals("A Star Is Born")) {
            if (typeSalary.equals("normal")) {
                price = 7.5;
            } else if (typeSalary.equals("luxury")) {
                price = 10.5;
            } else if (typeSalary.equals("ultra luxury")) {
                price = 13.5;
            }
        } else if (movieName.equals("Bohemian Rhapsody")) {
            if (typeSalary.equals("normal")) {
                price = 7.35;
            } else if (typeSalary.equals("luxury")) {
                price = 9.45;
            } else if (typeSalary.equals("ultra luxury")) {
                price = 12.75;
            }
        } else if (movieName.equals("Green Book")) {
            if (typeSalary.equals("normal")) {
                price = 8.15;
            } else if (typeSalary.equals("luxury")) {
                price = 10.25;
            } else if (typeSalary.equals("ultra luxury")) {
                price = 13.25;
            }
        } else if (movieName.equals("The Favourite")) {
            if (typeSalary.equals("normal")) {
                price = 8.75;
            } else if (typeSalary.equals("luxury")) {
                price = 11.55;
            } else if (typeSalary.equals("ultra luxury")) {
                price = 13.95;
            }
        }
        System.out.printf("%s -> %.2f lv.", movieName, price * countTickets);
    }
}