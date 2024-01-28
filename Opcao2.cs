using Godot;
using System;

public partial class Opcao2 : Button
{
	// Called when the node enters the scene tree for the first time.
	public game game, node_bisavo;
	public ColorRect node_pai, node_avo;
	public int numero_game;
	private void _on_pressed()
	{
		numero_game = node_bisavo.cenaAtual;		
		GD.Print(numero_game);	
		node_bisavo.aumentarCena();
		GD.Print(node_bisavo.Name);
	}

	public override void _Ready()
	{
		node_pai = GetParent<ColorRect>();
		node_avo = node_pai.GetParent<ColorRect>();
		node_bisavo = node_avo.GetParent<game>();

		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}



