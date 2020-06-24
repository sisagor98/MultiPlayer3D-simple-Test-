
using Mirror;
using UnityEngine;
using UnityEngine.Networking;

public class TrunOffRemotePlayer : NetworkBehaviour
{
    private void Start()
    {
        string id = string.Format("{0}", this.netId);
        PlayerContoller scr = this.GetComponent<PlayerContoller>();
        if (this.isLocalPlayer == true)
        {
            scr.enabled = true;
            scr.SetPlayerCaption(id);
            scr.SetTitle("Multi Player #" +id);

        }
        else
        {
            scr.SetPlayerCaption(id);
            scr.enabled = false;
        }
    }
}
