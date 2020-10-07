using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        //variables
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name;

        //constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }



        //methods

        public void RegisterContestant(Contestant contestant)
        {
            int keyNumber = contestants.Count + 1;

            contestants.Add(keyNumber, contestant);

            contestant.RegistrationNumber = keyNumber;

            Console.WriteLine($" Contestants count: {contestants.Count} {contestant.FirstName} " +
                $"{contestant.LastName}" +
                $" {contestant.EmailAddress}" +
                $" registration number: {contestant.RegistrationNumber} ");  //Send this to user interface dude

       }


        //public Contestant PickWinner()
        //{
        //    //return;
        //}




        public void PrintContestantInfo(Contestant contestant)
        {

        }




        public int GetRandomNumber(int max)
        {
            Random randomNumber = new Random();
            int randomResult = randomNumber.Next(max);
            return randomResult;
        }



    }
}
