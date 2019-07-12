import java.util.Scanner;

public class _01_Food_Delivery {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int chiken = Integer.parseInt(scanner.nextLine());
        int fish = Integer.parseInt(scanner.nextLine());
        int vegeterian = Integer.parseInt(scanner.nextLine());

        double sum = (chiken * 10.35 + fish * 12.4 + vegeterian * 8.15) * 1.2 + 2.5;

        System.out.printf("Total: %.2f", sum);

    }
}
