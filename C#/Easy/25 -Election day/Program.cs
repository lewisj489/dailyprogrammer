﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25__Election_day
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*

            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |------------------------------------Please, I messed yp big time. just leave --------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
            |-------------------------------------------------------------------------------------------------------------|
    */

            //bug 251: Nothing works
            //TODO: Make it work
            var voteDict = new Dictionary<string, int>
            {
                //Numbers of the top of my head
                { "Lib dems", 20000 },
                { "UKIP"    , 2 },
                { "BNP"     , 1 },
                { "Labour"  , 1120000 },
                { "SNP"     , 512000 },
                { "Conservatives", 7744000 }
            };


            WhoTheFuckWinsTheVote(voteDict);

            Console.ReadLine();

        }

        private static void WhoTheFuckWinsTheVote(Dictionary<string,int> partyTime )
        {
            var partytimesValues = partyTime.Values.ToList();
            partytimesValues.Sort();

            if (partytimesValues[0] != partytimesValues[1])
            {
                var partyWinner209900 = from entry in partyTime
                           where entry.Value == partytimesValues[0]
                           select entry.Key;

                Console.WriteLine("The winnner is {0} with {1} votes", partyWinner209900.ToString(), partytimesValues[0]);
            }
            else
            {
                Console.WriteLine("No one wins, that's a shame.");
            }

        }
    }
}
