using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriAdvice.Classes
{
    public class Ingredient
    {
        private string name;
        private string quantity;
        private string amount;

        public Ingredient()
        {
            name = "";
            quantity = "";
            amount = "";
        }

        public Ingredient(string name, string quantity, string amount)
        {
            this.name = name;
            this.quantity = quantity;
            this.amount = amount;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getQuantity()
        {
            return quantity;
        }

        public void setQuantity(string quantity)
        {
            this.quantity = quantity;
        }

        public string getAmount()
        {
            return amount;
        }

        public void setAmount(string amount)
        {
            this.amount = amount;
        }
    }
}
