package PbExam;

import java.util.Scanner;

public class p01AlcoholMarket {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double whiskeyPrice = Double.parseDouble(scanner.nextLine());
        double beerLiters = Double.parseDouble(scanner.nextLine());
        double wineLiters = Double.parseDouble(scanner.nextLine());
        double rakiaLiters = Double.parseDouble(scanner.nextLine());
        double whiskeyLiters = Double.parseDouble(scanner.nextLine());

        double priceRakia = whiskeyPrice/2;
        double winePrice = priceRakia-(0.4*priceRakia);
        double beerPrice = priceRakia-(0.8*priceRakia);

        double totalRakia = rakiaLiters*priceRakia;
        double totalWine = wineLiters*winePrice;
        double totalBeer = beerLiters*beerPrice;
        double totalWhiskey = whiskeyLiters*whiskeyPrice;

        double result = totalRakia+totalWine+totalBeer+totalWhiskey;
        System.out.printf("%.2f",result);


    }
}
