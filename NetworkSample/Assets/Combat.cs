using UnityEngine;
using UnityEngine.Networking;

public class Combat : NetworkBehaviour
{
    public const int maxHealth = 100;
    [SyncVar]
    public int health = maxHealth;

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            health = 0;
            Debug.Log("Dead!");
        }
    }

    public void OnGUI()
    {
        if (!isLocalPlayer)
            return;

        GUI.color = Color.red;
        GUI.Label(new Rect(100, 10, 200, 40), "HPs: " + health);
    }
}