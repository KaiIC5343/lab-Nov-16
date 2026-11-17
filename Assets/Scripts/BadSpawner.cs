using Unity.Hierarchy;
using UnityEngine;

public class BadSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 0.1f;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;
             Vector3 position = new Vector3(Random.Range(-20f, 20f),1f,Random.Range(-20f, 20f));
            GameObject newEnemy = Instantiate(enemyPrefab, position, Quaternion.identity);
            newEnemy.GetComponent < Enemy>().setPooling(false) ;
            GameManager.instance.addEnemy();
        }
    }
}
