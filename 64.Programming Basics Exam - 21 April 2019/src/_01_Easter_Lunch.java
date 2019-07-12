import java.util.Scanner;

public class _01_Easter_Lunch {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int countKozinaks = Integer.parseInt(scanner.nextLine());
        int eggs = Integer.parseInt(scanner.nextLine());
        int kilogramsKurabiiki = Integer.parseInt(scanner.nextLine());

        double sum = countKozinaks * 3.2 + eggs * 4.35 + kilogramsKurabiiki * 5.4 + eggs * 12 * 0.15;
        System.out.printf("%.2f", sum);
    }
}
