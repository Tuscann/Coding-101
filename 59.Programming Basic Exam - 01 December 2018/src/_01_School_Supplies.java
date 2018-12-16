import java.util.Scanner;

public class _01_School_Supplies {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int packetPens = scan.nextInt();
        int packetPensils = scan.nextInt();
        double litersCleaning = scan.nextDouble();
        int discount = scan.nextInt();

        double total = (packetPens * 5.80 + packetPensils * 7.20 + litersCleaning * 1.20);

        double after = total - ((total * discount) / 100);

        System.out.printf("%.3f",after);

    }
}
