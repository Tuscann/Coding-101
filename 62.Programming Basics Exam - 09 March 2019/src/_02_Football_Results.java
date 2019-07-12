import java.util.Scanner;

public class _02_Football_Results {
    public static void main(String[] args) {
        Scanner scanner= new Scanner(System.in);

        int counterTeam1Goals=0;
        int counterTeam2Goals=0;
        int counterTeamDraws=0;

        for (int i = 0; i < 3; i++) {
            var currentLine =scanner.nextLine().toCharArray();

            int first=currentLine[0];
            int last=currentLine[2];

            if (first>last){
                counterTeam1Goals++;
            }else if(last>first){
                counterTeam2Goals++;

            }else {
                counterTeamDraws++;
            }
        }
        System.out.printf("Team won %d games.\n",counterTeam1Goals);
        System.out.printf("Team lost %d games.\n",counterTeam2Goals);
        System.out.println("Drawn games: "+counterTeamDraws);

    }
}
