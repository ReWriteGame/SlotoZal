using UnityEngine;

[RequireComponent(typeof(Collider))]
public class AreaEffector : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float force;
  

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.GetComponent<Rigidbody>())
            other.gameObject.GetComponent<Rigidbody>().AddForce(direction.normalized * force,ForceMode.Impulse);
    }
}
