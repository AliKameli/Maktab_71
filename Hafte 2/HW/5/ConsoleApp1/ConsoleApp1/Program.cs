﻿void sort(int[] arr, int startIndex, int endIndex)
{
    if (startIndex < endIndex)
    {
        // Find the middle
        // point
        int middleIndex = startIndex + (endIndex - startIndex) / 2;

        // Sort first and
        // second halves
        sort(arr, startIndex, middleIndex);
        sort(arr, middleIndex + 1, endIndex);

        // Merge the sorted halves
        merge(arr, startIndex, middleIndex, endIndex);
    }
}
void merge(int[] arr, int leftIndex, int midleIndex, int rightIndex)
{
    // Find sizes of two
    // subarrays to be merged
    int leftArrLength = midleIndex - leftIndex + 1;
    int rightArrLength = rightIndex - midleIndex;

    // Create temp arrays
    int[] leftTempArr = new int[leftArrLength];
    int[] rightTempArr = new int[rightArrLength];

    // Copy data to temp arrays
    for (int i = 0; i < leftArrLength; ++i)
        leftTempArr[i] = arr[leftIndex + i];
    for (int j = 0; j < rightArrLength; ++j)
        rightTempArr[j] = arr[midleIndex + 1 + j];

    // Merge the temp arrays

    // Initial indexes of first
    // and second subarrays
    int insertedFromLeftArr = 0;
    int insertedFromRightArr = 0;

    // Initial index of merged
    // subarray array
    int insertedIndex = leftIndex;
    while (insertedFromLeftArr < leftArrLength && insertedFromRightArr < rightArrLength)
    {
        if (leftTempArr[insertedFromLeftArr] <= rightTempArr[insertedFromRightArr])
        {
            arr[insertedIndex] = leftTempArr[insertedFromLeftArr];
            insertedFromLeftArr++;
        }
        else
        {
            arr[insertedIndex] = rightTempArr[insertedFromRightArr];
            insertedFromRightArr++;
        }
        insertedIndex++;
    }
    // Copy remaining elements
    while (insertedFromLeftArr < leftArrLength)
    {
        arr[insertedIndex] = leftTempArr[insertedFromLeftArr];
        insertedFromLeftArr++;
        insertedIndex++;
    }
    while (insertedFromRightArr < rightArrLength)
    {
        arr[insertedIndex] = rightTempArr[insertedFromRightArr];
        insertedFromRightArr++;
        insertedIndex++;
    }
}

