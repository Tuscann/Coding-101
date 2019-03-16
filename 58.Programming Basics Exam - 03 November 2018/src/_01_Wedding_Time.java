import java.util.Scanner;

public class _01_Wedding_Time {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double priceYuski = scan.nextDouble();
        double waterLiters = scan.nextDouble();
        double wineLiters = scan.nextDouble();
        double champaionLiters = scan.nextDouble();
        double yuisckiLiters = scan.nextDouble();

        double priceChampins = 0.5 * priceYuski;
        double priceWine = priceChampins * 0.4;
        double priceWater = priceChampins * 0.1;

        double sum = champaionLiters * priceChampins + wineLiters * priceWine + waterLiters * priceWater + yuisckiLiters * priceYuski;

        System.out.printf("%.2f",sum);

    }
}
