using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    /*int jumpScore = 0;
    public Text jumpScoreText;

    public float jumpeForce = 20f;*/

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }


    /*private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "JumpScore")
        {
            jumpScore++;
            jumpScoreText.text = jumpScore.ToString();
            if (jumpScore >= 3)
            {
                if (Input.GetButton("Jump"))
                {
                    Debug.Log("Jump");
                    rb.AddForce(0, jumpeForce * Time.deltaTime, 0, ForceMode.VelocityChange);
                    jumpScore = 0;
                }
                jumpScore--;
            }
        }
    }*/
}
