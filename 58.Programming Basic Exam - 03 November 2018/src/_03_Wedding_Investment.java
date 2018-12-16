import java.util.Scanner;

public class _03_Wedding_Investment {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String dogovorLenght = scan.nextLine();
        String dogovorType = scan.nextLine();
        String desert = scan.nextLine();
        int months = Integer.parseInt(scan.nextLine());
        double price = 0;

        if (dogovorLenght.equals("one")) {
            if (dogovorType.equals("Small")) {
                price = 9.98;
            } else if (dogovorType.equals("Middle")) {
                price = 18.99;
            } else if (dogovorType.equals("Large")) {
                price = 25.98;
            } else if (dogovorType.equals("ExtraLarge")) {
                price = 35.99;
            }
        } else if (dogovorLenght.equals("two")) {
            if (dogovorType.equals("Small")) {
                price = 8.58;
            } else if (dogovorType.equals("Middle")) {
                price = 17.09;
            } else if (dogovorType.equals("Large")) {
                price = 23.59;
            } else if (dogovorType.equals("ExtraLarge")) {
                price = 31.79;
            }
        }
        if (desert.equals("yes")) {
            if (price <= 10.00) {
                price += 5.50;
            } else if (price <= 30) {
                price += 4.35;
            } else {
                price += 3.85;
            }
        }
        if (dogovorLenght.equals("two")) {
            price *= (1.00 - 0.0375);
        }
        System.out.printf("%.2f lv.", price * months);
    }
}
