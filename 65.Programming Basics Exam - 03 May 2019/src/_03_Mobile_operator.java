import java.util.Scanner;

public class _03_Mobile_operator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String contract = scanner.nextLine();
        String typeContract = scanner.nextLine();
        String typeMobileInternet = scanner.nextLine();
        int mounths = Integer.parseInt(scanner.nextLine());

        double price = 0;

        if (typeContract.equals("Small")) {
            if (contract.equals("one")) {
                price = 9.98;
            } else if (contract.equals("two")) {
                price = 8.58;
            }
        }
        else if (typeContract.equals("Middle")) {
            if (contract.equals("one")) {
                price = 18.99;
            } else if (contract.equals("two")) {
                price = 17.09;
            }
        }
        else if (typeContract.equals("Large")) {
            if (contract.equals("one")) {
                price = 25.98;
            } else if (contract.equals("two")) {
                price = 23.59;
            }
        }else if (typeContract.equals("ExtraLarge")) {
            if (contract.equals("one")) {
                price = 35.99;
            } else if (contract.equals("two")) {
                price = 31.79;
            }
        }
        if (typeMobileInternet.equals("yes")){
            if (price<=10){
                price+=5.5;
            }else if(price<30){
                price+=4.35;
            }else{
                price+=3.85;
            }
        }
        double totalprice=price*mounths;

        if (contract.equals("two")){
totalprice*=(1-0.0375);
        }

        System.out.printf("%.2f lv.",totalprice);
    }
}
