import java.sql.SQLOutput;
import java.util.Scanner;

public class _05_Easter_Bake {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int count = Integer.parseInt(scanner.nextLine());

        int maxSugarGrams = 0;
        int maxFlourGrams = 0;
        int totalSugar = 0;
        int totalFlour = 0;

        for (int i = 0; i < count; i++) {
            int sugarGrams = Integer.parseInt(scanner.nextLine());
            int flourGrams = Integer.parseInt(scanner.nextLine());

            totalFlour += flourGrams;
            totalSugar += sugarGrams;

            if (sugarGrams > maxSugarGrams) {
                maxSugarGrams = sugarGrams;
            }
            if (flourGrams > maxFlourGrams) {
                maxFlourGrams = flourGrams;
            }
        }

        int packetsSugar = totalSugar / 950;
        int packetsFlour = totalFlour / 750;

        if (totalSugar % 950 != 0) {
            packetsSugar++;
        }
        if (totalFlour % 750 != 0) {
            packetsFlour++;
        }

        System.out.printf("Sugar: %d\n", packetsSugar);
        System.out.printf("Flour: %d\n", packetsFlour);
        System.out.printf("Max used flour is %d grams, max used sugar is %d grams.", maxFlourGrams, maxSugarGrams);
    }
}
