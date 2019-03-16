import java.util.Scanner;

public class _06_Safe_Passwords_Generator {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int a = Integer.parseInt(scan.nextLine());
        int b = Integer.parseInt(scan.nextLine());
        int maxPasswords = Integer.parseInt(scan.nextLine());

        char bigA = 35;
        char bigB = 64;

        int counter=0;

        for (int j = 1; j <= a; j++) {
            for (int k = 1; k <= b; k++) {
                counter++;
                if (counter>maxPasswords){
                    break;
                }
                System.out.print("" + bigA + bigB);
                System.out.print(j);
                System.out.print(k);
                System.out.print("" + bigB + bigA + "|");

                bigA++;
                bigB++;

                if (bigA > 55) {
                    bigA = 35;
                }
                if (bigB > 96) {
                    bigB = 64;
                }
            }
        }
    }
}
