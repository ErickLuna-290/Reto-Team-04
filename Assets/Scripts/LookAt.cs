using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;

    public float speed = 1.0f;
    void Update()
    {
        //transform.LookAt(target);

        Vector3 targetDirection = target.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
    }
}
