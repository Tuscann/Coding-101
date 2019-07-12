import java.util.Scanner;

public class _03_Gymnastics {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String country = scanner.nextLine();
        String tool = scanner.nextLine();

        double difficulty = 0;
        double performance = 0;

        if (country.equals("Russia")) {

            if (tool.equals("ribbon")) {
                difficulty = 9.1;
                performance = 9.4;
            } else if (tool.equals("hoop")) {
                difficulty = 9.3;
                performance = 9.8;
            } else if (tool.equals("rope")) {
                difficulty = 9.6;
                performance = 9;
            }
        } else if (country.equals("Bulgaria")) {
            if (tool.equals("ribbon")) {
                difficulty = 9.6;
                performance = 9.4;
            } else if (tool.equals("hoop")) {
                difficulty = 9.55;
                performance = 9.75;
            } else if (tool.equals("rope")) {
                difficulty = 9.5;
                performance = 9.4;
            }
        } else if (country.equals("Italy")) {
            if (tool.equals("ribbon")) {
                difficulty = 9.2;
                performance = 9.5;
            } else if (tool.equals("hoop")) {
                difficulty = 9.45;
                performance = 9.35;
            } else if (tool.equals("rope")) {
                difficulty = 9.7;
                performance = 9.15;
            }
        }
        double sum=20-(difficulty+performance);

        System.out.printf("The team of %s get %.3f on %s.\n",country,(difficulty+performance),tool);
        System.out.printf("%.2f",(100.00- ((20-sum)/20.0)*100));
        System.out.println("%");

    }
}
