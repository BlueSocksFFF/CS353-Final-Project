using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBehavior : MonoBehaviour
{
    public float BlastPower = 15;
    public GameObject Ball;
    public GameObject Explosion;
    public Transform ShotPoint;
    public AudioSource gunShot;

    // color
    public byte colorRatio = 1;
    public byte a = 125;
    public byte b = 125;
    public byte c = 125;

    public float rotationDegree = 5.0f;
    public ColorBar colorBar;
    public Gun gun;
    // Start is called before the first frame update
    void Start()
    {
        gunShot = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            colorBar.setColor(a, b, c);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gun.transform.Rotate(0, -rotationDegree, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gun.transform.Rotate(0, rotationDegree, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gun.transform.Rotate(-rotationDegree, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gun.transform.Rotate(rotationDegree, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A)) // camera left
        {
            this.transform.Rotate(0, rotationDegree, 0);
        }
        if (Input.GetKeyDown(KeyCode.D)) // camera right 
        {
            this.transform.Rotate(0, -rotationDegree, 0);
        }
        if (Input.GetKeyDown(KeyCode.W)) // camera forward 
        {
            this.transform.Translate(Vector3.forward * 2);
        }
        if (Input.GetKeyDown(KeyCode.S)) // camera backward 
        {
            this.transform.Translate(-Vector3.forward * 2);
        }
        /*
        if (Input.GetKeyDown(KeyCode.W)) // camera forward
        {
            this.transform.Rotate(rotationDegree, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S)) // camera backward
        {
            this.transform.Rotate(-rotationDegree, 0, 0);
        }
        */
        if (Input.GetKeyDown(KeyCode.X))
        {
            // gunshot sound
            gunShot.Play();

            // paint ball
            GameObject CreatedBall = Instantiate(Ball, ShotPoint.position, ShotPoint.rotation);
            CreatedBall.GetComponent<Renderer>().material.color = colorBar.image.color;
            CreatedBall.GetComponent<Rigidbody>().velocity = ShotPoint.transform.up * BlastPower;

            // explosion
            GameObject Explosive = Instantiate(Explosion, ShotPoint.position, ShotPoint.rotation);
            Explosive.GetComponent<ParticleSystem>().startColor = colorBar.image.color;
            Destroy(Explosive, 2);

        }
    }
}
