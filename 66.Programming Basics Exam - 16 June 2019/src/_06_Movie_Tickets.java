import java.util.Scanner;

public class _06_Movie_Tickets {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int maxSum = -1;
        int movieCounter = 0;
        String bestMovie = "";

        while (true) {
            String input = scan.nextLine();

            if (input.equals("STOP")) {
                break;
            }

            int currentSum = 0;
            movieCounter++;
            for (int i = 0; i < input.length(); i++) {
                int currentChar = input.charAt(i);
                currentSum += currentChar;
                if (currentChar >= 65 && currentChar <= 90) {
                    currentSum -= input.length();
                } else if (currentChar >= 97 && currentChar <= 122) {
                    currentSum -= input.length() * 2;
                }
            }
            if (currentSum > maxSum) {
                maxSum = currentSum;
                bestMovie = input;
            }
            if (movieCounter >= 7) {
                break;
            }
        }

        if (movieCounter >= 7) {
            System.out.println("The limit is reached.");
        }
        System.out.printf("The best movie for you is %s with %d ASCII sum.", bestMovie, maxSum);
    }
}
