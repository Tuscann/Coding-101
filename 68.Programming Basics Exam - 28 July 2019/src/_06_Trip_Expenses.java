import java.util.Scanner;

public class _06_Trip_Expenses {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int restDays = Integer.parseInt(scan.nextLine());
        double startMoney = 60;

        for (int i = 0; i < restDays; i++) {
            int counter = 0;
            while (true) {
                String priceProdust = scan.nextLine();

                if (priceProdust.equals("Day over")) {
                    System.out.printf("Money left from today: %.2f. You've bought %d products.\n", startMoney, counter);
                    startMoney += 60;
                    break;
                }

                double money = Double.parseDouble(priceProdust);

                if (!(startMoney < money)) {
                    if (startMoney - money < 0) {
                        System.out.printf("Money left from today: %.2f. You've bought %d products.\n", startMoney, counter);
                        break;
                    } else if (startMoney - money == 0) {
                        startMoney -= money;
                        counter += 1;
                        System.out.printf("Daily limit exceeded! You've bought %d products.\n", counter);
                        startMoney += 60;
                        break;
                    } else {
                        startMoney -= money;
                        counter += 1;
                    }
                }
            }
        }
    }
}
