using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuConroler : MonoBehaviour {

    [SerializeField] private string VersionName = "0.1";
    [SerializeField] private GameObject MenuUsuario;
    [SerializeField] private GameObject ConectarPanel;

    [SerializeField] private InputField UsuarioInput;
    [SerializeField] private InputField CrearJuego;
    [SerializeField] private InputField EntrarJuego;

    [SerializeField] private GameObject BotonIniciar;


    // Use this for initialization
    void Start () {
        MenuUsuario.SetActive(true);
	}
	

    public void CambiarUsuario()
    {
        if (UsuarioInput.text.Length >= 3)
        {
            BotonIniciar.SetActive(true);
        }
    }
    public void SetNombreUsuario()
    {
        MenuUsuario.SetActive(false);
        PlayerStorage.playerName = UsuarioInput.text;
    }
    public void CreacionJuego()
    {
        //PhotonNetwork.CreateRoom(CrearJuego.text, new RoomOptions() { maxPlayers = 4 }, null);
        PlayerStorage.habitacion = CrearJuego.text;
        PlayerStorage.crear = 1;
        Application.LoadLevel("Personajes");
    }
    public void EntraJuego()
    {
        //RoomOptions room = new RoomOptions();
        //room.maxPlayers = 5;
        //PhotonNetwork.JoinOrCreateRoom(EntrarJuego.text, room, TypedLobby.Default);
        PlayerStorage.habitacion = CrearJuego.text;
        PlayerStorage.entrar = 1;
        Application.LoadLevel("Personajes");
    }

}
