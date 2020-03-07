using UnityEngine;
using UnityEngine.Networking;

public class HostColorChanger : NetworkBehaviour
{
    [SerializeField] Renderer _renderer;
    [SerializeField] Material _clientMaterial;
    [SerializeField] Material _hostMaterial;

    [SyncVar] bool _isHost;

    private void Update()
    {
        if (isServer)
        {
            if (isLocalPlayer)
            {
                _isHost = true;
            }
            else
            {
                _isHost = false;
            }
        }
        if (_isHost)
        {
            _renderer.material = _hostMaterial;
        }
        else
        {
            _renderer.material = _clientMaterial;
        }
    }
}
