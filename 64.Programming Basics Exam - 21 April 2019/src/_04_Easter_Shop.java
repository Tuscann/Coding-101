import java.util.Scanner;

public class _04_Easter_Shop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int eggsCount = Integer.parseInt(scanner.nextLine());
        int cellEggs = 0;

        while (true) {
            String current = scanner.nextLine();
            if (current.equals("Close")) {
                System.out.println("Store is closed!");
                System.out.printf("%d eggs sold.", cellEggs);
                break;
            }
            int buyEggs = Integer.parseInt(scanner.nextLine());

            if (current.equals("Buy")) {
                eggsCount -= buyEggs;
                cellEggs += buyEggs;

                if (eggsCount < 0) {
                    System.out.println("Not enough eggs in store!");
                    System.out.printf("You can buy only %d.", eggsCount + buyEggs);
                    break;
                }
            }
            else if (current.equals("Fill")) {
                eggsCount += buyEggs;
            }
        }
    }
}