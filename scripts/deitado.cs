using Godot;
using System;

public partial class deitado : ColorRect
{
	// Called when the node enters the scene tree for the first time.
	public int soneca;
	public bool dialogo;
	public RichTextLabel desc;
	public Godot.Collections.Array<string> falas;
	public Button botao1, botao2;
	public override void _Ready()
	{
		soneca = 0;
		dialogo = false;
		botao1 = this.GetNode("ColorRect").GetNode<Button>("Button2");
		botao2 = this.GetNode("ColorRect").GetNode<Button>("Button3");
		falas = new Godot.Collections.Array<string>
		{ 
			"[center]Já se passaram cinco minutos Zé, é hora de acordar",
			"[center]Já foram dez minutos, o ônibus vai passar daqui a pouco",
			"[center]TU TÁ ATRASADO ZÉ, ACORDA!!!"
		};
		desc = this.GetNode("ColorRect").GetNode<RichTextLabel>("RichTextLabel");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (dialogo){
			if (Input.IsActionJustPressed("ui_accept"))
			{
				if(soneca >= 3){
					GetTree().ChangeSceneToFile("res://cenas/acordou.tscn");		
					}				
				dialogo = false;
				botao1.Show();
				botao2.Show();
			}
		}
	}

	private void _on_button_2_pressed(){
		GetTree().ChangeSceneToFile("res://cenas/acordou.tscn");
	}
	private void _on_button_3_pressed(){
		desc.Text = falas[soneca];
		soneca = soneca + 1;
		botao1.Hide();
		botao2.Hide();
		dialogo = true;		
	}

	
}
