using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 800f;
    public float sidewaysForce = 600f;

    void FixedUpdate() {   
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
