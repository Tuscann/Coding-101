import java.util.Scanner;

public class _05_Gifts_from_Santa {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = Integer.parseInt(scan.nextLine());
        int m = Integer.parseInt(scan.nextLine());
        int s = Integer.parseInt(scan.nextLine());

        for (int i = m; i >= n; i--) {
            if (i % 6 == 0) {
                if (i == s) {
                    break;
                }
                System.out.print(i + " ");
            }
        }
    }
}
