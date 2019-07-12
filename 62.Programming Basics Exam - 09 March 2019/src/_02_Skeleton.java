import java.util.Scanner;

public class _02_Skeleton {
    public static void main(String[] args) {
        Scanner scanner= new Scanner(System.in);

        int minutes=Integer.parseInt(scanner.nextLine());
        int seconds=Integer.parseInt(scanner.nextLine());

        double lenght=Double.parseDouble(scanner.nextLine());
        double secondsPer100Meters=Double.parseDouble(scanner.nextLine());

        double end=minutes*60+seconds;
        double timesReducetime=lenght/120;
        double removetime=timesReducetime*2.5;
        double marinTime=(lenght/100)*secondsPer100Meters-removetime;

        if (end >= marinTime) {
            System.out.println("Marin Bangiev won an Olympic quota!");
            System.out.printf("His time is %.3f.\n",marinTime);
        }else {
            System.out.printf("No, Marin failed! He was %.3f second slower.",marinTime-end);
        }
    }
}
