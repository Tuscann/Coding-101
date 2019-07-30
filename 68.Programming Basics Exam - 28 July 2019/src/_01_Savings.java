import java.util.Scanner;

public class _01_Savings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double incomePerMonth = Double.parseDouble(scanner.nextLine());
        int countMonths = Integer.parseInt(scanner.nextLine());
        double privateExpenses = Double.parseDouble(scanner.nextLine());

        double moneyLeft = incomePerMonth - (privateExpenses + incomePerMonth * 0.3);

        double prozensts = (moneyLeft / incomePerMonth) * 100.00;

        System.out.printf("She can save %.2f%%\n", prozensts);
        System.out.printf("%.2f", moneyLeft * countMonths);
    }
}
