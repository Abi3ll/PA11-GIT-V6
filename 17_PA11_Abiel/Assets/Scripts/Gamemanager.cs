
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{

    public static int Scorevalue;
    public int displayscore;
    public Text ScoreText;
    ObstacleMovement prefabs;
    void Start()
    {
        Scorevalue = 0;
        displayscore = 0;
        ScoreText = GetComponent<Text>();
        prefabs = GetComponent<ObstacleMovement>();
    }
    void Update()
    {       
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        ScoreText.text = "Score : " + Scorevalue;
        if (collision.gameObject.tag == "cube")
        {
            Debug.Log("Collision detected");

            
            Scorevalue += 10;
        }
    }

    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
