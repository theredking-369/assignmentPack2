using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Bicycle
    {
        private string model;
        private string year;
        private colourEnum colour;

        private int speed;
        private double distance;
        private int topSpeed;

        public Bicycle(string model, string year,colourEnum colour,double distance,int topSpeed)
        {
            this.model = model;
            this.year = year;
            this.colour = colour;
            this.distance = distance;
            this.topSpeed = topSpeed;

            Thread bicycleThread = new Thread(new ThreadStart(Cycle));
            bicycleThread.Start();
        }
       
    

        public void Stop()
        {
            speed = 0;
        }

        public override string ToString()
        {
            return $"{this.model}";
        }

        public int getSpeed()
        {
            return speed;
        }

     

        public string getModel()
        {
            return model;
        }


        public void pedalFaster(int increaseSpeed)
        {
            if ((speed + increaseSpeed) > topSpeed)
                speed = topSpeed;
            else
                speed += increaseSpeed;
        }

        public void braking(int decreaseSpeed)
        {
            if ((speed - decreaseSpeed) > 0)
                speed -= decreaseSpeed;
        }

        private void Cycle()
        { 
            while(true)
            {
                double kilometerps = speed / 3600;
                double displacement = kilometerps * 1;
                distance += displacement;

                Thread.Sleep(1000);
            }
                
         }

        public double getDistance()
        {
            return distance;
        }

    }
}
