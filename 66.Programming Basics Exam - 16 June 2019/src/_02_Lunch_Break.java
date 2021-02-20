import java.util.Scanner;

public class _02_Lunch_Break {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String name = scanner.nextLine();
        double episode = Integer.parseInt(scanner.nextLine());
        int rest = Integer.parseInt(scanner.nextLine());

        double timeLeft = rest * (1 - rest/8.0 - rest/4.0);

        if (episode <= timeLeft) {
            System.out.printf("You have enough time to watch %s and left with %.0f minutes free time.", name, Math.ceil(timeLeft - episode));
        } else {
            System.out.printf("You don't have enough time to watch %s, you need %.0f more minutes.", name, Math.ceil(episode - timeLeft));
        }
    }
}