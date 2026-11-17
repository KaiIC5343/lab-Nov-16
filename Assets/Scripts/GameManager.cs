using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Transform playerTransform;
    public int enemyCount = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void addEnemy()
    {
        enemyCount++;
    }
    public void RemoveEnemy()
    {
        enemyCount--;
    }
}
