import java.util.Scanner;

public class _04_Puppy_Care {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int needFood = Integer.parseInt(scan.nextLine()) * 1000;
        while (true) {
            String cuurent = scan.nextLine();

            if (cuurent.equals("Adopted")) {
                break;
            }
            int gramsFood = Integer.parseInt(cuurent);
            needFood -= gramsFood;
        }

        if (needFood >= 0) {
            System.out.println("Food is enough! Leftovers: " + needFood + " grams.");
        } else {
            System.out.println("Food is not enough. You need " + needFood * -1 + " grams more.");
        }
    }
}
