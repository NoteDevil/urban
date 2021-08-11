using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public partial class PlayerHudClient : Panel
{
	private Label Health;
	private Panel HelthBar;
	public PlayerHudClient()
	{
		StyleSheet.Load("/ui/PlayerHudClient.scss");

		Panel Pozition = Add.Panel("Pozition");

		Panel healthBarBack = Pozition.Add.Panel( "healthBarBack" );
		HelthBar = healthBarBack.Add.Panel("helthBar");

		Health = Pozition.Add.Label("0", "healthText");
	}

	public override void Tick()
	{
		base.Tick();

		var player = Local.Pawn;
		if (player == null) return;

		Health.Text = $"{player.Health.CeilToInt()}";

		HelthBar.Style.Dirty();
		HelthBar.Style.Width = Length.Percent( player.Health );
	}
}