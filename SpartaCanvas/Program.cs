using System;
using System.ComponentModel;

namespace SpartaCanvas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game("Text RPG");

            game.Play();
        }
    }
}