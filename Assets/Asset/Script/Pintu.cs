using UnityEngine;
using UnityEngine.SceneManagement;

public class Pintu : MonoBehaviour
{

    [SerializeField] private string GantiScene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
                 SceneManager.LoadScene(GantiScene);
            
        }

        
    }
}
