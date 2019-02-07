using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Checkers
{
    public class CheckersBoard : MonoBehaviour
    {
        [Tooltip("Prefabs for Checker Pieces")]
        public GameObject WhitePiecePrefab, blackPiecePrefab;
        [Tooltip("Where to attach the spawned pieces in the the Hierarchy")]
        public Transform checkersParent;
        public Vector3 boardOffset = Vector3.zero;
        public Vector3 pieceOffset = new Vector3(.5f, 0, .5f);

        // Use this for initialization
        void Start()
        {
            GenerateBoard();
        }

       /// <summary>
       /// Generates a character a Checker Piece in specified coordinates
       /// </summary>
       /// <param name="x">X Location</param>
       /// <param name="y">Y Location</param>
       public void GeneratePiece(int x, int y, bool isWhite)
        {
            GameObject prefab = isWhite ? WhitePiecePrefab : blackPiecePrefab;
            GameObject clone = Instantiate(prefab, checkersParent);
            clone.transform.localPosition = new Vector3(x, 0, y) + boardOffset + pieceOffset;
        }
       
        public void GenerateBoard()
        {
            for(int y = 0; y < 3; y++)
            {
                bool oddRow = y % 2 == 0;
                for (int x = 0; x < 8; x += 2)
                {
                    GeneratePiece(oddRow ? x : x + 1, y, true);
                }
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}