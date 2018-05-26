
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
            
            //copy from beginning of the array
            for(int i = 0; i < k; i++)
            {
                res[i] = array[array.Length - k + i];
            }
            
            //copy the rest
            int j = 0; 
            for(int i = k; i < array.Length; i++)
            {
                res[i] = array[j];
                j++;
            }
            return res;

        }
        public static int[] rotateArrayOptimal(int[] array, int k)
        {
            //solution 2 - reverse method
            
            //elegant and clever method to reverse array before k, after k, and then reverse them altogether.
            if(k > array.Length)
                k = k % array.Length; 
            reverseArray(array, 0, k - 1);
            reverseArray(array, k, array.Length - 1);
            reverseArray(array, 0, array.Length - 1);
            return array;

        }
        public static int[] reverseArray(int[] array, int start, int end)
        {
            int left = start;
            int right = end; 

            while(left < right)
            {
                int temp = array[left]; 
                array[left] = array[right];
                array[right] = temp; 
                left++;
                right--; 
            }
            return array; 
        }
    }