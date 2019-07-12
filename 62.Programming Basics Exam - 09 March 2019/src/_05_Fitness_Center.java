import java.util.Scanner;

public class _05_Fitness_Center {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double count = Integer.parseInt(scanner.nextLine());

        int countBack = 0;
        int countChest = 0;
        int countLegs = 0;
        int countAbs = 0;
        double countProteinShake = 0;
        double countProteinBar = 0;

        for (int i = 0; i < count; i++) {
            String current = scanner.nextLine();

            if (current.equals("Back")) {
                countBack++;
            } else if (current.equals("Chest")) {
                countChest++;
            } else if (current.equals("Abs")) {
                countAbs++;
            } else if (current.equals("Legs")) {
                countLegs++;
            } else if (current.equals("Protein shake")) {
                countProteinShake++;
            } else if (current.equals("Protein bar")) {
                countProteinBar++;
            }
        }
        System.out.printf("%d - back\n", countBack);
        System.out.printf("%d - chest\n", countChest);
        System.out.printf("%d - legs\n", countLegs);
        System.out.printf("%d - abs\n", countAbs);
        System.out.printf("%.0f - protein shake\n", countProteinShake);
        System.out.printf("%.0f - protein bar\n", countProteinBar);
        double traings = ((count - (countProteinBar + countProteinShake)) / count) * 100.00;
        System.out.printf("%.2f", traings);
        System.out.println("% - work out");
        System.out.printf("%.2f", 100 - traings);
        System.out.println("% - protein");
    }
}
