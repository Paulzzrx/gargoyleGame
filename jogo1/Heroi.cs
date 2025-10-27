using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo1
{
	public class Heroi : Personagem
	{
		public int escudo = 0;
		
		public Heroi()
		{   
			// Propriedades inicias Player
			Left = 100;
			Top = 150;
			
			hp = 3;
			atk = 1;
			def = 0;
			speed = 25;
			viradoDireita = true;
			
			Width = 90;
			Height = 90;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Load("Gargoyle.gif");
		}
		
		int cont = 0;
		
		public void Dir()
		{
			Left += speed;
			if(viradoDireita == false)
			{
				Load("Gargoyle.gif");
				viradoDireita = true;
			}
			
			if(Left >= 900)
			{
				if (cont != 2) 
				{
					Left = 0;
					cont++;
					MainForm.background.Load("cenario" + cont + ".gif");
				}
				else
				{
					Left = 900;
				}
			}
			
		}
		
		public void Esq()
		{
			Left -= speed;
			if(viradoDireita == true)
			{
				Load("GargoyleEsq.gif");
				viradoDireita = false;
			}
			
			if (Left <= 0) 
			{
				if(cont != 0)
				{
				Left = 900;
				cont--;
				MainForm.background.Load("cenario" + cont + ".gif");
				}
				else
				{
					Left = 0;
				}
			}
		}
		
		public void Cima()
		{
			Top -= speed;
			if (Top < 0) {
				Top = 0;
			}
		}
		
		public void Baixo()
		{
			Top += speed;
			if (Top > 480) {
				Top = 480;
			}
		}
	}
}