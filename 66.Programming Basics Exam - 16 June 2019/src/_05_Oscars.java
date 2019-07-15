import java.util.Scanner;

public class _05_Oscars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String nameActor = scanner.nextLine();
        double pointsAcademy = Double.parseDouble(scanner.nextLine());
        int countEvaluations = Integer.parseInt(scanner.nextLine());

        double totalSum = pointsAcademy;

        for (int i = 0; i < countEvaluations; i++) {
            String name = scanner.nextLine();
            double pointsFromEvaluation = Double.parseDouble(scanner.nextLine());

            double sum = (name.length() * pointsFromEvaluation) / 2;
            totalSum += sum;
            if (totalSum > 1250.5) {
                System.out.printf("Congratulations, %s got a nominee for leading role with %.1f!", nameActor, totalSum);
                break;
            }
        }
        if (totalSum < 1250.5) {
            System.out.printf("Sorry, %s you need %.1f more!", nameActor, 1250.5 - totalSum);
        }
    }
}
