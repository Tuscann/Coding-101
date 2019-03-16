import java.util.Scanner;

public class _02_Christmas_Market {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double priceNeeded = Double.parseDouble(scan.nextLine());
        int counterFentesyBooks = Integer.parseInt(scan.nextLine());
        int counterHorrorBooks = Integer.parseInt(scan.nextLine());
        int counterRomanticBooks = Integer.parseInt(scan.nextLine());

        double sum = (counterFentesyBooks * 14.9 + counterHorrorBooks * 9.8 + counterRomanticBooks * 4.3) * 0.8;

        if (sum > priceNeeded) {
            double totall = Math.floor((sum - priceNeeded) * 0.1);
            System.out.printf("%.2f leva donated.\n", sum - totall);
            System.out.printf("Sellers will receive %.0f leva.", totall);
        } else {
            System.out.printf("%.2f money needed.", priceNeeded - sum);
        }
    }
}
