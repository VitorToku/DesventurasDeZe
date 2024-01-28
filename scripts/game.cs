using Godot;
using System;
using System.Security.Cryptography.X509Certificates;

public partial class game : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public int cenaAtual;
	public bool TelaDeOpcao;
	public void aumentarCena(){
		this.cenaAtual = this.cenaAtual +1;
	}
	public override void _Ready()
	{
		cenaAtual = 0;
		TelaDeOpcao = false;
		GD.Print("Numero game =" + this.cenaAtual);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
