using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
