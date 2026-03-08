using UnityEngine;

public class PieceController : MonoBehaviour
{
    public Piece piece;
    public PieceColor color;
    public Vector2 correspondingLocation;
    public GameObject gameManager;
    private bool showSpaces = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.parent != null)
        {
            correspondingLocation = this.transform.parent.GetComponent<SquareController>().location;
        }
    }

    public void MovePiece()
    {
        ToggleSpaces();
    }

    public void ToggleSpaces()
    {
        showSpaces = !showSpaces;
        if(showSpaces)
            gameManager.GetComponent<PieceMovementHandler>().pieceToMove = this.gameObject;
        else
            gameManager.GetComponent<PieceMovementHandler>().pieceToMove = null;
    }
}
