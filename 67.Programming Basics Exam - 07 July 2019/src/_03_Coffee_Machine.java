import java.util.Scanner;

public class _03_Coffee_Machine {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String drink = scanner.nextLine();
        String sugar = scanner.nextLine();
        int countDrinks = Integer.parseInt(scanner.nextLine());

        double price = 0;

        switch (drink) {
            case "Espresso":
                switch (sugar) {
                    case "Without":
                        price = 0.9;
                        break;
                    case "Normal":
                        price = 1;
                        break;
                    case "Extra":
                        price = 1.2;
                        break;
                }
                break;
            case "Cappuccino":
                switch (sugar) {
                    case "Without":
                        price = 1;
                        break;
                    case "Normal":
                        price = 1.2;
                        break;
                    case "Extra":
                        price = 1.6;
                        break;
                }
                break;
            case "Tea":
                switch (sugar) {
                    case "Without":
                        price = 0.5;
                        break;
                    case "Normal":
                        price = 0.6;
                        break;
                    case "Extra":
                        price = 0.7;
                        break;
                }
                break;
        }
        double sum = price * countDrinks;

        if (sugar.equals("Without")) {
            sum *= 0.65;
        }
        if (drink.equals("Espresso") && countDrinks >= 5) {
            sum *= 0.75;
        }
        if (sum > 15) {
            sum *= 0.8;
        }
        System.out.printf("You bought %d cups of %s for %.2f lv.", countDrinks, drink, sum);
    }
}
