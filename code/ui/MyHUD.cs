using Sandbox;
using Sandbox.UI;

public partial class HudClient : HudEntity<RootPanel>
{
	public HudClient()
	{
		if ( !IsClient ) return;

		RootPanel.AddChild<PlayerHudClient>();
	}
}
