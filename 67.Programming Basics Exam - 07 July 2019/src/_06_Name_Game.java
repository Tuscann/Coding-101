import java.util.Scanner;

public class _06_Name_Game {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String name = "";
        int maxPoints = 0;

        while (true) {
            String number = scanner.nextLine();
            if (number.equals("Stop")) {
                break;
            }
            int sum = 0;
            for (int i = 0; i < number.length(); i++) {

                int currentNumber = Integer.parseInt(scanner.nextLine());

                if ((int) number.charAt(i) == currentNumber) {
                    sum += 10;
                } else {
                    sum += 2;
                }
            }
            if (sum >= maxPoints) {
                maxPoints = sum;
                name = number;
            }
        }
        System.out.printf("The winner is %s with %d points!", name, maxPoints);
    }
}
