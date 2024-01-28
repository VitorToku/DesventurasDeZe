using Godot;
using System;

public partial class banho : ColorRect
{
	// Called when the node enters the scene tree for the first time.
	public RichTextLabel desc;
	public bool proximo; 
	public Button botao1, botao2;
	public override void _Ready()
	{
		desc = this.GetNode("ColorRect").GetNode<RichTextLabel>("RichTextLabel");
		botao1 = this.GetNode("ColorRect").GetNode<Button>("Button2");
		botao2 = this.GetNode("ColorRect").GetNode<Button>("Button3");
		proximo = false;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(proximo){
			if(Input.IsActionJustPressed("ui_accept")){
				GetTree().ChangeSceneToFile("res://cenas/saindo_de_casa.tscn");			}
			
		}
	}

	private void _on_button_2_pressed(){
		GetTree().ChangeSceneToFile("res://cenas/tomoubanho2.tscn");
	}
	private void _on_button_3_pressed(){		
		desc.Text = "[center] Zé resolveu que preferia ir fedido e sujo";
		proximo = true;
		botao1.Hide();
		botao2.Hide();
	}
}
