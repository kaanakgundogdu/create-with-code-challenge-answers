using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{

    private float rotationSpeed=1000; // rotasyon hızı pervane içi fazla ayarlandı
    private float horizonalInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizonalInput = Input.GetAxis("Horizontal"); //left and right

        transform.Rotate (Vector3.forward * Time.deltaTime * horizonalInput * rotationSpeed ); // ileri giderken rotate oluyor pervane
        //alternatif çözüm
        /* private float propellorSpeed = 1000;
void Update() {
transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime); */
    }
}
