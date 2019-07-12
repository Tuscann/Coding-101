import java.util.Scanner;

public class _01_Change_Bureau {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        Integer countBitcoins = Integer.parseInt(scan.nextLine());
        Double countChiniseCoins = scan.nextDouble();
        Double commission = scan.nextDouble();

        Double result = ((countBitcoins * 1168 + countChiniseCoins * 0.15 * 1.76)/1.95)*(1-commission/100.0);

        System.out.printf("%.2f",result);
    }
}
