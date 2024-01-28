using Godot;
using System;

public partial class tomoubanho2 : ColorRect
{
	// Called when the node enters the scene tree for the first time.
	public bool fora;
	public override void _Ready()
	{
		fora = true;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
			if (Input.IsActionJustPressed("ui_accept"))
			{
				if(fora)
				{
					GetTree().ChangeSceneToFile("res://cenas/tomoubanho.tscn");
				}
				else{
					GetTree().ChangeSceneToFile("res://cenas/gandaia.tscn");
				}
			}
		

	}
	public void _on_button_mouse_entered(){
		fora = false;
	}
	public void _on_button_mouse_exited(){
		fora = true;
	}
	
}
