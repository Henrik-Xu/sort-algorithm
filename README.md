# sort-algorithm

A sorting algorithm is an algorithm made up of a series of instructions that takes an array as input, performs specified

operations on the array,sometimes called a list, and outputs a sorted array. Sorting algorithms are often taught early

in computer science classes as they provide a straightforward way to introduce other key computer science topics like

Big-O notation, divide-and-conquer methods, and data structures such as binary trees, and heaps. There are many factors

to consider when choosing a sorting algorithm to use.

### BubbleSort

[BubbleSort](https://github.com/Damon-Salvatore/sort-algorithm/blob/master/SortAlgorithm/BubbleSortAlgorithm.cs) is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.

<p align="center">
<img src="https://github.com/Damon-Salvatore/sort-algorithm/blob/master/images/BubbleSort.gif"/>
</p>

### InsertionSort

[InsertionSort](https://github.com/Damon-Salvatore/sort-algorithm/blob/master/SortAlgorithm/InsertSortAlgorithm.cs) is a simple sorting algorithm that works the way we sort playing cards in our hands.

<p align="center">
<img src="https://github.com/Damon-Salvatore/sort-algorithm/blob/master/images/InsertionSort.gif"/>
</p>

### SelectionSort

[SelectionSort](https://github.com/Damon-Salvatore/sort-algorithm/blob/master/SortAlgorithm/SelectionSortAlgorithm.cs) algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) from unsorted part and

putting it at the beginning. The algorithm maintains two subarrays in a given array.

### ShellSort

In [ShellSort](https://github.com/Damon-Salvatore/sort-algorithm/blob/master/SortAlgorithm/ShellSortAlgorithm.cs) ,we make the array h-sorted for a large value of h. We keep reducing the value of h until it becomes 1. An array is said to be h-sorted if all sublists of every h’th element is sorted.

### MergeSort

[MergeSort](https://github.com/Damon-Salvatore/sort-algorithm/blob/master/SortAlgorithm/MergeSortAlgorithm.cs) is a Divide and Conquer algorithm. It divides input array in two halves, calls itself for the two halves and then merges the two sorted halves.

<p align="center">
<img src="https://github.com/Damon-Salvatore/sort-algorithm/blob/master/images/MergeSort.gif"/>
</p>

### HeapSort

[HeapSort](https://github.com/Damon-Salvatore/sort-algorithm/blob/master/SortAlgorithm/HeapSortAlgorithm.cs) is a comparison based sorting technique based on Binary Heap data structure. It is similar to selection sort where we first find the maximum element and place the maximum element at the end. We repeat the same process for remaining element.

<p align="center">
<img src="https://github.com/Damon-Salvatore/sort-algorithm/blob/master/images/HeapSort.gif"/>
</p>

### QuickSort

[QuickSort](https://github.com/Damon-Salvatore/sort-algorithm/blob/master/SortAlgorithm/QuickSortAlgorithm.cs) is a Divide and Conquer algorithm. It picks an element as pivot and partitions the given array around the picked pivot.

<p align="center">
<img src="https://github.com/Damon-Salvatore/sort-algorithm/blob/master/images/QuickSort.gif"/>
</p>
