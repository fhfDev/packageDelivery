using UnityEngine;
using UnityEngine.SceneManagement;

public class hallwayToElevator : MonoBehaviour
{
    [SerializeField]
    private string nextSceneName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(nextSceneName);
    }
}
