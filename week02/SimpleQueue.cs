using System;
using System.Collections.Generic;

Console.WriteLine("\n======================\nSimple Queue\n======================");

//enqueue = to add 
//dequeue = to remove the firt number
var queue = new Queue<int>();
queue.Enqueue(1);//1
queue.Enqueue(2);//1 2
queue.Enqueue(3);// 1 2 3
queue.Dequeue();// 2 3
queue.Dequeue();//3
queue.Enqueue(4);//3 4
queue.Enqueue(5);//3 4 5
queue.Dequeue();//4 5
queue.Enqueue(6);//4 5 6
queue.Enqueue(7);//4 5 6 7
queue.Enqueue(8);//4 5 6 7 8
queue.Enqueue(9);//4 5 6 7 8 9
queue.Dequeue();//5 6 7 8 9
queue.Dequeue();//6 7 8  9
queue.Enqueue(10);
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
queue.Enqueue(11);
queue.Enqueue(12);
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
queue.Enqueue(13);
queue.Enqueue(14);
queue.Enqueue(15);
queue.Enqueue(16);
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
queue.Enqueue(17);
queue.Enqueue(18);
queue.Dequeue();
queue.Enqueue(19);
queue.Enqueue(20);
queue.Dequeue();
queue.Dequeue();

Console.WriteLine("Final contents:");
Console.WriteLine(String.Join(", ", queue.ToArray()));