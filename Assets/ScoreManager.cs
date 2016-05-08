using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text ScoreP1;
    public Text ScoreP2 = new  t;
    public static int ScorePlayer1 = 0;
    public static int ScorePlayer2 = 0;

	// Use this for initialization
    //void Start () {
	
    //}
	
	// Update is called once per frame
    //void Update () {
	    
    //}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "MuroDestro")
        {
            ScorePlayer1 = ScorePlayer1 + 1;
            ScoreP1.text = ScorePlayer1.ToString();
        }

        if (col.gameObject.name == "MuroSinistro")
        {
            ScorePlayer2 = ScorePlayer2 + 1;
            ScoreP2.text = ScorePlayer2.ToString();
        }
    }
}
