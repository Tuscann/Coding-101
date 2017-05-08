package PbExam;

import java.util.Scanner;

public class p03SchoolCamp {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String season = scanner.nextLine();
        String pol = scanner.nextLine();
        int uchenici = Integer.parseInt(scanner.nextLine());
        int nights = Integer.parseInt(scanner.nextLine());


        double priceForNight = 0;
        String sport = "";
        switch (season) {
            case "Spring":
                if("mixed".equals(pol)) {
                    priceForNight = 9.5;
                    sport = "Cycling";
                } else if("girls".equals(pol)) {
                    sport = "Athletics";
                    priceForNight = 7.2;
                } else {
                    sport = "Tennis";
                    priceForNight = 7.2;
                }
                break;
            case "Summer":
                if("mixed".equals(pol)) {
                    priceForNight = 20;
                    sport = "Swimming";
                } else if("girls".equals(pol)) {
                    sport = "Volleyball";
                    priceForNight = 15;
                } else {
                    sport = "Football";
                    priceForNight = 15;
                }
                break;
            case "Winter":
                if("mixed".equals(pol)) {
                    priceForNight = 10;
                    sport = "Ski";
                } else if("girls".equals(pol)) {
                    sport = "Gymnastics";
                    priceForNight = 9.6;
                } else {
                    sport = "Judo";
                    priceForNight = 9.6;
                }
                break;
        }

        double result = priceForNight*uchenici*nights;
        if(uchenici >= 50) {
            result *= 0.5;
        } else if (uchenici < 50 && uchenici >= 20) {
            result *= 0.85;
        } else if (uchenici < 20 && uchenici >= 10) {
            result *= 0.95;
        }
        System.out.printf("%s %.2f lv.",sport,result);
    }
}
