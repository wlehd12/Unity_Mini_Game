using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    public Camera camera;
    public GameObject teleportknife;
    public GameObject currentknife;
    public Transform firePoint;
    public float knifeThrowForce;
    private bool knifeOut = false;

    void Start()
    {
        camera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!knifeOut)
            {
                currentknife = Instantiate(teleportknife, firePoint.position, Quaternion.LookRotation(camera.transform.forward)) as GameObject;
                currentknife.GetComponent<Rigidbody>().AddForce(camera.transform.forward * 40, ForceMode.Impulse);
                
                knifeOut = true;
            }
        }

        Vector3 Positionf = transform.position;
        float length = Vector3.Distance(Positionf, currentknife.transform.position);
        if (length > 30)
        {
            Destroy(currentknife);
            currentknife = null;
            knifeOut = false;
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (knifeOut)
            {
                Vector3 knifePosition = currentknife.transform.position;
                Vector3 teleportLocation = new Vector3(knifePosition.x, knifePosition.y ,knifePosition.z);
                transform.position = teleportLocation;
                Destroy(currentknife);
                currentknife = null;
                knifeOut = false;
            }
        }

    }
}
