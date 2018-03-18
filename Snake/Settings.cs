﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        public static int width { get; set; }
        public static int height { get; set; }
        public static int speed { get; set; }
        public static int score { get; set; }
        public static int points { get; set; }
        public static bool gameOver { get; set; }
        public static Direction direction { get; set; }

        //
        public Settings()
        {
            width = 16;
            height = 16;
            speed = 16;
            score = 0;
            points = 1;
            gameOver = false;
            direction = Direction.Down; 
        }
    }
}