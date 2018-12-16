import java.util.Scanner;

public class _01_Wedding_Hall {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        double lenght = scan.nextDouble();
        double with = scan.nextDouble();
        double oneSide = scan.nextDouble();

        double sizeHoll = lenght * with;
        double dansing = Math.ceil((sizeHoll - oneSide * oneSide - sizeHoll * 0.19) / 3.2);

        System.out.println((int)dansing);
    }
}
