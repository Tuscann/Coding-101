import java.util.Scanner;

public class _06_Vet_Parking {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int days = Integer.parseInt(scanner.nextLine());
        int hours = Integer.parseInt(scanner.nextLine());
        double totalSum = 0;

        for (int i = 1; i <= days; i++) {
            double sum = 0;
            for (int j = 1; j <= hours; j++) {
                if (i % 2 != 0) {
                    if (j % 2 != 0) {
                        sum += 1;
                    } else {
                        sum += 1.25;
                    }
                } else {
                    if (j % 2 != 0) {
                        sum += 2.5;
                    } else {
                        sum += 1.00;
                    }
                }
            }
            totalSum += sum;
            System.out.printf("Day: %d - %.2f leva\n", i, sum);
        }
        System.out.printf("Total: %.2f leva", totalSum);
    }
}
