using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using Steamworks;
using UnityEngine.UI;
using System.Linq;

public class LobbyController : MonoBehaviour
{
    public static LobbyController Instance;

    //UI Elements
    public Text LobbyNameText;

    //Player Data
    public GameObject PlayerListViewContent;
    public GameObject PlayerListItemPrefab;
    public GameObject LocalPlayerObject;

    //Other Data
    public ulong CurrentLobbyID;
    public bool PlayerItemCreated = false;
    private List<PlayerListItem> PlayerListItems = new List<PlayerListItem>();
    public PlayerObjectController LocalplayerController;

    //Manager
    private CustomNetworkManager manager;

    private CustomNetworkManager Manager
    {
        get
        {
            if (manager == null)
            {
                return manager;
            }
            return manager = CustomNetworkManager.singleton as CustomNetworkManager;

        }
    }

    private void Awake()
    {
        if (Instance == null) { Instance = this; }
    }

    public void UpdateLobbyName()
    {
        CurrentLobbyID = Manager.GetComponent<SteamLobby>().CurrentLobbyID;
        LobbyNameText.text = SteamMatchmaking.GetLobbyData(new CSteamID(CurrentLobbyID), "name");
    }

    public void UpdatePlayerList()
    {
        if(!PlayerItemCreated) { CreateHostPlayterItem(); } //Host
        if(PlayerListItems.Count < Manager.GamePlayers.Count) { CreateClientPlayerItem(); }

    }

    public void CreateHostPlayterItem()
    {

    }

    public void CreateClientPlayerItem()
    {

    }

    public void UpdatePlayerItem()
    {

    }

    public void RemovePlayerItem()
    {

    }

}
