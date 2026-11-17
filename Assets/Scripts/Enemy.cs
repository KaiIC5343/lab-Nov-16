using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    private Transform playerTransform;
    private bool usePooling;

    private void OnEnable()
    {
        if (GameManager.instance != null) {
        playerTransform = GameManager.instance.playerTransform;

        }
    }


    private void Update()
    {
        if (playerTransform == null)
        {
            return;
        }
        if (Vector3.Distance(transform.position, playerTransform.position) < 1f) {
            Die();
            return;
        }
        Vector3 moveDir = (playerTransform.position - transform.position).normalized;
        transform.position += moveDir * speed * Time.deltaTime;
       

    }
    private void OnDisable()
    {
        playerTransform = null;

        
    }
    public void Die()
    {
        if (usePooling)
        {
            poolEnemies.instance.ReturnEnemy(gameObject);
        }
        else
        {
            GameManager.instance.RemoveEnemy();
            Destroy(gameObject);
        }
    }

    public void setPooling(bool pooling)
    {
        usePooling = pooling;

    }
}
