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

    public double getTTC(double Prod)
    {
        double ttc = Prod*(1+(0.01*this.pourcentage));
        return ttc;
    }
}