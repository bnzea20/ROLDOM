using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelector : MonoBehaviour {

    [SerializeField] private string VersionName = "0.1";
    public Image[] selectionBoxes;
    public GameObject[] prefabs;
    public Text texto;
    private int obj1, obj2, obj3, obj4,obj;
    public Button jugar;

    private void Awake()
    {
        PhotonNetwork.ConnectUsingSettings(VersionName);
    }

    // Use this for initialization
    void Start () {
		foreach (var img in this.selectionBoxes)
        {
            img.gameObject.SetActive(false);
            obj = 4;
            obj1 = -1;
            obj2 = -1;
            obj3 = -1;
            obj4 = -1;

        }
        this.Select(0);
	}

    private void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
        Debug.Log("Conectado");
    }

    public void Select(int index)
    {

        if (index == obj1)
        {
            this.selectionBoxes[index].gameObject.SetActive(false);
            obj1 = -1;
            obj++;
            texto.text = "Jugadores restantes: " + obj;
            PlayerStorage.playerPrefab1 = index;
        }
        else if (index == obj2)
        {
            this.selectionBoxes[index].gameObject.SetActive(false);
            obj2 = -1;
            obj++;
            texto.text = "Jugadores restantes: " + obj;
            PlayerStorage.playerPrefab2 = index;
        }
        else if (index == obj3)
        {
            this.selectionBoxes[index].gameObject.SetActive(false);
            obj3 = -1;
            obj++;
            texto.text = "Jugadores restantes: " + obj;
            PlayerStorage.playerPrefab3 = index;
        }
        else if (index == obj4)
        {
            this.selectionBoxes[index].gameObject.SetActive(false);
            obj4 = -1;
            obj++;
            texto.text = "Jugadores restantes: " + obj;
            PlayerStorage.playerPrefab4 = index;
        }
        else if (obj1 == -1)
        {
            this.selectionBoxes[index].gameObject.SetActive(true);
            obj1 = index;
            obj--;
            texto.text = "Jugadores restantes: " + obj;
        }
        else if (obj2 == -1)
        {
            this.selectionBoxes[index].gameObject.SetActive(true);
            obj2 = index;
            obj--;
            texto.text = "Jugadores restantes: " + obj;
        }
        else if (obj3 == -1)
        {
            this.selectionBoxes[index].gameObject.SetActive(true);
            obj3 = index;
            obj--;
            texto.text = "Jugadores restantes: " + obj;
        }
        else if (obj4 == -1)
        {
            this.selectionBoxes[index].gameObject.SetActive(true);
            obj4 = index;
            obj--;
            texto.text = "Jugadores restantes: " + obj;
        }
        if (texto.text == "Jugadores restantes: 0")
        {
            jugar.gameObject.SetActive(true);
        }
        else
        {
            jugar.gameObject.SetActive(false);
        }
    }
    

    public void EntraJuego()
        {

        if (PlayerStorage.crear == 1)
        {
            PhotonNetwork.playerName = PlayerStorage.playerName;
            PhotonNetwork.CreateRoom(PlayerStorage.habitacion, new RoomOptions() { maxPlayers = 4 }, null);
        }else if(PlayerStorage.entrar == 1)
        {
            PhotonNetwork.playerName = PlayerStorage.playerName;
            RoomOptions room = new RoomOptions();
            room.maxPlayers = 5;
            PhotonNetwork.JoinOrCreateRoom(PlayerStorage.habitacion, room, TypedLobby.Default);
        }
            
        }
    private void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Juego");
    }
}
