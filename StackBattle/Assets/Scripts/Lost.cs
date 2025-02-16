using UnityEngine;

public class Lost : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
}
