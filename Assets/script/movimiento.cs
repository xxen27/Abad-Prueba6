using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class movimiento : MonoBehaviour
{
    [SerializeField] protected float speed = 5f; // Velocidad de movimiento

    // M�todo abstracto para mover el objeto
    public abstract void Move(Vector3 direction);
}

