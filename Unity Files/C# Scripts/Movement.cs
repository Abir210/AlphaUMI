using UnityEngine;

public class Movement : MonoBehaviour
{
	public Rigidbody lm;

    // Update is called once per frame
    void FixedUpdate()
    {
        lm.AddForce(0, 0, 200 * Time.deltaTime);
    }
}
