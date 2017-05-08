package PbExam;

import java.util.Scanner;

public class p04FootballLeague {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double capacity = Double.parseDouble(scanner.nextLine());
        double fenCount = Double.parseDouble(scanner.nextLine());

        double a = 0;
        double b = 0;
        double v = 0;
        double g = 0;

        for (int i = 0; i < fenCount; i++) {
            char c = scanner.next().charAt(0);

            switch (c) {
                case 'A':
                    a++;
                    break;
                case 'B':
                    b++;
                    break;
                case 'V':
                    v++;
                    break;
                case 'G':
                    g++;
                    break;
            }
        }

        double capacitySum = fenCount/capacity*100;
        System.out.printf("%.2f%%%n",a/fenCount*100);
        System.out.printf("%.2f%%%n",b/fenCount*100);
        System.out.printf("%.2f%%%n",v/fenCount*100);
        System.out.printf("%.2f%%%n",g/fenCount*100);
        System.out.printf("%.2f%%",capacitySum);
    }
}
