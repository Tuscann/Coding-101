package PbExam;

import java.util.Scanner;

public class p06NumberGeneration {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

      int first =  Integer.parseInt(scanner.nextLine());
      int second = Integer.parseInt(scanner.nextLine());
      int three =  Integer.parseInt(scanner.nextLine());

       int special = Integer.parseInt(scanner.nextLine());
       int control = Integer.parseInt(scanner.nextLine());

        for (int i = first; i >= 1; i--) {
            for (int j = second; j >= 1; j--) {
                for (int k = three; k >= 1; k--) {
                    int number = i*100+j*10+k;
                    if(number % 3 == 0) {
                        special += 5;
                    } else if ( number % 5 == 0) {
                        special -= 2;
                    } else if ( number % 2 == 0) {
                        special *= 2;
                    }

                    if(special >= control) {
                        System.out.printf("Yes! Control number was reached! Current special number is %d.",special);
                        return;
                    }
                }
            }
        }

        if(special < control) {
            System.out.printf("No! %d is the last reached special number.",special);
        }



    }
}
