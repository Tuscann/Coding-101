import java.util.Scanner;

public class _02_Mountain_Run {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double recordSeconds = scan.nextDouble();
        double distanceMeters = scan.nextDouble();
        double timePerMeter = scan.nextDouble();

        double total = distanceMeters * timePerMeter + Math.floor(distanceMeters / 50) * 30;


        if (total >= recordSeconds) {
            System.out.printf("No! He was %.2f seconds slower.", total - recordSeconds);
        } else {
            System.out.printf("Yes! The new record is %.2f seconds.", total);
        }
    }
}
