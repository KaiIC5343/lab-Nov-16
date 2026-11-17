using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class poolEnemies : MonoBehaviour
{
    public static poolEnemies instance;
    public GameObject enemyFab;
    [SerializeField] private List<GameObject> pool = new List<GameObject>();

    private void Awake()
    {
        instance = this;
        for (int i = 0; i < 200; i++)
        {
            GameObject enemy = Instantiate(enemyFab, transform);
            enemy.SetActive(false);
            pool.Add(enemy);
        }
    }
    public GameObject GetEnemy(Vector3 position)
    {
        foreach (GameObject enemy in pool) {
            if ((!enemy.activeInHierarchy)) {
                enemy.transform.position = position;
                enemy.GetComponent<Enemy>().setPooling(true);
                enemy.SetActive (true);
                GameManager.instance.addEnemy();
                return enemy;
            }

        }
        return null;
    }
   public void ReturnEnemy(GameObject enemy)
    {
        enemy.SetActive(false);
        GameManager.instance.RemoveEnemy();
    }
}
