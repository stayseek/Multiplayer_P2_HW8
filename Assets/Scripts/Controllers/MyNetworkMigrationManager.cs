using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkMigrationManager : NetworkMigrationManager
{
    protected override void OnServerHostShutdown()
    {
        Debug.Log("Server was shutdowned.");
        base.OnServerHostShutdown();
    }

    protected override void OnServerReconnectPlayer(NetworkConnection newConnection, GameObject oldPlayer, int oldConnectionId, short playerControllerId)
    {
        Debug.Log($"Player was {oldPlayer.name} reconnected.");
        base.OnServerReconnectPlayer(newConnection, oldPlayer, oldConnectionId, playerControllerId);
    }
}
