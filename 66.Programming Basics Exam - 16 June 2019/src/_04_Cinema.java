import java.util.Scanner;

public class _04_Cinema {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int countSeats = Integer.parseInt(scanner.nextLine());

        int sum = 0;
        while (true) {
            String currentPeople = scanner.nextLine();
            if (currentPeople.equals("Movie time!")) {
                System.out.printf("There are %d seats left in the cinema.\n", countSeats);
                break;
            }
            int incomeFee = Integer.parseInt(currentPeople);
            if (countSeats - incomeFee < 0) {
                System.out.println("The cinema is full.");
                break;
            } else {
                countSeats -= incomeFee;
                int summm = incomeFee * 5;

                if (incomeFee % 3 == 0) {
                    summm -= 5;
                }
                sum += summm;
            }
        }
        System.out.printf("Cinema income - %d lv.", sum);
    }
}
