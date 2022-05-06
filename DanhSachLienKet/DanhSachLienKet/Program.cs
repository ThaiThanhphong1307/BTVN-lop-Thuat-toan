using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachLienKet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node node8 = new Node(8, null);
            Node Head = node8;

            //chèn vào đầu
            Node node7 = new Node(7, null);
            node7.next = Head;
            Head = node7;

            Node node4 = new Node(4, null);
            node4.next = Head;
            Head = node4;

            Node node3 = new Node(3, null);
            node3.next = Head;
            Head = node3;

            Node node9 = new Node(9, null);
            node9.next = Head;
            Head = node9;

            //chèn vào giữa
            Node node5 = new Node(5, null);
            node5.next = node4;
            node3.next = node5;

            //chèn vào cuối
            Node node2 = new Node(2, null);
            node8.next = node2;

            //in ra danh sách kiên kết
            var p = Head;
            while (p != null)
            {
                Console.WriteLine(p.data);
                p = p.next;
            }

            //cộng danh sách liên kết
            int sum = 0;
            var q = Head;
            while (q != null)
            {
                sum = sum + q.data;
                q = q.next;
            }
            Console.Write("tong cua danh sach lien ket la: ");
            Console.WriteLine(sum);

            //in ra số chẵn trong danh sách liên kết
            var w = Head;
            Console.WriteLine("cac so chan trong danh sach lien ket la:");
            while (w != null)
            {
                if(w.data % 2 == 0)
                {
                    Console.WriteLine(w.data);
                }
                w = w.next;
            }
        }
    }
}
