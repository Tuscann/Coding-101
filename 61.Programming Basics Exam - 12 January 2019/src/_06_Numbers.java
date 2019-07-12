import java.util.Scanner;

public class _06_Numbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int number = Integer.parseInt(scanner.nextLine());

        int lastDigit = number % 10;
        int secoundDigit = (number % 100) / 10;
        int firstDigit = number / 100;

        int rowsCount = firstDigit + secoundDigit;
        int numbersOnRow = firstDigit + lastDigit;

        int currentNumber = number;

        for (int i = 0; i < rowsCount; i++) {
            for (int j = 0; j < numbersOnRow; j++) {

                if (currentNumber % 5 == 0) {
                    currentNumber -= firstDigit;
                } else if (currentNumber % 3 == 0) {
                    currentNumber -= secoundDigit;
                } else {
                    currentNumber += lastDigit;
                }
                System.out.print(currentNumber + " ");
            }
            System.out.println();
        }
    }
}
