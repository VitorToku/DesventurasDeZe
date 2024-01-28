using Godot;
using System;

public partial class Opcao2 : Button
{
	// Called when the node enters the scene tree for the first time.
	private void _on_pressed()
	{
		GD.Print("Clicamo no 2");
	}

	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}



