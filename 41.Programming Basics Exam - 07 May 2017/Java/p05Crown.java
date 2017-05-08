package PbExam;

import java.util.Scanner;

public class p05Crown {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        int topSpace = ((2*n)-4)/2;
        int secondRow = ((2*n)-6)/2;

        System.out.printf("@%s@%s@%n",print(" ",topSpace),print(" ",topSpace));
        System.out.printf("**%s*%s**%n",print(" ",secondRow),print(" ",secondRow));

        int dot = 1;
        int middleSpaces = ((2*n)-10)/2;
        int middleDot = 1;

        for (int i = 0; i < n / 2-2; i++) {
            System.out.printf("*%s*%s*%s*%s*%s*%n",
                    print(".",dot),
                    print(" ",middleSpaces),
                    print(".",middleDot),
                    print(" ",middleSpaces),
                    print(".",dot));

            dot++;
            middleSpaces-=2;
            middleDot +=2;
        }

        int d = ((n*2)-1)-(((n/2-1)*2)+4);
        System.out.printf("*%s*%s*%s*%n",
                print(".",n/2-1),
                print(".",d),
                print(".",n/2-1));

        int bottomDot = (((2*n)-1)-(n+3))/2;
        System.out.printf("*%s%s.%s%s*%n",
        print(".",n/2),
                print("*",bottomDot),
                print("*",bottomDot),
                print(".",n/2));

        for (int i = 0; i < 2; i++) {
            System.out.println(print("*",(2*n)-1));
        }
    }
    private static String print(String element,int count) {
        return new String(new char[count]).replace("\0",element);
    }
}
