using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //put variables here
    public float s;
    public float rs;
    Rigidbody rb;
    int coins = 0; /* we always start this variable at zero, when we start the game you haven’t picked up any coins! */
    void Start()
    float sc;

    {
        //initialize variables here
        s = 4f; /* change the 4 to whatever you want */
        rs = 40f; /* this is how many degrees you turn per second, change the 40 to whatever you want */
        rb = GetComponent<Rigidbody>();
        sc = 2f;
    }
    void Update()
    {
            //Input.GetKey returns true if the key is being pressed down during that frame
            if (Input.GetKey(KeyCode.W))
            {
                //move forward line
                rb.MovePosition(transform.position + transform.forward * s * Time.deltaTime);  /* this one goes forward */
            }
            else if (Input.GetKey(KeyCode.S))
            {
            //move back line
            rb.MovePosition(transform.position - transform.forward * s * Time.deltaTime); /* this one goes backwards */
            }
            if (Input.GetKey(KeyCode.A))
            {
                //rotate left line
                transform.Rotate( /* is this one positive or negative? */
                Vector3.up * rs *Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D))
            {
            //rotate right line
            transform.Rotate(/* is this one positive or negative? */ -Vector3.up * rs * Time.deltaTime);
            }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Coin"))
        {
            coins = coins + 1; /* now that we’ve run into another coin, we’ll increase our count of how many we have! */
        }

        Destroy(other.gameObject);
    }
    else if (other.gameObject.tag.Equals("SpeedUp"))
{
    s = s * sc;
}
else if (other.gameObject.tag.Equals("SlowDown"))
{
    s = s / sc;
} /* note the divide vs. the multiply */

IEnumerator StarCoruotine()
{
    yield return new WaitForSeconds(5f); /* replace the 5 with however long you want the boost to last */
    s = s / sc; /* note this is a reversal of how we sped up, this brings our speed back to normal */
}

else if (other.gameObject.tag.Equals(“SpeedUp”))
{
    s = s * sc;
    StartCoruotine(SpeedUpCoroutine());
}

IEnumerator SDC()
{
    yield return new WaitForSeconds(5f); /* replace the 5 with however long you want the trap to last, probably should be the same as the boost */
    s = s * sc; /* note this is a reversal of how we slowed down, this brings our speed back to normal */
}

else if (other.gameObject.tag.Equals(“SlowDown”))
{
    s = s / sc;
    StartCoroutine(SlowDownCoroutine());
}

if (other.gameObject.tag.Equals(“Coin”))
{
    coins = coins + 1; /* now that we’ve run into another coin, we’ll increase our count of how many we have! */
    Destroy(other.gameObject);
}
else if (other.gameObject.tag.Equals(“SpeedUp”))
{
    s = s * sc;
    StartCoroutine(SpeedUpCoroutine());
    Destroy(other.gameObject);
}
else if (other.gameObject.tag.Equals(“slowDownTag”))
{
    s = s / sc;
    StartCoroutine(SlowDownCoroutine());
    Destroy(other.gameObject);
} 



}

