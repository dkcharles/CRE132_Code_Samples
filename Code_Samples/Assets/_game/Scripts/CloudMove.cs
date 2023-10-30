using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    [SerializeField] float cloudSpeed;
    [SerializeField] int cloudXresetPosition;

    void Start()
    {
        cloudSpeed = Random.Range(0, 0.2f) + 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.right * cloudSpeed * Time.deltaTime);

        // Check if the object is out of the camera view
        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);

        // Check if the sprite is outside the screen bounds
        if (viewportPosition.x > 1f)
        {
            // The sprite is off-screen. Take appropriate action.
            this.transform.position = new Vector3(cloudXresetPosition, this.transform.position.y, this.transform.position.z);
        }
    }
}
