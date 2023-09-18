import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        
       // Scanner sc = new Scanner (System.in);
      //  int age=sc.nextInt();
      //  System.out.println(" L'age est "+ age);
        
      //  if(age>18){
      //      System.out.println("Vous êtes majeur");
      //  }
      //  else{
      //      System.out.println("Vous etes mineur");
      //  }




// EXOOO 3
    
      //Scanner sc = new Scanner (System.in);
      //System.out.println("Saisir de Nombre entier");
      //int nb1 =sc.nextInt();
      //int nb2= sc.nextInt();

      //if(nb1>nb2)
      //{
       // System.out.println(nb1+" est plus grand que "+ nb2);
        
      //}

     // else{
    //  System.out.println(nb2+" est plus grand que "+ nb1);
     // }

    // EXO 4 
     //Scanner sc = new Scanner (System.in);
     //System.out.println("Saisir un nombre réel");
     //int nbSaisi = sc.nextInt();

     //if(nbSaisi<0){
    //    System.out.println(nbSaisi+" Est négatif");
     //}
     //else if(nbSaisi==0){
     //   System.out.println(nbSaisi+" Est NULL");
     //}
     //else{
     //   System.out.println(nbSaisi+" Est positif ");
     //}

     // EXO 7

    //  Scanner sc = new Scanner(System.in);

    //  System.out.println("Saisir un montant : ");
     // float nbSaisi = sc.nextFloat();
    // float taux = 0;

    // if(nbSaisi<=100000){
    //     taux=10;
    //     System.out.println("Le taux est de : "+ taux+"%");
    // }
    // else if(nbSaisi>10000 || nbSaisi<20000){
     //    taux=20;
    //     System.out.println("Le taux est de : "+ taux+"%");
    // }
     //else{
       //  taux=30;
      //   System.out.println("Le taux est de : "+ taux+"%");
  //   }
     
  // EXO 8

  Scanner sc = new Scanner(System.in);
  
  System.out.println("Saisir le numéro de Pizza Pizza");
  System.out.println("1. Reine");
  System.out.println("2. 4 Fromages");
  System.out.println("3. Napolitaine");
  System.out.println("4. Quatre Saison");
  System.out.println("5. Calzone");
  System.out.println("6. Hawaienne");
  int nbSaisi = sc.nextInt();

  int nbPizza = 0;

  int PrixPizza=0;

  int total;

  switch(nbPizza)
  {
    case 1 : PrixPizza=9;
    break;

    case 2 : PrixPizza=11;
    break;

    case 3 : PrixPizza=10;
    break;

    case 4 : PrixPizza=11;
    break;

    case 5:PrixPizza=11;
    break;

    case 6: PrixPizza=12;
    break;
  }
System.out.println("Combien en voulez vous ? ");
nbPizza = sc.nextInt();


String Supplement=sc.next();

if(Supplement.equals("Oui"))
{
    total=(PrixPizza*nbPizza)+1;
    System.out.println(total);
}






  




     

    }
}
