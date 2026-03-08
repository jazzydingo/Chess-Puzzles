using UnityEngine;
using UnityEngine.UI;

public class PieceMovementHandler : MonoBehaviour
{
    public GameObject pieceToMove;
    public GameObject[] squareList;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pieceToMove != null)
        {
            switch (pieceToMove.GetComponent<PieceController>().piece)
            {
                case Piece.King:
                    float x = pieceToMove.GetComponent<PieceController>().correspondingLocation.x;
                    float y = pieceToMove.GetComponent<PieceController>().correspondingLocation.y;
                    foreach(GameObject squareObj in squareList)
                    {
                        SquareController square = squareObj.GetComponent<SquareController>();
                        if ((square.location.x == x || square.location.x == x + 1 || square.location.x == x - 1) && (square.location.y == y || square.location.y == y + 1 || square.location.y == y - 1) && !(square.location.y == y && square.location.x == x))
                            square.GetComponent<Image>().color = Color.red;
                        else
                            square.GetComponent<Image>().color = square.GetComponent<SquareController>().originalColor;
                        
                    }
                    break;
            }
        }
        else
        {
            foreach(GameObject squareObj in squareList)
            {
                SquareController square = squareObj.GetComponent<SquareController>();
                square.GetComponent<Image>().color = square.GetComponent<SquareController>().originalColor;
            }
        }
    }
}
