import java.util.Scanner;

public class _04_Christmas_Gifts {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int kids = 0;
        int adults = 0;

        while (true) {
            String x = scan.nextLine();

            if (x.equals("Christmas")) {
                break;
            }
            if (Integer.parseInt(x) <= 16) {
                kids++;
            } else {
                adults++;
            }
        }
        System.out.println("Number of adults: " + adults);
        System.out.println("Number of kids: " + kids);
        System.out.println("Money for toys: " + kids * 5);
        System.out.println("Money for sweaters: " + adults * 15);
    }
}
