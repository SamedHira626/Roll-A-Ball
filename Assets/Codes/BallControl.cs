using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    Rigidbody physics;
    public int speed;
    int count = 0;
    public int collectingCoins;
    public Text counterText;
    public Text youDidText;
    void Start()
    {
        physics = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(yatay, 0, dikey);
        physics.AddForce(vec*speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "block")
        {
            other.gameObject.SetActive(false);
            count++;
            counterText.text = "Count = " + count;
            if(count == collectingCoins)
            {
                youDidText.text = "You did !";
            }
        }
    }

}
