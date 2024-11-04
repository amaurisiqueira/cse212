public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
            int largo=select.Length;
            int [] results = new int[largo];
            int [] positions= new int[2];
            positions[0]=0;
            positions[1]=0;
            int myposition =0  ;
            for(int iterator= 0 ; iterator< largo;iterator++ ){

                    int myselector = select[iterator];
                    switch(myselector){
                        case  1: 
                            myposition = positions[0] ;                          
                            results[iterator] =  list1[ myposition++  ] ;
                            positions[0] = myposition ;

                        break;
                        case  2:
                                 myposition = positions[1] ;       
                                results[iterator] =  list2[ myposition++ ] ;
                                  positions[1] = myposition;   
                        break;
                    }


            }//




        return results;
    }
}