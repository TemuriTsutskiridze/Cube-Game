using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    //This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;


    int jumpScore = 0;
    public Text jumpScoreText;

    public float jumpeForce = 250f;

    bool canJump = false;

    //We use FixedUpdate for physics
    void FixedUpdate() {
        
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();  
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "JumpScore")
        {
            jumpScore++;
            jumpScoreText.text = jumpScore.ToString();
        }

        if (jumpScore >= 3)
        {
            canJump = true;
        }

    }

    private void Update()
    {
        


        if (Input.GetKeyDown("w"))
        {
            if (canJump == true)
            {
                rb.AddForce(0, jumpeForce * Time.deltaTime, 0, ForceMode.VelocityChange);
                jumpScore = 0;
                jumpScoreText.text = "0";
                canJump = false;
            }

        }
    }
}
