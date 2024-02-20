using System.Collections.Generic;
using System;

public class Chariot
{
    private Produit[] produits = new Produit[100];

    public  Produit[] getChar()
        {
        for (int i=0;i<this.produits.Length;i++)
        {
            if (this.produits[i] == null)
            {
                continue;
            }
            else {
                Console.WriteLine(this.produits[i].getNom());
            }
        }
        return this.produits;
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
        int i;
        for (i = 0; i < this.produits.Length; i++)
        {
            res = res + this.produits[i].getTVA().getTTC(this.produits[i]);
        }
        return res;
    }
}