import java.util.Scanner;

public class _05_Family_House {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int months = Integer.parseInt(scan.nextLine());

        double total = 0;
        double total2 = 0;
        for (int i = 0; i < months; i++) {
            double currentElectricy = Double.parseDouble(scan.nextLine());
            total += currentElectricy;
        }
        System.out.printf("Electricity: %.2f lv\n", total);
        System.out.printf("Water: %.2f lv\n", months * 20.0);
        System.out.printf("Internet: %.2f lv\n", months * 15.0);

        total2 += total + months * 20 + months * 15;

        total += months * (20 + 15);
        total *= 1.2;
        total2 += total;
        System.out.printf("Other: %.2f lv\n", total);
        System.out.printf("Average: %.2f lv\n", total2 / months);

    }
}
