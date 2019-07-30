import java.util.Scanner;

public class _02_Reservation {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int dayReservation = Integer.parseInt(scan.nextLine());
        int mouthReservation = Integer.parseInt(scan.nextLine());
        int checkInDay = Integer.parseInt(scan.nextLine());
        int checkInMonth = Integer.parseInt(scan.nextLine());
        int dayLeaving = Integer.parseInt(scan.nextLine());
        int mouthLeaving = Integer.parseInt(scan.nextLine());

        int nights = dayLeaving - checkInDay;

        int daysApart = Math.abs(dayReservation - checkInDay);
        int monthsApart = Math.abs(mouthReservation - checkInMonth);

        boolean earlyBooking10days = false;
        boolean earlyBooking1month = false;
        double price = 30;

        if (daysApart >= 10) {
            earlyBooking10days = true;
        }

        if (monthsApart >= 1) {
            earlyBooking1month = true;
            earlyBooking10days = true;
        }

        double cost = nights * price;
        if (earlyBooking10days) {
            cost = nights * 25;
        }

        if (earlyBooking1month) {
            cost *= 0.8;
        }

        System.out.printf("Your stay from %d/%d to %d/%d will cost %.2f", checkInDay, checkInMonth, dayLeaving, mouthLeaving, cost);
    }
}
