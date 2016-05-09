using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        var hit = collision.gameObject;
        var hitPlayer = hit.GetComponent<MovePlayer>();
        if (hitPlayer != null)
        {
            Destroy(gameObject);
        }
    }
}
