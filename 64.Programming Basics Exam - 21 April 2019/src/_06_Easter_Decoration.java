import java.util.Scanner;

public class _06_Easter_Decoration {
    public static void main(String[] args) {
        Scanner scanner= new Scanner(System.in);
        int customers = Integer.parseInt(scanner.nextLine());

        double totalSum = 0;

        for (int i = 0; i < customers; i++) {

            double sum = 0;
            int counterPurchases = 0;

            while (true) {
                String current = scanner.nextLine();

                if (current.equals("Finish")) {
                    break;
                }
                counterPurchases++;

                if (current.equals("basket")) {
                    sum += 1.5;
                } else if (current.equals("wreath")) {
                    sum += 3.8;
                } else if (current.equals("chocolate bunny")) {
                    sum += 7.0;
                }
            }
            if (counterPurchases % 2 == 0) {
                sum *= 0.8;
            }
            totalSum += sum;
            System.out.printf("You purchased %d items for %.2f leva.\n", counterPurchases, sum);

        }
        System.out.printf("Average bill per client is: %.2f leva.", totalSum/customers);
    }
}
