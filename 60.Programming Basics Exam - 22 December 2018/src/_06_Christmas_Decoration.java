import java.util.Scanner;

public class _06_Christmas_Decoration {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int budjet = Integer.parseInt(scan.nextLine());


        while (true) {
            String input = scan.nextLine();
            if (input.equals("Stop")) {
                System.out.println("Money left: " + budjet);
                break;
            }

            int sum = 0;
            char[] letters = input.toCharArray();

            for (char ch : letters) {
                sum += ch;
            }

            if (budjet - sum > 0) {
                budjet -= sum;

                System.out.println("Item successfully purchased!");
            } else {
                System.out.println("Not enough money!");
                break;
            }
        }


    }
}
