import java.util.Scanner;

public class _06_Wedding_Seats {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        char lastSector = scan.nextLine().charAt(0);
        int rowsCount1Sector = Integer.parseInt(scan.nextLine());
        int rowsCountOddRow = Integer.parseInt(scan.nextLine());


        for (char firstSector = 'A'; firstSector <= lastSector; firstSector++) {
            for (int i = 1; i < rowsCount1Sector; i++) {

            }
        }




















        for (char i = 'A'; i <= rowsCount1Sector; i++) {
            for (int j = 1; j <= rowsCount1Sector; j++) {
                System.out.print("" + i + j);
//                if (j % 2 == 0) {
//                    for (char a = 'a'; a < rowsCountOddRow; a++) {
//
//                        System.out.print(a);
//                    }
//                }
                System.out.println();
            }


        }


    }
}
