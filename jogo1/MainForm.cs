using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo1
{
	public partial class MainForm : Form
	{
		Heroi Player = new Heroi();
		Enemy Enemy = new Enemy();
		
		public static PictureBox background = new PictureBox();
		public static Timer movTimer = new Timer();
		public static Timer tiroTimer = new Timer();
		public static ProgressBar barra = new ProgressBar();
		
		public MainForm()
		{
			InitializeComponent();
			background.Parent = this;
			background.Width = 1000;
			background.Height = 560;
			background.SizeMode = PictureBoxSizeMode.StretchImage;
			background.BackColor = Color.Transparent;
			background.Load("cenario0.gif");
			
			
			barra.Parent = this;
			barra.Left = 200;
			barra.Top = this.Height - 75;
			barra.Width = 200;
			barra.Maximum = 6;
			barra.Minimum = 0;
			barra.Step = 1;
			barra.Value = 6;
			
//			tiroTimer.Enabled = true;
//			tiroTimer.Interval = 15;
//			tiroTimer.Tick += TiroTick;
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.W)
			{
				Player.Cima();
			}
			
			if(e.KeyCode == Keys.S)
			{
				Player.Baixo();
			}
			
			if(e.KeyCode == Keys.A)
			{
				Player.Esq();
			}
			
			if(e.KeyCode == Keys.D)
			{
				Player.Dir();
			}
			
			if(e.KeyCode == Keys.Space)
			{
				if(barra.Value > 0)
				{
					Tiro tiro = new Tiro();
					tiro.direcao = Player.viradoDireita;
					tiro.Load("fireball2.gif");
					tiro.Top = (int) Player.Top + (Player.Height/2) - tiro.Height;
					tiro.Left = Player.Left;
					tiro.personagemAlvo = Enemy;
					barra.Value -= 1;
				}
			}	
		}
	}
}
