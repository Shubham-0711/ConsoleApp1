using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.collection
{
    public class Player
    {
        private int runs;
        private string name;
        public Player(int runs, string name)
        {
            this.runs = runs;
            this.name = name;
        }
        public override string ToString()
        {
            return $"{ runs}-->{name}";
        }
    }

    public class Team : IEnumerable
    {
        private Player[] players;
        public Team()
        {
            players = new Player[3]
        {
            new Player(500, "sandesh"),
            new Player(400, "Nikhil"),
            new Player(500, "sahil")

        };
        }


        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }
    /*public class Program
    {
       *//* static void Main(string[] args)
        {
            Team team = new Team();

            foreach (Player item in team)
            {
                Console.WriteLine(item);

            }
        }*//*
    }*/
}
