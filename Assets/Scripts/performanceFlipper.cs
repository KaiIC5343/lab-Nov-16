using UnityEngine;

public class performanceFlipper : MonoBehaviour
{
    public GameObject badSpawner;
    public GameObject optimisedSpawner;
    public bool badMode = true;

    public void flipMode()
    {
        if (!badMode)
        {
            badSpawner.SetActive(true);
            optimisedSpawner.SetActive(false);
            badMode = true;
        } else
        {
            badSpawner.SetActive(false);
            optimisedSpawner.SetActive(true);
            badMode=false;
        }
    }
    private void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Space))
        {
            flipMode();   
        }
    }
}
