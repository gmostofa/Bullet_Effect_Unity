using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    //factor for cube movement speed
    float speed = 10f;
    void Update()
    {
        //get input from keyboard i.e. the arrow keys
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        //add the input values to the Player so as to move it
        transform.position += new Vector3(h, 0, v) * Time.deltaTime * speed * 1 / Time.timeScale;
    }
}