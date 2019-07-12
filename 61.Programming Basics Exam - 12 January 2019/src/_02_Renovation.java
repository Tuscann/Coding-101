import java.util.Scanner;

public class _02_Renovation {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        Double budjet = scan.nextDouble();
        Double widthFloor = scan.nextDouble();
        Double lenghtFLoor = scan.nextDouble();
        Double sideTriangle = scan.nextDouble();
        Double heightTriangle = scan.nextDouble();
        Double priceTile = scan.nextDouble();
        Double sumCrafstMan = scan.nextDouble();


        double result = ((Math.ceil(widthFloor * lenghtFLoor / (sideTriangle * heightTriangle / 2.0)) + 5) *
                priceTile) + sumCrafstMan;


        if (result > budjet) {
            System.out.printf("You'll need %.2f lv more.", result - budjet);
        } else {
            System.out.printf("%.2f lv left.", budjet - result);
        }
    }
}
