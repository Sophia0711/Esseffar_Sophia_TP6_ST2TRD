using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{

    public interface IBuilder
    {
        void Base();
        void AddChampignon();
        void AddOeuf();
        void AddChevre();
        void AddViande();
        void AddPatate();
        void AddOlive();
        void AddOignon();
        void AddSaumon();
        void AddAnchois();
        void AddMerguez();
        void AddChorizo();
        void AddPoivron();
    }

    public class Pizzaiolo : IBuilder
    {
        private Pizza _pizza = new Pizza();

        public Pizzaiolo()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._pizza = new Pizza();
        }

        public void Base()
        {
            this._pizza.Add("Sauce Tomate");
            this._pizza.Add("Mozarella");
        }

        public void AddChampignon()
        {
            this._pizza.Add("champignons");
        }
        public void AddOeuf()
        {
            this._pizza.Add("Oeuf");
        }
        public void AddChevre()
        {
            this._pizza.Add("Chevre");
        }
        public void AddViande()
        {
            this._pizza.Add("Viande hachee");
        }
        public void AddPatate()
        {
            this._pizza.Add("Pomme de terre");
        }
        public void AddOlive()
        {
            this._pizza.Add("Olives");
        }
        public void AddOignon()
        {
            this._pizza.Add("Oignons");
        }
        public void AddSaumon()
        {
            this._pizza.Add("Saumon");
        }
        public void AddAnchois()
        {
            this._pizza.Add("Anchois");
        }
        public void AddMerguez()
        {
            this._pizza.Add("Merguez");
        }
        public void AddChorizo()
        {
            this._pizza.Add("Chorizo");
        }
        public void AddPoivron()
        {
            this._pizza.Add("Poivrons");
        }

        public Pizza GetProduct()
        {
            Pizza result = this._pizza;

            this.Reset();

            return result;
        }

    }

    public class Pizza
    {
        private List<string> _ingredient = new List<string>();

        public void Add(string ingredient)
        {
            this._ingredient.Add(ingredient);
        }

        public override string ToString()
        {
            string str = string.Empty;

            for (int i = 0; i < this._ingredient.Count; i++)
            {
                str += this._ingredient[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Pizza Ingredients: " + str + "\n";
        }

    }

    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void BuildSimplePizza()
        {
            this._builder.Base();
        }

        public void BuildFullPizza()
        {
            this._builder.Base();
            this._builder.AddViande();
            this._builder.AddPatate();
            this._builder.AddChevre();
            this._builder.AddOlive();
            this._builder.AddOignon();
            this._builder.AddPoivron();
            this._builder.AddMerguez();
            this._builder.AddChorizo();

        }
    }

}
