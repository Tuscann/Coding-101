import java.util.Scanner;

public class _05_Series {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double budjet = Double.parseDouble(scanner.nextLine());
        int countSerials = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < countSerials; i++) {
            String nameSerial = scanner.nextLine();
            double priceSerial = Double.parseDouble(scanner.nextLine());

            switch (nameSerial) {
                case "Thrones":
                    priceSerial *= 0.5;
                    break;
                case "Lucifer":
                    priceSerial *= 0.6;
                    break;
                case "Protector":
                    priceSerial *= 0.7;
                    break;
                case "TotalDrama":
                    priceSerial *= 0.8;
                    break;
                case "Area":
                    priceSerial *= 0.9;
                    break;
            }
            budjet -= priceSerial;
        }
        if (budjet >= 0) {
            System.out.printf("You bought all the series and left with %.2f lv.", budjet);
        } else {
            System.out.printf("You need %.2f lv. more to buy the series!", budjet * -1);
        }
    }
}
