using Godot;
public partial class Target : Area2D
{
private void _on_body_entered(Node2D body)
{
	if (body.Name == "Player")
	{
		GD.Print("TARGET REACHED!");
		Visible = false; // G2: esconde o alvo

		// Procura o nó Label e chama a função dele
		Label labelNode = GetNode<Label>("../Label");
		labelNode.ShowTargetReached();
	}
}
}
