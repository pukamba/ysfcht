using Mirror;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CustomNetworkManager : NetworkManager
{
    [SerializeField]private PlayerObjectController GamePlayerPrefab;
    public List<PlayerObjectController> GamePlayers { get; } = new List<PlayerObjectController>();



    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        if (SceneManager.GetActiveScene().name == "Lobby")
        {
            PlayerObjectController GamePLayerInstance = Instantiate(GamePlayerPrefab);
        }





    }



}
