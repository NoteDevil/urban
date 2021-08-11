using Sandbox;

public partial class MyGame : Sandbox.Game
{
		public HudClient HudClient;

		public MyGame(){
			if ( IsClient ) HudClient = new HudClient();
		}

		[Event.Hotload]
		public void HotloadUpdate(){
			if ( !IsClient ) return;
			HudClient?.Delete();
			HudClient = new HudClient();
		}

		public override void ClientJoined( Client client)
		{
		base.ClientJoined( client );

		var player = new MyPlayer();
		client.Pawn = player;

		player.Respawn();
		}
}
