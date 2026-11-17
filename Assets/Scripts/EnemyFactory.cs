using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
   
    public GameObject createEnemy(Vector3 position)
    {
        return poolEnemies.instance.GetEnemy(position);
    }

}
