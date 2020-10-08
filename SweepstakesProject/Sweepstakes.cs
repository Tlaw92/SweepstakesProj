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
        public Contestant winnerContest;

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


        public Contestant PickWinner()
        {
            int winningNumber = GetRandomNumber(contestants.Count + 1);
            foreach (KeyValuePair<int, Contestant> player in contestants)
            {
                if (winningNumber == player.Key)
                {
                    winnerContest = player.Value;
                }
                
            }
            return winnerContest;
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }




        public int GetRandomNumber(int max)
        {
            Random randomNumber = new Random();
            int randomResult = randomNumber.Next(max);
            return randomResult;
        }



        //sweepstakes1 = new Sweepstakes("October Sweep");
        //contestant1 = new Contestant("Jim", "Baron", "JimBaron@gmail.com", sweepstakes1.GetRandomNumber(50));
        //contestant2 = new Contestant("Tim", "Burton", "TimBurton@gmail.com", sweepstakes1.GetRandomNumber(50));

        //sweepstakes1.RegisterContestant(contestant1);
        //sweepstakes1.RegisterContestant(contestant2);
        //Console.ReadLine();

    }
}
