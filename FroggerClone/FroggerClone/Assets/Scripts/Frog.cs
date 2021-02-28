using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;
    // Update is called once per frame

    Vector2 frogStart = new Vector2(0, -4);
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && (rb.position.x < 8))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && (rb.position.x > -8))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && (rb.position.y > -4))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            if (Lives.currentLives == 1)
            {
                Debug.Log("WE LOST!");
                //Score.CurrentScore = 0;
                PlayerPrefs.SetInt("score", Score.CurrentScore);
                SceneManager.LoadScene(2);
            }
            else
            {
                Lives.currentLives -= 1;
                rb.MovePosition(frogStart);
            }
        }
    }
}
