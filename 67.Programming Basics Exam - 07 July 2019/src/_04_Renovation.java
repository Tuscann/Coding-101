import java.util.Scanner;

public class _04_Renovation {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int heightWall = Integer.parseInt(scanner.nextLine());
        int withWall = Integer.parseInt(scanner.nextLine());
        int prozent = Integer.parseInt(scanner.nextLine());

        double paint = heightWall * withWall * 4 * (1 - prozent / 100.0);

        while (true) {
            String litersPaint = scanner.nextLine();
            if (litersPaint.equals("Tired!")) {
                break;
            }
            int currentPaint = Integer.parseInt(litersPaint);
            paint -= currentPaint;

            if (paint <= 0) {
                break;
            }
        }

        if (paint > 0) {
            System.out.printf("%.0f quadratic m left.", paint);
        } else if (paint == 0) {
            System.out.println("All walls are painted! Great job, Pesho!");
        } else {
            System.out.printf("All walls are painted and you have %.0f l " +
                    "paint left!", paint * -1);
        }
    }
}
