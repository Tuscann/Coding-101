import java.util.Scanner;

public class _06_Challenge_the_Wedding {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int countMens = Integer.parseInt(scan.nextLine());
        int countWomens = Integer.parseInt(scan.nextLine());
        int maxs = Integer.parseInt(scan.nextLine());
        int counter = 0;

        for (int i = 1; i <= countMens; i++) {
            for (int j = 1; j <= countWomens; j++) {
                counter++;

                if (counter > maxs) {
                    break;
                }

                System.out.print("(" + i + " <-> " + j + ") ");
            }
        }
    }
}
