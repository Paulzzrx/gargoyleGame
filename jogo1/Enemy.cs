using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo1
{
	public class Enemy : Personagem
	{	
		public int magia = 0;
		
		public Enemy()
		{
			Width = 260;
			Height = 180;
			Left = 750;
			Top = 10;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Load("DragonEsq2.gif");
			
			hp = 5;
			atk = 1;
			def = 0;
			speed = 25;
			viradoDireita = false;
			
			MainForm.movTimer.Enabled = true;
			MainForm.movTimer.Interval = 80;
			
			MainForm.movTimer.Tick += Movimento;
		}
		
		public void Movimento(object sender, EventArgs e)
		{
			if(viradoDireita == false)
			{
				Top += speed;
				if(Top > 320)
				{
					viradoDireita = true;
				}
			}
			else
			{
				Top -= speed;
				if(Top <= 0)
				{
					viradoDireita = false;
				}
			}
		}
		
		public void Destruir()
		{
			Left = 6000;
			Dispose();
		}
	}
}