using UnityEngine;

public class PillCollectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("P�lula coletada!");
            Destroy(gameObject);
        }
    }
}