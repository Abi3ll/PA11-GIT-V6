using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ObstacleMovement : MonoBehaviour
{
    private float xSpeed = -4f;
    
    // Start is called before the first frame update
    void Start()
    {
       Gamemanager gamemanager = GetComponent<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(xSpeed*Time.deltaTime, 0, 0f));
        if (transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collide");
            SceneManager.LoadScene("GameOver");
            //Destroy(this.gameObject);
        }
    }
}
