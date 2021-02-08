using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{  
    public Ball ball;
    public Player p1;
    public Player p2;
    private Rigidbody rb;
    public bool isGoal1;
    public int Sp1=0;
    public int Sp2=0;

    //ScoreP1 ScoreP1;
    //ScoreP2 ScoreP2;
    // Start is called before the first frame update
    void Start()
    {
      //score1 = GetComponent<ScoreP1>();
      //score2= GetComponent<ScoreP2>();
    }
    public void Reset()
    {
      ball.transform.position = this.gameObject.transform.position;
      rb.useGravity = false;
      rb.velocity = Vector3.zero;

    }
    void OnTriggerEnter(Collider other)
      {
        if(isGoal1)
        {
          Sp1+=1;
          Debug.Log($"Player2 Scored total Score:{Sp1}");
          Reset();
        }
        else
        {
          Sp2+=1;
          Debug.Log($"Player1 Scored total Score{Sp2}");
          Reset();
        }
      }
    // Update is called once per frame
    void Update()
    {

}
}
