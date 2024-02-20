public class Banane:Produit 
{
    private double prixkg;
    private double poids;

    public Banane(string nom,double prix,TVA tva,double prixkg,double poids):
    base(nom,prix*poids,tva)

    {
        this.prixkg = prixkg;
        this.poids = poids;
    }

    public double getPrixkg()
        {
        return this.prixkg;
        }

    public double getPoids()
        {
        return this.poids;
        }
    
    public double calcPoids()
    {
        double res = this.calcTTC()/this.prixkg;
        return res;
    }
    

}