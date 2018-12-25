import java.util.Scanner;

public class _05_Project_Prize {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int part = Integer.parseInt(scan.nextLine());
        double moneyPrice = Double.parseDouble(scan.nextLine());

        double total = 0;
        for (int i = 1; i <= part; i++) {
            int curentPoints = Integer.parseInt(scan.nextLine());

            if (i % 2 == 0) {
                curentPoints *= 2;
            }
            total += curentPoints;
        }
        System.out.printf("The project prize was %.2f lv.",total*moneyPrice);
    }
}
