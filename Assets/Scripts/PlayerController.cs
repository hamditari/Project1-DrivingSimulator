using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //değişkenleri public olarak tanımladığımızda unity editor içerisinden erişebiliriz
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        //Kullanıcı girişlerini (sağ-sol, ileri-geri) alıyoruz
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //İleri-geri hareket
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Sağa sola dönüş
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); //sağa sola kayarak gider
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput); //Sağa sola döner
    }
}
