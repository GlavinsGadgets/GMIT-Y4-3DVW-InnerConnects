using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPiece : MonoBehaviour
{
    // Script to destroy the object as soon as it touches the colider.
    public void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
        // Debug.Log(col);
        PieceManager Piece = FindObjectOfType<PieceManager>();
        Piece.destoyed(col.name);
    }
}
