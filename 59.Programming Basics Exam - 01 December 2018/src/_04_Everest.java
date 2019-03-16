import java.util.Scanner;

public class _04_Everest {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int counter = 1;

        int startHeight = 5364;

        while (true) {
            String isSleeping = scan.nextLine();
            if (isSleeping.equals("Yes")) {
                counter++;
            }
            if (isSleeping.equals("END") || counter == 6) {
                System.out.println("Failed!");
                System.out.println(startHeight);
                break;
            }
            startHeight += Integer.parseInt(scan.nextLine());

            if (startHeight>= 8848) {
                System.out.printf("Goal reached for %d days!", counter);
                break;
            }
        }
    }
}
