using UnityEngine;

public class CollectableEvents : MonoBehaviour {

    public delegate void OnPickupDelegate(int newVal);
    public event OnPickupDelegate OnPickup;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "PlayerCharacter")
        {
            if(OnPickup != null)           
                OnPickup(5);
        }
    }
}
