import java.util.Scanner;

public class _01_Tennis_Equipment {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double priceSingleTenisRacket = Double.parseDouble(scanner.nextLine());
        int countTenissRackets = Integer.parseInt(scanner.nextLine());
        int countTennisSneakers = Integer.parseInt(scanner.nextLine());

        double priceRackets = countTenissRackets * priceSingleTenisRacket;
        double priceTenisSneakers = priceSingleTenisRacket / 6.0;
        double priceAllTennisSneakers = priceTenisSneakers * countTennisSneakers;
        double priceOtherEquipment = (priceRackets + priceAllTennisSneakers) * 0.2;
        double total = priceRackets + priceAllTennisSneakers + priceOtherEquipment;

        double priceDjokovic = total / 8.0;
        double priceSponsors = total * 7.0 / 8.0;

        System.out.printf("Price to be paid by Djokovic %.0f\n",Math.floor(priceDjokovic));
        System.out.printf("Price to be paid by sponsors %.0f", Math.ceil(priceSponsors));

    }
}
