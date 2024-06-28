using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class MovimientoCanasta : movimiento
{
    public float minX = -7f; // Límite izquierdo en X
    public float maxX = 7f; // Límite derecho en X

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(movimientoHorizontal, 0f, 0f);

        Move(direction);
    }

    public override void Move(Vector3 direction)
    {
        float newPositionX = transform.position.x + direction.x * speed * Time.deltaTime;
        newPositionX = Mathf.Clamp(newPositionX, minX, maxX); // Limitar la posición en X

        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }

    public string tagObjetoADestruir = "ObjetoA";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(tagObjetoADestruir))
        {
            Destroy(collision.gameObject);
               // scoreObject.GetComponent<ScoreManager>().AddScore(1);

        }
    }
}




