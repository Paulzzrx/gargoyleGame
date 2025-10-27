using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo1
{
	public class Tiro : PictureBox
	{
		public Tiro()
		{
			Width = 40;
			Height = 25;
			SizeMode = PictureBoxSizeMode.StretchImage;
			Parent = MainForm.background;
			
			timerTiro.Enabled = true;
			timerTiro.Interval = 40;
			timerTiro.Tick += timerTick;
		}
		
		public bool direcao = true;
		public int speed = 10;
		public int dano = 10;
		public Personagem personagemAlvo;
		public Timer timerTiro = new Timer();
		
		void timerTick(object sender, EventArgs e)
		{
			if(direcao == true)
			{
				Left += speed;
			}
			else
			{
				Left -= speed;
			}
			
			if(Left > MainForm.background.Width || Left < 0)
			{
				Destruir();
			}
			else if(personagemAlvo.Bounds.IntersectsWith(this.Bounds))
			{
				(personagemAlvo as Enemy).Destruir();
				this.Destruir();
			}
		}
		
		public void Destruir()
		{
			timerTiro.Enabled = false;
			Left = 6000;
			MainForm.barra.Value += 1;
			Dispose();
		}
	}
}
