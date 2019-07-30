import java.util.Scanner;

public class _03_Luggage_Tax {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int width = Integer.parseInt(scan.nextLine());
        int height = Integer.parseInt(scan.nextLine());
        int length = Integer.parseInt(scan.nextLine());
        String priority = scan.nextLine();

        double size = width * height * length;

        double tax = 0;
        if (priority.equals("true")) {
            if (size >= 50 && size <= 100) {
                tax = 0;
            } else if (size > 100 && size <= 200) {
                tax = 10;
            } else if (size > 200 && size <= 300) {
                tax = 20;
            }
        } else if (priority.equals("false")) {
            if (size >= 50 && size <= 100) {
                tax = 25;
            } else if (size > 100 && size <= 200) {
                tax = 50;
            } else if (size > 200 && size <= 300) {
                tax = 100;
            }
        }
        System.out.printf("Luggage tax: %.2f", tax);
    }
}