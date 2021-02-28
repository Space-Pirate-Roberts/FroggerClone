using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public Rigidbody2D frog;
    private void OnTriggerEnter2D()
    {
        Debug.Log("YOU WON!");
        Score.CurrentScore += 100;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        frog.MovePosition(new Vector2(0, -4));
    }

}
