import java.util.Scanner;

public class _06_Cinema_Tickets {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        int counterStudentsTickets = 0;
        int counterStandardTickets = 0;
        int counterKidsTickets = 0;

        while (true) {
            String movieName = scanner.nextLine();

            if (movieName.equals("Finish")) {
                break;
            }
            int freeSpaces = Integer.parseInt(scanner.nextLine());
            double people = 0;

            for (int i = 0; i < freeSpaces; i++) {
                String current = scanner.nextLine();

                if (current.equals("student")) {
                    counterStudentsTickets++;
                }
                if (current.equals("standard")) {
                    counterStandardTickets++;
                }
                if (current.equals("kid")) {
                    counterKidsTickets++;
                }

                if (current.equals("End")) {
                    break;
                }
                people++;
            }
            System.out.printf("%s - %.2f%% full.\n", movieName, people / freeSpaces * 100);
        }
        int countertickets = counterKidsTickets + counterStandardTickets + counterStudentsTickets;

        System.out.printf("Total tickets: %d\n", countertickets);
        System.out.printf("%.2f%% student tickets.\n", counterStudentsTickets * 1.0 / countertickets * 100);
        System.out.printf("%.2f%% standard tickets.\n", counterStandardTickets * 1.0 / countertickets * 100);
        System.out.printf("%.2f%% kids tickets.\n", counterKidsTickets * 1.0 / countertickets * 100);
    }
}
