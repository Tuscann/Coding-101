import java.util.Scanner;

public class _03_Honeymoon {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double budget = Double.parseDouble(scanner.nextLine());
        String city = scanner.nextLine();
        double nights = Integer.parseInt(scanner.nextLine());

        double price = 0;
        double novacena = 0;

        if (city.equalsIgnoreCase("Cairo")) {
            price = 600 + (250 * 2) * nights;
        } else if (city.equalsIgnoreCase("Paris")) {
            price = 350 + (150 * 2) * nights;
        } else if (city.equalsIgnoreCase("Lima")) {
            price = 850 + (400 * 2) * nights;
        } else if (city.equalsIgnoreCase("New York")) {
            price = 650 + (300 * 2) * nights;
        } else if (city.equalsIgnoreCase("Tokyo")) {
            price = 700 + (350 * 2) * nights;
        }

        double discount = 0;

        if (nights >= 1 && nights <= 4) {
            if (city.equals("Cairo") || city.equals("New York")) {
                discount = 3;
            }
        }
        if (nights >= 5 && nights <= 9) {
            if (city.equals("Cairo") || city.equals("New York")) {
                discount = 5;
            }
            if (city.equals("Paris")) {
                discount = 7;
            }
        } else if (nights >= 10 && nights <= 24) {
            if (city.equals("Cairo")) {
                discount = 10;
            }
            if (city.equals("Paris") || city.equals("New York") || city.equals("Tokyo")) {
                discount = 12;
            }
        } else if (nights >= 25 && nights <= 49) {
            if (city.equals("Cairo") || city.equals("Tokyo")) {
                discount = 17;
            }
            if (city.equals("Lima") || city.equals("New York")) {
                discount = 19;
            }
            if (city.equals("Paris")) {
                discount = 22;
            }
        } else if (nights >= 50) {
            discount = 30;
        }

        novacena = price - (price * discount / 100);

        if (budget >= novacena) {
            System.out.printf("Yes! You have %.2f leva left.", budget - novacena);
        } else {
            System.out.printf("Not enough money! You need %.2f leva.", novacena - budget);
        }
    }
}
