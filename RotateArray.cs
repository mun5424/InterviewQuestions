
    class RotateArray
    {
        public static int[] rotateArray(int[] array, int k)
        {
        
            //given an array of numbers, rotate it by k indices. 
            //ex ) [1,2,3,4,5] with k = 2 
            // =>  [3,4,5,1,2] 

            //solution 1 - make an array copy. 
            
            //check if k is bigger than the size of the array. 
            if(k > array.Length)
                k = k % array.Length; 
            int[] res = new int[array.Length]; 
            for(int i = 0; i < k; i++)
            {
                res[i] = array[array.Length - k + i];
            }
            
            int j = 0; 
            for(int i = k; i < array.Length; i++)
            {
                res[i] = array[j];
                j++;
            }
            

        }
    }