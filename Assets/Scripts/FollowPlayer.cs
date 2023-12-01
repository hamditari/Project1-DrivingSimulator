using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Unity'de kameranýn script componentinde player deðiþkenine vehicle nesnesi süreklenip býrakýlacak
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Update metodunu LastUpdate yaptýk. Böylece kameradaki titreme gitti.
    // LastUpdate metodu Update'ten sonra çalýþtýðý için araç hareket ettikten hemen sonra kamera hareket ediyor.
    void LateUpdate()
    {
        //Kameraya oyuncunun konumunu ekleyerek kameranýn onu takip etmesini saðlýyoruz.
        //offset ekleyerek kamerayý aracýn arkasýna ve üstüne konumlandýrýyoruz.
        transform.position = player.transform.position + offset;
    }
}
