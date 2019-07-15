import java.util.Scanner;

public class _04_Movie_Stars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double budjet = Double.parseDouble(scanner.nextLine());

        while (true) {
            String actiorName = scanner.nextLine();
            if (actiorName.equals("ACTION")) {
                break;
            }
            double money;
            if (actiorName.length() <= 15) {
                money = Double.parseDouble(scanner.nextLine());
            } else {
                money = 0.2 * budjet;
            }
            budjet -= money;
            if (budjet < 0) {
                System.out.printf("We need %.2f leva for our actors.", budjet * -1);
                break;
            }
        }
        if (budjet >= 0) {
            System.out.printf("We are left with %.2f leva.", budjet);
        }
    }
}
