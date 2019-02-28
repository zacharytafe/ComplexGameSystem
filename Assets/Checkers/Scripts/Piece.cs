using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Checkers
{
    public class Piece : MonoBehaviour
    {
        public bool isWhite, isKing;
        public int x, y;

        private Animator anim;

        // Use this for initialization
        void Start()
        {
            // Get reference to animator
            anim = GetComponent<Animator>();
        }

        public void King()
        {
            isKing = true;
            anim.SetTrigger("King");
        }
    }
}