using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public abstract class TemplateRecette
    {
        public void TemplateMethode()
        {
            this.CouperLegumes();
            this.Marinade();
            this.FaireSauce();
            this.Cuisson();
            this.Servir();

        }

        protected void CouperLegumes()
        {
            Console.WriteLine("Couper les legumes en gros morceaux");
        }

        protected abstract void FaireSauce();
        

        protected void Marinade()
        {
            Console.WriteLine("Assaisonner la viande des epices et laisser reposer au frigo");
        }

        protected abstract void Cuisson();

        protected virtual void Servir()
        {
            Console.WriteLine("Servir chaud");
        }
    }

    public class Blanquette : TemplateRecette
    {
        protected override void FaireSauce()
        {
            Console.WriteLine("Ajouter la creme fraiche et le bouillon");
        }

        protected override void Cuisson()
        {
            Console.WriteLine("Cuire sous pression pendant 30 min");
        }
    }

    public class Tajine : TemplateRecette
    {
        protected override void FaireSauce()
        {
            Console.WriteLine("Ajouter 1L d'eau avec les epices");
        }

        protected override void Cuisson()
        {
            Console.WriteLine("Cuire a feu moyen pendant 1 heure");
        }

        protected override void Servir()
        {
            Console.WriteLine("Servir dans un plat commun");
        }
    }

    public class Cuisinier
    {
        public static void Cooking(TemplateRecette abstractClass)
        {

            abstractClass.TemplateMethode();

        }
    }
}
