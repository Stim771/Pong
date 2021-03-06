using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallMovement : MonoBehaviour
{
       public Text scorerightText;
       public Text scoreleftText;
       public int scoreRight;
       public int scoreLeft;

      public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                float racketHeight)
    {
        // ascii art:
        // ||  1 <- at the top of the racket
        // ||
        // ||  0 <- at the middle of the racket
        // ||
        // || -1 <- at the bottom of the racket
        return (ballPos.y - racketPos.y) / racketHeight;
    }
    void OnCollisionEnter2D(Collision2D col)
    {


        // Note: 'col' holds the collision information. If the
        // Ball collided with a racket, then:
        //   col.gameObject is the racket
        //   col.transform.position is the racket's position
        //   col.collider is the racket's collider

        // Hit the left Racket?
        if (col.gameObject.name == "WallLeft")
        {
            
            
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;

            scoreLeft++;
            // this line will co,vert the int score variable to a string variable
            scoreleftText.text = scoreLeft.ToString();
        }

        // Hit the right Racket?
        if (col.gameObject.name == "WallRight")
        {
            
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
            scoreRight++;
            scorerightText.text = scoreRight.ToString();
        }
      }
    }
