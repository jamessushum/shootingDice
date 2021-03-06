﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            // Smack talking player
            SmackTalkingPlayer smackTalking = new SmackTalkingPlayer();
            smackTalking.Name = "Rick James";
            smackTalking.AddInsult("My dog rolls better than that!");
            large.Play(smackTalking);

            Console.WriteLine("-------------------");

            // One higher player
            Player oneHigher = new OneHigherPlayer();
            oneHigher.Name = "Slick Rick";
            oneHigher.Play(large);

            Console.WriteLine("-------------------");

            // Human Player
            Player human = new HumanPlayer();
            human.Name = "Ricky";
            player1.Play(human);

            Console.WriteLine("-------------------");

            // Creative Smack Talking Player
            Player creativeSmack = new CreativeSmackTalkingPlayer();
            creativeSmack.Name = "Rick Roll";
            large.Play(creativeSmack);

            Console.WriteLine("-------------------");

            // Sore Loser Player
            Player soreLoser = new SoreLoserPlayer();
            soreLoser.Name = "Ricky Williams";
            // Try/Catch to handle exception message when SoreLoserPlayer loses
            try
            {
                soreLoser.Play(player2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{soreLoser.Name} says: You Cheated!");
            }

            Console.WriteLine("-------------------");

            // Upper Half Player
            Player upperHalf = new UpperHalfPlayer();
            upperHalf.Name = "Rick Grimes";
            upperHalf.Play(player3);

            Console.WriteLine("-------------------");

            // Sore Loser Upper Half Player
            Player sluhPlayer = new SoreLoserPlayer();
            sluhPlayer.Name = "Rick Sanchez";
            // Try/Catch to handle exception message when SoreLoserUpperHalfPlayer loses
            try
            {
                sluhPlayer.Play(large);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{sluhPlayer.Name} says: This game is rigged!");
            }

            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>()
            {
                player1,
                player2,
                player3,
                large,
                smackTalking,
                oneHigher,
                human,
                creativeSmack,
                upperHalf
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}