import java.util.Scanner;

public class _04_Cinema_Voucher {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int vaucherMoney = Integer.parseInt(scan.nextLine());
        int counterMovies = 0;
        int counterOther = 0;

        while (true) {
            String buyThings = scan.nextLine();
            if (buyThings.equals("End")) {
                break;
            }

            int price = buyThings.toCharArray()[0];

            if (buyThings.length() > 8) {
                price += +buyThings.toCharArray()[1];

                if (vaucherMoney - price >= 0) {
                    vaucherMoney -= price;
                    counterMovies++;
                } else {
                    break;
                }

            } else {
                if (vaucherMoney - price >= 0) {
                    vaucherMoney -= price;
                    counterOther++;
                } else {
                    break;
                }
            }
        }
        System.out.println(counterMovies);
        System.out.println(counterOther);
    }
}
