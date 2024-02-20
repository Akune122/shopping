public class TVA 
{
    private double pourcentage;

    public TVA(double pourcentage)
    {
        this.pourcentage = pourcentage;
    }

    


    public double getPourcent()
    {
        return this.pourcentage;
    }

    public double getTTC(Produit Prod)
    {
        double ttc = Prod.getPrix()*(1+(0.01*pourcentage));
        return ttc;
    }

}