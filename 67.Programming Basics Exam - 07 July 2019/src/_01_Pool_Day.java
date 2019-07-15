import java.util.Scanner;

public class _01_Pool_Day {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int countPeople = Integer.parseInt(scanner.nextLine());
        double inFee = Double.parseDouble(scanner.nextLine());
        double pricebed = Double.parseDouble(scanner.nextLine());
        double priceShezlong = Double.parseDouble(scanner.nextLine());

        double sum = countPeople * inFee + Math.ceil(countPeople * 0.75) * pricebed
                + Math.ceil(0.5 * countPeople) * priceShezlong;
        System.out.printf("%.2f lv.", sum);
    }
}
