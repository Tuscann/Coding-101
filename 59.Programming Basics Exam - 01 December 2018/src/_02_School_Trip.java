import java.util.Scanner;

public class _02_School_Trip {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int countMissingDays = scan.nextInt();
        int kilogramsFood = scan.nextInt();
        double foodFirstDog = scan.nextDouble();
        double foodSecoundDog = scan.nextDouble();
        double foodThirdDog = scan.nextDouble();

        double total = countMissingDays * (foodFirstDog + foodSecoundDog + foodThirdDog);
        if (total <= kilogramsFood) {
            System.out.printf("%.0f kilos of food left.",Math.floor(kilogramsFood - total) );
        } else {
            System.out.printf("%.0f more kilos of food are needed.", Math.ceil(total - kilogramsFood));
        }

    }
}
