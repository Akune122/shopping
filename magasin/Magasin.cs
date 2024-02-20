using System;
using System.Collections.Generic;

public class Produit
{
    private string nom;
    private double prix;
	private TVA tva;
		
    // Constructeur //
    public Produit(string nom,double prix,TVA tva)
    {

        this.nom = nom;
        this.prix = prix;
        this.tva= tva;

    }

    public string getNom()
        {
        return this.nom;
        }

	public double getPrix()
        {
        return this.prix;
        }
    public TVA getTVA()
        {
        return this.tva;
        }



static void Main(string[] args)
{

        TVA Tva1;
        Tva1= new TVA(5);
        TVA Tva2;
        Tva2= new TVA(20);
        TVA Tva3;
        Tva3= new TVA(15);

		Produit	Pomme;
		Pomme= new Produit("Pomme",5,Tva1);

        Produit	Voiture;
		Voiture= new Produit("McLaren",15,Tva3);

        Produit	iPad;
		iPad= new Produit("iPad",5,Tva2);

        Chariot Caddie;
        Caddie = new Chariot();


        Caddie.ajoutProd(Pomme);
        Caddie.ajoutProd(Voiture);
        Caddie.ajoutProd(iPad);
        Console.WriteLine(Caddie.total());
}

}