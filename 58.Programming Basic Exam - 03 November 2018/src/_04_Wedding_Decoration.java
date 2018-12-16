import java.util.Scanner;

public class _04_Wedding_Decoration {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int budjet = Integer.parseInt(scan.nextLine());
        StringBuilder print = new StringBuilder("Purchased decoration is");

        while (true) {
            String type = scan.nextLine();
            int count = Integer.parseInt(scan.nextLine());
            double numberr = 0;


            switch (type) {
                case "flowers":
                    budjet -= count * 1.5;
                    break;
                case "balloons":
                    budjet -= count * 0.1;
                    break;
                case "candles":
                    budjet -= count * 0.5;
                    break;
                case "ribbon":
                    budjet -= count * 2;
                    break;
            }

            if (budjet < 0) {
                System.out.println("All money is spent!");

            } else {
                if (type.equals("balloons")) {
                    print.append(" ").append(count).append(" ").append(type);
                }


            }


        }
    }
}
