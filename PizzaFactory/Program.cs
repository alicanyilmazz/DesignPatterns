using System;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pz = new PizzaStore(new SimplePizzaFactory());
            pz.OrderPizza();
        }
    }
    public class PizzaStore
    {
        SimplePizzaFactory _factory;
        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }
        public Pizza OrderPizza()
        {
            Pizza pizza;
            pizza = _factory.CreatePizza("Cheese");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
    public class SimplePizzaFactory
    {
        Pizza pizza;
        public Pizza CreatePizza(string type)
        {
            if (type== "CheesePizza")
            {
                pizza = new CheesePizza();
            }
            else if (type== "VeggiePizza")
            {
                pizza = new VeggiePizza();
            }
            else if (type == "ClamPizza")
            {
                pizza = new ClamPizza();
            }
            else if (type== "PeperoniPizza")
            {
                pizza = new PeperoniPizza();
            }
          
            return pizza;
        }
    }
    public interface Pizza
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
    public class CheesePizza : Pizza
    {
        public void Bake()
        {
            Console.WriteLine("Bake CheesePizza");
        }

        public void Box()
        {
            Console.WriteLine("Box CheesePizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut CheesePizza");
        }

        public void Prepare()
        {
            Console.WriteLine("Prepare CheesePizza");
        }
    }
    public class VeggiePizza : Pizza
    {
        public void Bake()
        {
            Console.WriteLine("Bake VeggiePizza");
        }

        public void Box()
        {
            Console.WriteLine("Box VeggiePizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut VeggiePizza");
        }

        public void Prepare()
        {
            Console.WriteLine("Prepare VeggiePizza");
        }
    }
    public class ClamPizza : Pizza
    {
        public void Bake()
        {
            Console.WriteLine("Bake ClamPizza");
        }

        public void Box()
        {
            Console.WriteLine("Box ClamPizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut ClamPizza");
        }

        public void Prepare()
        {
            Console.WriteLine("Prepare ClamPizza");
        }
    }
    public class PeperoniPizza : Pizza
    {
        public void Bake()
        {
            Console.WriteLine("Bake PeperoniPizza");
        }

        public void Box()
        {
            Console.WriteLine("Box PeperoniPizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut PeperoniPizza");
        }

        public void Prepare()
        {
            Console.WriteLine("Prepare PeperoniPizza");
        }
    }
}
