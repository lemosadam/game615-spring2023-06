using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float forwardSpeed = 100f;
    float rotateSpeed = 75f;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime * forwardSpeed * vAxis, Space.World);
        gameObject.transform.Rotate(0,rotateSpeed * Time.deltaTime * hAxis, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        // 'other' is the name of the collider that just collided with the object
        // that this script ("PlayerController") is attached to. So the if statment
        // below checks to see that that object has the tag "coin". Remember that
        // the tags for GameObjects are assigned in the top left area of the
        // inspector when you select the obect.
        if (other.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            gm.IncrementScore();
        }

        if (other.CompareTag("enemy"))
        {
            Debug.Log("collided");
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.AddForce(gameObject.transform.forward * -10000);
        }
    }

    
}
