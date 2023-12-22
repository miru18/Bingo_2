using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Ball;
    public float[] number;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // GameObject New_Ball=Instantiate(Ball, transform.position, Quaternion.identity);
           // Destroy(New_Ball,3);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            print("sphere hitted cube");
        }
    }
    
}
