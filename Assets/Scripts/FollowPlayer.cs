using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Unity'de kameran�n script componentinde player de�i�kenine vehicle nesnesi s�reklenip b�rak�lacak
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Update metodunu LastUpdate yapt�k. B�ylece kameradaki titreme gitti.
    // LastUpdate metodu Update'ten sonra �al��t��� i�in ara� hareket ettikten hemen sonra kamera hareket ediyor.
    void LateUpdate()
    {
        //Kameraya oyuncunun konumunu ekleyerek kameran�n onu takip etmesini sa�l�yoruz.
        //offset ekleyerek kameray� arac�n arkas�na ve �st�ne konumland�r�yoruz.
        transform.position = player.transform.position + offset;
    }
}
