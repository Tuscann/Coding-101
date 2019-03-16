import java.util.Scanner;

public class _01_Christmas_Sweets {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double baklavaPrice = Double.parseDouble(scan.nextLine());
        double mufinsPrice = Double.parseDouble(scan.nextLine());
        double sholenPrice = Double.parseDouble(scan.nextLine());
        double switsPrice = Double.parseDouble(scan.nextLine());
        double bickitPrice = Double.parseDouble(scan.nextLine());

        double total = (baklavaPrice * 1.6 * sholenPrice) + (mufinsPrice * 1.8 * switsPrice) + bickitPrice * 7.5;

        System.out.printf("%.2f", total);
    }
}
