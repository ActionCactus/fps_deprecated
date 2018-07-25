using UnityEngine;
using UnityEngine.Networking;

public class PlayerCharacterNetworkElement : NetworkBehaviour
{
    public Behaviour[] disabledComponents;

    void Start()
    {
        if (!isLocalPlayer)
        {
            foreach (Behaviour component in this.disabledComponents)
            {
                component.enabled = false;
            }
        }
    }
}