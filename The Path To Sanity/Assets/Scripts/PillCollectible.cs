using UnityEngine;

public class PillCollectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Pílula coletada!");
            Destroy(gameObject);
        }
    }
}