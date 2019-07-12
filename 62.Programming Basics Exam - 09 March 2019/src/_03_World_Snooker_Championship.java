import java.util.Scanner;

public class _03_World_Snooker_Championship {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String stage = scanner.nextLine();
        String ticketType = scanner.nextLine();
        int countTickets = Integer.parseInt(scanner.nextLine());
        String Picture = scanner.nextLine();

        double priceStandard = 0;
        double pricePremium = 0;
        double priceVIP = 0;

        boolean isTakenPicture = false;

        if (stage.equals("Quarter final")) {
            priceStandard = 55.5;
            pricePremium = 105.2;
            priceVIP = 118.9;

        } else if (stage.equals("Semi final")) {
            priceStandard = 75.88;
            pricePremium = 125.22;
            priceVIP = 300.40;
        } else if (stage.equals("Final")) {
            priceStandard = 110.10;
            pricePremium = 160.66;
            priceVIP = 400;
        }

        double sum = 0;

        if (ticketType.equals("Standard")) {
            sum = countTickets * priceStandard;
        } else if (ticketType.equals("Premium")) {
            sum = countTickets * pricePremium;
        } else if (ticketType.equals("VIP")) {
            sum = countTickets * priceVIP;
        }

        if (sum > 4000.00) {
            sum *= 0.75;
            isTakenPicture = true;

        } else if (sum > 2500) {
            sum *= 0.9;
        }
        if (isTakenPicture == false && Picture.equals("Y")) {
            sum += (countTickets * 40);
        }
        System.out.printf("%.2f", sum);
    }
}
