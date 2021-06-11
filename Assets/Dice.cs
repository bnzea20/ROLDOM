using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

    public Sprite[] diceSides;
    private SpriteRenderer rend;
    private int whosTurn = 1;
    private bool coroutineAllowed = true;
    public bool moveAllowed1 = false;

    // Use this for initialization
    private void Start () {
        rend = GetComponent<SpriteRenderer>();
        rend.sprite = diceSides[5];
	}

    void Update()
    {
        //if (!GameControl.gameOver && coroutineAllowed)
        if(moveAllowed1)
            StartCoroutine("RollTheDice");
    }

    private IEnumerator RollTheDice()
    {
        moveAllowed1 = true;
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        } 
        moveAllowed1 = false;
        /*
        GameControl.diceSideThrown = randomDiceSide + 1;
        if (whosTurn == 1)
        {
            GameControl.MovePlayer(1);
        } else if (whosTurn == -1)
        {
            GameControl.MovePlayer(2);
        }
        whosTurn *= -1;
        coroutineAllowed = true;*/
    }
}
