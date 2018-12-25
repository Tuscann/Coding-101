import java.util.Scanner;

public class _06_Math_Puzzle {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int key = Integer.parseInt(scan.nextLine());
        boolean isFound = false;

        for (int i = 1; i <= 30; i++) {
            for (int j = 1; j <= 30; j++) {
                for (int k = 1; k <= 30; k++) {
                    if (i + j + k == key && i < j && j < k) {
                        isFound = true;
                        System.out.println(i + " + " + j + " + " + k + " = " + key);
                    }
                    if (i * j * k == key && i > j && j > k) {
                        isFound = true;
                        System.out.println(i + " * " + j + " * " + k + " = " + key);
                    }
                }
            }
        }
        if (isFound==false) {
            System.out.println("No!");
        }
    }
}
