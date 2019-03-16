import java.util.Scanner;

public class _04_Wedding_Decoration {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double budjet = Double.parseDouble(scan.nextLine());
        double before = budjet;

        int flowers = 0;
        int ballons = 0;
        int candles = 0;
        int ribbon = 0;

        while (true) {
            String type = scan.nextLine();


            if (type.equals("stop")) {
                break;
            }

            int count = Integer.parseInt(scan.nextLine());

            if (budjet < 0) {
                break;
            }
            switch (type) {
                case "flowers":
                    budjet -= count * 1.5;
                    flowers += count;
                    break;
                case "balloons":
                    budjet -= count * 0.1;
                    ballons += count;
                    break;
                case "candles":
                    budjet -= count * 0.5;
                    candles += count;
                    break;
                case "ribbon":
                    budjet -= count * 2;
                    ribbon += count;
                    break;
            }

        }

        if (budjet <= 0) {
            System.out.println("All money is spent!");

        } else {
            System.out.printf("Spend money: %.2f\n", before - budjet);
            System.out.printf("Money left: %.2f\n", budjet);
        }
        System.out.printf("Purchased decoration is %d balloons, %d m ribbon, %d flowers and %d candles.", ballons, ribbon, flowers, candles);
    }
}
