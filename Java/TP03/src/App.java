import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        
        // Déclaration et création de l'objet Scanner
        //Scanner sc = new Scanner(System.in);

        //Réponse saisie par l'utilisateur, de type caractère 

        //char reponse ='o';
        //while (reponse=='o'){
         //   System.out.println("Voulez-vous continuez ? (o/n) ");
        //    reponse = sc.next().charAt(0);

        //}
       // System.out.println(" suite  ...");


// EXO 3
        
        Scanner sc = new Scanner(System.in);
        char operation = ' ';

        boolean quitter = false;

        while (!quitter) {
            double nb1, nb2, resultat = 0;
            System.out.print("Entrez un opérateur (+, -, *, ^ ou q pour quitter) : ");
            operation = sc.next().charAt(0);

            if (operation == 'q') {
                quitter = true;
                break;
            }

            System.out.print("Entrez le premier nombre : ");
            nb1 = sc.nextFloat();

            System.out.print("Entrez le deuxième nombre : ");
            nb2 = sc.nextFloat();

            switch (operation) {
                case '+':
                    resultat = nb1 + nb2;
                    break;

                case '-':
                    resultat = nb1 - nb2;
                    break;

                case '*':
                    resultat = nb1 * nb2;
                    break;
                    
                case '/':
                if (nb2 == 0) {
                    System.out.println("Erreur");
                    continue;
                }
                resultat = nb1 / nb2;
                break;
                
                case '^':
                    resultat = Math.pow(nb1, nb2);
                    break;

            }

            System.out.println("Le résultat de " + nb1 + " " + operation + " " + nb2 + " = " + resultat);
        }
    }
}
        
    
