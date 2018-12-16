import java.util.Scanner;

public class _01_Trekking_equipment {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int mountainsClimbers = scan.nextInt();
        int policeMans = scan.nextInt();
        int countRopes = scan.nextInt();
        int countPikels = scan.nextInt();

        double total = (policeMans * 36 + countRopes * 3.60 + countPikels * 19.8) * mountainsClimbers * 1.2;

        System.out.printf("%.2f", total);
    }
}
