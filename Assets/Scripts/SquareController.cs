using UnityEngine;
using UnityEngine.UI;

public class SquareController : MonoBehaviour
{
    public Vector2 location;
    public Piece currentPiece;
    public PieceColor color;
    public bool steppable;
    public GameObject chessPiece;

    public GameObject whiteKing;
    public GameObject blackKing;
    public GameObject whiteQueen;
    public GameObject blackQueen;
    public GameObject whiteBishop;
    public GameObject blackBishop;
    public GameObject whiteRook;
    public GameObject blackRook;
    public GameObject whiteKnight;
    public GameObject blackKnight;

    public Color originalColor;

    void Start()
    {
        originalColor = this.GetComponent<Image>().color;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        if (color == PieceColor.White)
        {
            switch (currentPiece)
            {
                case Piece.King:
                    chessPiece = Instantiate(whiteKing, this.gameObject.transform);
                    break;

                case Piece.Queen:
                    chessPiece = Instantiate(whiteQueen, this.gameObject.transform);
                    break;

                case Piece.Bishop:
                    chessPiece = Instantiate(whiteBishop, this.gameObject.transform);
                    break;

                case Piece.Rook:
                    chessPiece = Instantiate(whiteRook, this.gameObject.transform);
                    break;

                case Piece.Knight:
                    chessPiece = Instantiate(whiteKnight, this.gameObject.transform);
                    break;
            }
        }
        else if (color == PieceColor.Black)
        {
            switch (currentPiece)
            {
                case Piece.King:
                    chessPiece = Instantiate(blackKing, this.gameObject.transform);
                    break;

                case Piece.Queen:
                    chessPiece = Instantiate(blackQueen, this.gameObject.transform);
                    break;

                case Piece.Bishop:
                    chessPiece = Instantiate(blackBishop, this.gameObject.transform);
                    break;

                case Piece.Rook:
                    chessPiece = Instantiate(blackRook, this.gameObject.transform);
                    break;

                case Piece.Knight:
                    chessPiece = Instantiate(blackKnight, this.gameObject.transform);
                    break;
            }
        }

        //if(chessPiece != null) 
            //chessPiece.GetComponent<PieceController>().correspondingLocation = location;
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
}

public enum Piece
{
    None, 
    King,
    Queen,
    Bishop,
    Rook,
    Knight
}

public enum PieceColor
{
    None,
    Black,
    White
}