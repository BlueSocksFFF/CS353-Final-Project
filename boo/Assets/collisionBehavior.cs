using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionBehavior : MonoBehaviour
{
    public Renderer rend;
    public Collider col; 
    public AudioSource ballPop;
    public Brush brush;
    public ColorBar colorBar;
    // colorBar.image.color 
    public bool RandomChannel = false;


       public void OnCollisionEnter(Collision collision)
   {
        if (collision.gameObject.tag == "Scene")
        {
            rend = this.GetComponent<Renderer>();
            col = this.GetComponent<Collider>();
            ballPop = this.GetComponent<AudioSource>();
            rend.enabled = false;
            col.enabled = false;
            ballPop.Play();
            Destroy(this.gameObject, 0.2f);
        }
        // foreach (ContactPoint contact in collision.contacts){
        //     PaintTarget paintTarget = contact.otherCollider.GetComponent<PaintTarget>();
        // if (collision.gameObject.tag == "Scene" & paintTarget != null)
        // {
        //     rend = this.GetComponent<Renderer>();
        //     col = this.GetComponent<Collider>();
        //     ballPop = this.GetComponent<AudioSource>();
        //     rend.enabled = false;
        //     col.enabled = false;

        //     if (RandomChannel) brush.splatChannel = Random.Range(0, 4);
        //     PaintTarget.PaintObject(paintTarget, contact.point, contact.normal, brush);
            
        //     ballPop.Play();
        //     Destroy(this.gameObject, 0.2f);
        // }
        // }
   }
}
