using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Car
    {
        private IStrategy strategy;
        int fuel = 0;

        public Car() { }

        public Car(IStrategy strategy, int fuel)
        {
            this.strategy = strategy;
            this.fuel = fuel;
        }

        public void setFuel(int fuel)
        {
            this.fuel = fuel;
        }

        public void setStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void startMovement()
        {
            while (fuel > 0)
            {
                this.strategy.move();
                fuel -= 1;
            }
        }
    }
}
