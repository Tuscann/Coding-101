import java.util.Scanner;

public class _06_The_Most_Powerful_Word {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double maxSum = 0;
        String name = "";

        while (true) {
            String word = scanner.nextLine();
            if (word.equals("End of words")) {
                break;
            }
            double sum = 0;
            boolean isfond = false;

            for (int i = 0; i < word.length(); i++) {
                sum += word.charAt(i);
                if (word.toLowerCase().startsWith("a") ||
                        word.toLowerCase().startsWith("e") ||
                        word.toLowerCase().startsWith("i") ||
                        word.toLowerCase().startsWith("o") ||
                        word.toLowerCase().startsWith("u") ||
                        word.toLowerCase().startsWith("y")) {
                    isfond = true;
                }
            }

            if (!isfond) {
                sum = sum / word.length();
            } else {
                sum = sum * word.length();
            }
            if (sum > maxSum) {
                maxSum = sum;
                name = word;
            }
        }
        System.out.printf("The most powerful word is %s - %.0f", name, Math.ceil(maxSum));
    }
}
