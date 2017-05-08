package PbExam;

import java.util.Scanner;

public class p02ToyShop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double tripPrice = Double.parseDouble(scanner.nextLine());
        double puzzelCount = Double.parseDouble(scanner.nextLine());
        double speakToysCount = Double.parseDouble(scanner.nextLine());
        double plusheniCount = Double.parseDouble(scanner.nextLine());
        double minionsCount = Double.parseDouble(scanner.nextLine());
        double tirCount = Double.parseDouble(scanner.nextLine());

        double totalMoney = puzzelCount*2.6+speakToysCount*3+plusheniCount*4.1+minionsCount*8.2+tirCount*2;
        double totalToys = puzzelCount+speakToysCount+plusheniCount+minionsCount+tirCount;
        if(totalToys >= 50) {
            totalMoney = totalMoney*0.75;
        }
        totalMoney = totalMoney*0.9;

        if(totalMoney >= tripPrice) {
            System.out.printf("Yes! %.2f lv left.",totalMoney-tripPrice);
        } else {
            System.out.printf("Not enough money! %.2f lv needed.",tripPrice-totalMoney);
        }


    }
}
