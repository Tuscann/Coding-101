import java.util.Scanner;

public class _02_Lunch_Break {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String name = scanner.nextLine();
        double episode = Integer.parseInt(scanner.nextLine());
        int rest = Integer.parseInt(scanner.nextLine());

        double sum = rest * (1 - 0.125 - 0.250);

        if (episode - sum <= 0) {
            System.out.printf("You have enough time to watch %s and left with %d minutes free time.", name, (int) Math.ceil(episode - sum));
        } else {
            System.out.printf("You don't have enough time to watch %s, you need %d more minutes.", name, (int) Math.ceil(episode - sum));
        }
    }
}