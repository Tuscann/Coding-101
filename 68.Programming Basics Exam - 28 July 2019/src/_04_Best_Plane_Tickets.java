import java.util.Scanner;

public class _04_Best_Plane_Tickets {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int smalliestMinutes = 500;
        String smalliestName = "";
        double smalliestprice = 500;

        while (true) {
            String ticketNumber = scan.nextLine();
            if (ticketNumber.equals("End")) {
                break;
            }
            double price = Double.parseDouble(scan.nextLine());
            int minutes = Integer.parseInt(scan.nextLine());

            if (minutes < smalliestMinutes) {
                smalliestMinutes = minutes;
                smalliestName = ticketNumber;
                smalliestprice = price;
            }
        }
        System.out.printf("Ticket found for flight %s costs %.2f leva with %dh %dm stay",
                smalliestName,
                smalliestprice * 1.96,
                smalliestMinutes / 60,
                smalliestMinutes % 60);
    }
}
