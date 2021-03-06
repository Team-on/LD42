﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ld42 {
	static class Settings {
		static public GameWindow gameWindow;
		static public Game game;

		static public string imagePath = "Resources\\";
		static public string imageExt = ".png";

		static public byte tickInterval = 10;
		static public ulong tick = 0;
		static public byte ticksForMove = 25;
		static public double camSpeed = 1.0 / Settings.ticksForMove;

		static public Coord fieldSize = new Coord(50, 20);

		static public Coord camStartPos = new Coord(0, 0);
		static public Coord camSize = new Coord(21, 9);
		static public CoordReal cellSize = new CoordReal();

		static public Coord snakeStartPos = new Coord((short)Math.Round(camSize.X / 2.0 + camStartPos.X),
			(short)Math.Round(camSize.Y / 2.0 + camStartPos.Y));
		static public Direction snakeStartDirection = Direction.Down;
	}
}
