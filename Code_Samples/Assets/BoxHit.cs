using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnMouseDown is called when the user has pressed the mouse button while over the GUIElement or Collider
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }


}
