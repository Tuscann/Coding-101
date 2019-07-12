import java.util.Scanner;

public class _05_Division_Without_Remainder {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        double p2 = 0;
        double p3 = 0;
        double p4 = 0;

        for (int i = 0; i < n; i++) {
            int number = Integer.parseInt(scanner.nextLine());

            if (number % 2 == 0) {
                p2++;
            }
            if (number % 3 == 0) {
                p3++;
            }
            if (number % 4 == 0) {
                p4++;
            }
        }
        double total = p2 + p3 + p4;

        System.out.printf("%.2f%%\n", p2/n*100);
        System.out.printf("%.2f%%\n", p3/n*100);
        System.out.printf("%.2f%%\n", p4/n*100);
    }
}
