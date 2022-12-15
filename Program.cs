using System;

namespace TP
{
    public class Program
    {
        static void Main(string[] args)
        {
            // A définir
                CompteBancaire Mon_Compte = new CompteBancaire (01234, "Hamza", 2500);
             Console.WriteLine("Le numero de compte est : " + Mon_Compte.get_NumeroCompte() + "\n Son titulaire est : " + Mon_Compte.get_TitulaireCompte() + "\n Avec un solde de : " +Mon_Compte.get_MotantCourant() + " euros \n");
             Mon_Compte.Deposer(500);
             Mon_Compte.Retrait(150);
             Mon_Compte.Taxe(5);
             Mon_Compte.Interet(5);
             
             /*CompteCheque my_count = new CompteCheque(2345, "lux", 1000, 5);
             Console.WriteLine(my_count);*/
             
             
            
             
            

        } // Fermeture Main
    }  // Fermeture classe principale Program


    // Déclaration et défintion des classes
    //Classe principale : CompteBancaire

class CompteBancaire{
    
        protected int NumeroCompte;
        protected string TitulaireCompte;
        protected int MontantCourant;
        protected int montantRestant;
       

        // Constructeur par défaut
        public CompteBancaire(){} // contructeur par défaut

        public CompteBancaire (int numeroCompte, string titulaireCompte, int montantCourant) { 
         this.NumeroCompte=numeroCompte;
         this.TitulaireCompte =titulaireCompte;
         this.MontantCourant=montantCourant;
        
        } // fin constructeur pour tous les paramètres.
        
        public void Deposer(int montantDepot) {
            MontantCourant = montantDepot + MontantCourant;
            Console.WriteLine(montantDepot + " euros ont bien etait deposer sur le compte ( " + NumeroCompte + " ), ce qui fait que le solde totale est : " + MontantCourant + (" euros"));
            
        }
        
        public void Retrait(int montantRetrait) {
            montantRestant = MontantCourant - montantRetrait;
            if (montantRetrait > montantRestant){
                Console.WriteLine("Le retrait est impossible");
            }else{
                MontantCourant = MontantCourant - montantRetrait;
                Console.WriteLine(montantRetrait + " euros ont bien etait retirer du compte ( " + NumeroCompte + " ), ce qui fait que le solde totale est : " + MontantCourant + (" euros"));
            }
            
        }
        
        public void Taxe(int montantTaxe) {
            MontantCourant =  MontantCourant - montantTaxe;
            Console.WriteLine(montantTaxe + " euros de taxe mensuelle ont bien etait retirer du compte ( " + NumeroCompte + " ), ce qui fait que le solde totale est : " + MontantCourant + (" euros"));
            
        }
        
        public void Interet(int montantInteret) {
            if (montantInteret >= 5 && montantInteret <= 10){
                MontantCourant =  MontantCourant - (montantInteret / 100);
            Console.WriteLine(montantInteret + " % d'interet mensuelle ont bien etait retirer du compte ( " + NumeroCompte + " ), ce qui fait que le solde totale est : " + MontantCourant + (" euros"));
            }else{
                Console.WriteLine("le montant d'interet doit etre entre 5% et 10%");
            }
        }

            // Les méthodes getters/setters
        
        // les getters
        public int get_NumeroCompte(){return this.NumeroCompte;}
        public string get_TitulaireCompte(){return this.TitulaireCompte;}
        public  int get_MotantCourant(){return this.MontantCourant;} 

        // les setters
        public void set_NumeroCompte(int numeroCompte){this.NumeroCompte=numeroCompte;}
        public void set_TitulaireCompte(string titulaireCompte){this.TitulaireCompte=titulaireCompte;}
        public void set_MotantCourant(int montantCourant){this.MontantCourant=montantCourant;}
 

    } // Fermeture de la clase CompteBancaire



/*class CompteCheque:CompteBancaire
{


    public CompteCheque(int numeroCompte, string titulaireCompte ,int montantCourant, int interet)
          :base(numeroCompte, titulaireCompte,montantCourant)
        {
            
        }
        

    public new void Interet(int montantInteret){
        int solde = get_MotantCourant;
        
        if (solde > 500){
            if (montantInteret >= 5 && montantInteret <= 10){
                solde =  solde - (montantInteret / 100);
            Console.WriteLine(montantInteret + " % d'interet mensuelle ont bien etait retirer du compte ( " + NumeroCompte + " ), ce qui fait que le solde totale est : " + solde + (" euros"));
            }else{
                Console.WriteLine("le montant d'interet doit etre entre 5% et 10%");
            }
        }else{
            Console.WriteLine("impossible de beneficer d'un interet mensuelle");
        }
    }
} // Fin classe comptecheque */




// classe CompteLivret  qui hérite de la classe mère CompteBancaire 

 
/*class CompteLivret : CompteBancaire
 {

        // Constructeurs

        public CompteLivret(int numeroCompte, string titulaireCompte ,int montantCourant, int taxes)
          :base(numeroCompte, titulaireCompte,montantCourant)
        {
           
        }

    public new void Taxe(){
        int solde2 = get_MotantCourant;
        
        if (solde2 < 200){
            solde2 =  solde2 - montantTaxe;
        Console.WriteLine(montantTaxe + " euros de taxe mensuelle ont bien etait retirer du compte ( " + NumeroCompte + " ), ce qui fait que le solde totale est : " + solde2 + (" euros"));
        }
    }


    }// Fin classe Comptelivret*/
    





}  // Fermeture namespace