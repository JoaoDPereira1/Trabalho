using Godot;

public partial class Player : CharacterBody2D
{
	[Export]
	public float Speed = 1000.0f;

	private Vector2 startPosition;

	public override void _Ready()
	{
		startPosition = Position;
	}

	public override void _PhysicsProcess(double delta)
	{
		Vector2 direction = Input.GetVector(
			"move_left",
			"move_right",
			"move_up",
            "move_down"
		);

		Velocity = direction * Speed;
		MoveAndSlide();

		Rect2 viewRect = GetViewportRect();
		Position = new Vector2(
			Mathf.Clamp(Position.X, 0, viewRect.Size.X),
			Mathf.Clamp(Position.Y, 0, viewRect.Size.Y)
		);
	}

	public void ResetPosition()
	{
		Position = startPosition;
	}
}
