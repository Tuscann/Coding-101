import java.sql.SQLOutput;
import java.util.Scanner;

public class _05_Exam {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int countStudentOnExam = Integer.parseInt(scan.nextLine());

        double counterTopStudents = 0;
        double counter400 = 0;
        double counter300 = 0;
        double counterFail = 0;

        double sum = 0.0;

        for (int i = 0; i < countStudentOnExam; i++) {
            double current = Double.parseDouble(scan.nextLine());
            sum += current;

            if (current >= 5.00) {
                counterTopStudents++;
            } else if (current >= 4.00) {
                counter400++;
            } else if (current >= 3.00) {
                counter300++;
            } else {
                counterFail++;
            }

        }
        System.out.printf("Top students: %.2f", (100.00/countStudentOnExam) * counterTopStudents);
        System.out.println("%");
        System.out.printf("Between 4.00 and 4.99: %.2f",(100.00/countStudentOnExam) * counter400);
        System.out.println("%");
        System.out.printf("Between 3.00 and 3.99: %.2f",(100.00/countStudentOnExam) * counter300);
        System.out.println("%");
        System.out.printf("Fail: %.2f ",(100.00/countStudentOnExam) * counterFail);
        System.out.println("%");
        System.out.printf("Average: %.3f", sum / countStudentOnExam);
    }
}
