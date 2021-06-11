using System.Collections;
using UnityEngine;

public class Dado : MonoBehaviour
{
    public GameObject Dado1, Dado2;

    // Use this for initialization
    private void Start()
    {
    }
    void OnMouseDown()
    {
        Dado1.GetComponent<Dice>().moveAllowed1 = true;
        Dado2.GetComponent<Dice>().moveAllowed1 = true;
    }
}
