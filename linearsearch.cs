class LS
{
    public static void Mainlinear(string[] args)
    {
      int[] element = {45,87,30,20,97,63};
      int item = 63;
      int noe = element.Length;
      int flag = -1;

      for(int i=0;i<noe;i++)
    {
      if(element[i]==item)
      {
      Console.WriteLine("The item " + item + " is found in position " + (i+1));
      flag = -1;
      break;
      }
      else
        flag = 20;
    }
    if(flag==20)
    Console.WriteLine("The item " + " is NOT found.");
    }
}

