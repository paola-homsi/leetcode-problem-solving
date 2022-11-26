public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        
        Heap heap = new Heap(k);
        for(int i = 0; i < nums.Length; i++){
            if(heap.Size() < k){
                heap.Insert(nums[i]);
            }
            else{
                if(heap.Peek() < nums[i]){
                    heap.Pop();
                    heap.Insert(nums[i]);
                }
            }
        }
        return heap.Pop();
        
    }
    
    public class Heap{
        private int[] arr;
        private int size;
        
        public Heap(int _size){
            arr = new int[_size];
            size = 0;
        }
        public int Size(){
            return size;
        }
        
        public int Peek(){
            if(size == 0){
                throw new IndexOutOfRangeException("Yeap is empty.");
            }
            return arr[0];
        }
        public int Pop(){
            if(size == 0){
                throw new IndexOutOfRangeException("Yeap is empty.");
            }
            int value = arr[0];
            arr[0] = arr[size-1];
            size--;
            HeapifyDown();
            return value;
        }
        public void Insert(int value){
            if(arr.Length == size){
                throw new IndexOutOfRangeException("Heap is full");
            }
            arr[size] = value;
            size++;
            HeapifyUp();
        }
        private void HeapifyUp(){
            
            int index = size - 1;
            
            while(index != 0 && arr[index] < arr[(index-1)/2]){
                int parent = (index - 1) / 2;
                int temp = arr[index];
                arr[index] = arr[parent];
                arr[parent] = temp;
                index = parent;
            }
            
        }
        private void HeapifyDown(){
            int index = 0;
            
            while(GetLeftChildIndex(index) < size){
                int smallerIndex = GetLeftChildIndex(index);
                int rightChildIndex = GetRightChildIndex(index);
                
                if(rightChildIndex < size && arr[rightChildIndex]< arr[smallerIndex] ){
                    smallerIndex = rightChildIndex;
                } 
                if(arr[index] > arr[smallerIndex]){
                    int temp = arr[index];
                    arr[index] = arr[smallerIndex];
                    arr[smallerIndex] = temp;
                }
                index = smallerIndex;
            }
        }
        private int GetLeftChildIndex(int index){
            return (2 * index) + 1;
        }
        private int GetRightChildIndex(int index){
            return (2 * index) + 2;
        }
    }
}