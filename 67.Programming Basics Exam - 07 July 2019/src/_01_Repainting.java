import java.util.Scanner;

public class _01_Repainting {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int nylonQuantity = Integer.parseInt(scanner.nextLine());
        int paintQuantity = Integer.parseInt(scanner.nextLine());
        int thinnerQuantity = Integer.parseInt(scanner.nextLine());
        int hoursEnd = Integer.parseInt(scanner.nextLine());

        double nylon = (nylonQuantity + 2) * 1.5;
        double paint = paintQuantity * 1.1 * 14.5;
        double thinner = thinnerQuantity * 5;

        double sum = (nylon + paint + thinner + 0.4);
        double summ = sum * 0.3 * hoursEnd;

        System.out.printf("Total expenses: %.2f lv.", sum + summ);
    }
}
