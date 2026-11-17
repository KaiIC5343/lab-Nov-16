using UnityEngine;

public class OptimisedSpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnInterval = 0.1f;
    [SerializeField] float timer;
    public EnemyFactory enemyFactory;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            timer = 0f;
            Vector3 position = new Vector3(Random.Range(-20f, 20f), 1f, Random.Range(-20f, 20f));
            enemyFactory.createEnemy(position);
            //GameManager.instance.addEnemy(); doubled up with ht epool script
        }
    }
}
