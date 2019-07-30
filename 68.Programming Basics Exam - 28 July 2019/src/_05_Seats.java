import java.util.Scanner;

public class _05_Seats {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int countTickets = Integer.parseInt(scan.nextLine());
        for (int i = 0; i < countTickets; i++) {
            String currentTicket = scan.nextLine();

            if (currentTicket.length() == 4) {
                if (Character.isUpperCase(currentTicket.charAt(0))) {
                    System.out.printf("Seat decoded: %s%s%s\n", currentTicket.charAt(0), currentTicket.charAt(1), currentTicket.charAt(2));
                }else{
                    System.out.printf("Seat decoded: %s%s%s\n", currentTicket.charAt(3), currentTicket.charAt(1), currentTicket.charAt(2));
                }

            } else if (currentTicket.length() == 5 || currentTicket.length() == 6) {
                System.out.printf("Seat decoded: %s%s\n", currentTicket.charAt(0),(int) currentTicket.charAt(1));
            }
        }
    }
}
