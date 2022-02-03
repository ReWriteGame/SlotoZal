using UnityEngine;


[RequireComponent(typeof(BoxCollider),typeof(Rigidbody))]
public class SetterCurrentSideCube : MonoBehaviour
{ 
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<SideCube>())
        {
            int currentSide = 7 - other.gameObject.GetComponent<SideCube>().Number;
            other.gameObject.GetComponentInParent<Cube>().SetCurrentSide(currentSide);
        }
    }
}
