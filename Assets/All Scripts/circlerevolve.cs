using UnityEngine;

public class circlerevolve : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0, 0,75 * Time.deltaTime);
    }
}
