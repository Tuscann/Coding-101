import java.util.Scanner;

public class _04_Club {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double expectedMoney = Double.parseDouble(scanner.nextLine());
        double priceAfter = 0;

        while (true) {
            String nameCocktail = scanner.nextLine();
            if (nameCocktail.equals("Party!")) {
                break;
            }
            int countCocktails = Integer.parseInt(scanner.nextLine());

            int price = countCocktails * nameCocktail.length();

            int num = price % 10;

            if (num % 2 != 0) {
                priceAfter += price * 0.75;
            } else {
                priceAfter += price;
            }
            if (expectedMoney <= priceAfter) {
                break;
            }
        }

        if (expectedMoney > priceAfter) {
            System.out.printf("We need %.2f leva more.\n", expectedMoney - priceAfter);
        } else {
            System.out.println("Target acquired.");
        }
        System.out.printf("Club income - %.2f leva.", priceAfter);
    }
}
