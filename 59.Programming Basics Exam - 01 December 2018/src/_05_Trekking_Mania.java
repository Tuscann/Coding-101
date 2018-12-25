import java.util.Scanner;

public class _05_Trekking_Mania {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int counters = Integer.parseInt(scan.nextLine());
        int sum = 0;

        double musala = 0;
        double monblan = 0;
        double kilimanjaro = 0;
        double k2 = 0;
        double everest = 0;

        for (int i = 0; i < counters; i++) {
            int current = Integer.parseInt(scan.nextLine());
            if (current <= 5) {
                musala += current;
            } else if (current <= 12) {
                monblan += current;
            } else if (current <= 25) {
                kilimanjaro += current;
            } else if (current <= 40) {
                k2 += current;
            } else {
                everest += current;
            }
            sum += current;
        }

        System.out.printf("%.2f%%\n", musala / sum * 100);
        System.out.printf("%.2f%%\n", monblan / sum * 100);
        System.out.printf("%.2f%%\n", kilimanjaro / sum * 100);
        System.out.printf("%.2f%%\n", k2 / sum * 100);
        System.out.printf("%.2f%%\n", everest / sum * 100);
    }
}
