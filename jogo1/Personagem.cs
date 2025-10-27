using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo1
{
	public class Personagem : PictureBox
	{
		public int hp = 0;
		public int atk = 0;
		public int def = 0;
		public int speed = 0;
		public bool viradoDireita;
		
		public Personagem()
		{
			Width = 90;
			Height = 90;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Parent = MainForm.background;
		}
	}
}
