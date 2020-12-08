namespace TriangleTracker
{

  public class CheckTriangle
  {

    public bool IsTriangle(int side1, int side2, int side3)
    {
      if (side1 == side2 && side2 == side3)
      {
        return true;
      }else if (side1 == side2 && side2 != side3)
      {
        return true;
      } else { 
        return true;
      }
    }
  }
}