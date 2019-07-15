import java.util.Scanner;

public class _03_Travel_Agency {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String cityName = scanner.nextLine();
        String typePacket = scanner.nextLine();
        String vipDiscount = scanner.nextLine();
        int countRestDays = Integer.parseInt(scanner.nextLine());

        if (countRestDays > 7) {
            countRestDays--;
        }

        double price = 0;
        boolean isfound = true;

        if (cityName.equals("Bansko") || cityName.equals("Borovets")) {
            if (typePacket.equals("noEquipment")) {
                price = 80;
                if (vipDiscount.equals("yes")) {
                    price *= 0.95;
                }
            } else if (typePacket.equals("withEquipment")) {
                price = 100;
                if (vipDiscount.equals("yes")) {
                    price *= 0.9;
                }
            } else if (!vipDiscount.equals("no")) {
                System.out.println("Invalid input!");
                isfound = false;
            }
        } else if (cityName.equals("Varna") || cityName.equals("Burgas")) {
            if (typePacket.equals("noBreakfast")) {
                price = 100;
                if (vipDiscount.equals("yes")) {
                    price *= 0.93;
                }
            } else if (typePacket.equals("withBreakfast")) {
                price = 130;
                if (vipDiscount.equals("yes")) {
                    price *= 0.88;
                }
            } else if (!vipDiscount.equals("no")) {
                System.out.println("Invalid input!");
                isfound = false;
            }
        } else {
            System.out.println("Invalid input!");
            isfound = false;
        }

        if (countRestDays <= 0 && isfound) {
            System.out.println("Days must be positive number!");
        } else if (isfound) {
            double sum2 = price * countRestDays;

            System.out.printf("The price is %.2flv! Have a nice time!", sum2);
        }
    }
}