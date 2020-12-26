using UnityEngine;

public class DeliverySpot : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Pickup pickUp = collision.gameObject.GetComponent<Pickup>();
            pickUp.DropOff();
        }
    }
}
