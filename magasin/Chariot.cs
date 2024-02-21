using System.Collections.Generic;
using System;

public class Chariot
{
    private Produit[] produits = new Produit[100];

    public void getChar()
        {
        foreach (Produit prod in this.produits)
        {
            Console.WriteLine(prod.getNom());
        }
        }

    public void ajoutProd(Produit prod)
    {
        for (int i=0;i<this.produits.Length;i++)
        {
            if (this.produits[i] != null)
            {
                continue;
            }
            else {
                this.produits[i] = prod;
                break;
            }
        
            }
    }

    public double total()
    {
        double res=0;
        foreach (Produit prod in this.produits)
        {
            if (prod != null)
            {
                res = res + prod.calcTTC();
            }
        }
        return res;
    }
}