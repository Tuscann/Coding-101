import java.util.Scanner;

public class _06_Favorite_Movie {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int a1 = Integer.parseInt(scanner.nextLine());
        int a2 = Integer.parseInt(scanner.nextLine());
        int n = Integer.parseInt(scanner.nextLine());

        for (char a = (char) a1; a < (char) a2; a++) {
            for (int b = 1; b < n; b++) {
                for (int c = 1; c < n / 2; c++) {
                    if (a % 2 != 0 && (a + b + c) % 2 != 0) {
                        System.out.printf("%s-%d%d%d\n", a, b, c, (int) a);
                    }
                }
            }
        }
    }
}
