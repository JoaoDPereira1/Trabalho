using Godot;

public partial class Label : Godot.Label
{
	// Método para ser chamado quando o alvo for atingido
	public void ShowTargetReached()
	{
		Text = "TARGET REACHED!";
	}
}
