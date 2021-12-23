using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 lastMousePosition;
    private Vector3 difference;
    [SerializeField] float sensivity = 0.25f;
    [SerializeField] float moveSpeed = 1f;
    private float xPos;

    private void Update()
    {
        Moving();
        SwerveControl();
    }

    private void Moving()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    private void SwerveControl()
    {
        /* ZTK was here
         * Input sistemi oyun kategorisine güzel uymuş.
         * Tavsiyem input olaylarını tamamen oyun kodu içerisinden ayrık tutmak.
         * Player controller mouse u okumaya çalışmasa da bunun sorumlusu bir InputManager gibi bir class olsa
         * Player mouse un ne kadar hareket etmiş olduğunu InputManager üzerinden sorgulasa, oyun kodunu sistem kodundan güzel bir şekilde ayırmış olursun.
         * Kod daha okunaklı olur.
         */

        //Yorumlarınızı okudum ama stack işini çözmekten henüz burayı düzeltmeye girişemedim. -Akın

        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            difference = lastMousePosition - Input.mousePosition;
            lastMousePosition = Input.mousePosition;

            xPos = Mathf.Clamp((transform.position.x - (difference.x * sensivity)), -4f, 4f);
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        }
    }
}
