using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    private Animator anm;
    public float testForce;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Rigidbody>().useGravity = false;
        anm = this.gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
       
    }


    public void DisableIt()
    {
        anm.enabled = false;
        transform.parent = null;
        this.gameObject.GetComponent<Rigidbody>().useGravity = true;
        this.gameObject.GetComponent<Rigidbody>().AddForce(0, 0, -testForce, ForceMode.VelocityChange);
    }
}
