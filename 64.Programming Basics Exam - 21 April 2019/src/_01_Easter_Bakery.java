import java.util.Scanner;

public class _01_Easter_Bakery {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double priceFlour = Double.parseDouble(scanner.nextLine());
        double kilogramsFlour = Double.parseDouble(scanner.nextLine());
        double kilogramsSugar = Double.parseDouble(scanner.nextLine());
        int eggs = Integer.parseInt(scanner.nextLine());
        int maq = Integer.parseInt(scanner.nextLine());

        double priceSugarKilograms = priceFlour * 0.75;
        double priceEggsKilograms = priceFlour * 1.1;
        double priceMaq = priceSugarKilograms * 0.2;

        double sum = priceFlour * kilogramsFlour + priceSugarKilograms * kilogramsSugar
                + priceEggsKilograms * eggs + priceMaq * maq;
        System.out.printf("%.2f",sum);
    }
}
