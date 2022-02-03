using UnityEngine;

public class Cube : MonoBehaviour
{
   [SerializeField] private SideCube[] sidesOfCube;
   [SerializeField] private SideCube currentSideAbove;


   public SideCube[] SidesOfCube => sidesOfCube;
   public SideCube CurrentSideAbove => currentSideAbove;


   private void Awake()
   {
      sidesOfCube = new SideCube[transform.childCount];
      sidesOfCube = GetComponentsInChildren<SideCube>();
      
     
   }

   public void SetCurrentSide(int number)
   {
      foreach (SideCube side in sidesOfCube)
      {
         if (side.Number == number)
            currentSideAbove = side;
      }
   }

}
