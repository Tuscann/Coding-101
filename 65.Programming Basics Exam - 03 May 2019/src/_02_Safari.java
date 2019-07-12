import java.util.Scanner;

public class _02_Safari {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double budjet = Double.parseDouble(scanner.nextLine());
        double fuel = Double.parseDouble(scanner.nextLine());
        String dayOfWeek = scanner.nextLine();

        double sum = fuel * 2.1 + 100;

        if (dayOfWeek.equals("Saturday")) {
            sum *= 0.9;
        }
        if (dayOfWeek.equals("Sunday")) {
            sum *= 0.8;
        }

        if (budjet >= sum) {
            System.out.printf("Safari time! Money left: %.2f lv.", budjet - sum);
        } else {
            System.out.printf("Not enough money! Money needed: %.2f lv.", sum - budjet);
        }
    }
}
